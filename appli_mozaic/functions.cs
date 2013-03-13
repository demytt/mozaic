using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace appli_mozaic
{
    class functions
    {
        public static List<string> getListImages(string dossierImages)
        {
            List<string> listImagesTemp = new List<string>();
            var files = Directory.GetFiles(dossierImages).Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png") || s.EndsWith(".bmp"));
            foreach (string f in files)
                listImagesTemp.Add(f);

            return listImagesTemp;
        }

        public static int getOptimalImage(Color rgb, List<Color> listColors, float brightnessWeight, float hueWeight, float saturationWeight)
        {
            float d = ColorRGB.distanceRGB(rgb, listColors[0], brightnessWeight, hueWeight, saturationWeight);
            int index = 0;
            for (int i = 0; i < listColors.Count(); i++)
            {
                float d2 = ColorRGB.distanceRGB(rgb, listColors[i], brightnessWeight, hueWeight, saturationWeight);
                if (d2 <= d)
                {
                    d = d2;
                    index = i;
                }
            }
            return index;
        }

        public static void reduceImage(string filename, List<string> listImages, int size)
        {
            for(int i = 0; i<listImages.Count; i++)
            {
                Bitmap imgtemp = new Bitmap(listImages[i]);
                System.Drawing.Image newImage = imgtemp.GetThumbnailImage(size, size, null, IntPtr.Zero);
                newImage.Save(@filename + "/" + i + ".png");
                newImage.Dispose();
                imgtemp.Dispose();
            }
        }

        public static Bitmap buildImage(Bitmap img, int N, List<Color> listColor, List<string> listImages, float brightness, float hue, float saturation, PictureBox imgBox)
        {
            int height = img.Height;
            int width = img.Width;

            var bitmap = new Bitmap(width, height);
            var canvas = Graphics.FromImage(bitmap);

            canvas.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            for (int i = 0; i < N * N; i++)
            {
                int h = height / N;
                int w = width / N;
                int a = w * (i % N);
                int b = h * (i / N);
                Bitmap splitted = SplitImage.getRectangle(img, a, b, w, h);
                Color rgbRef = ColorRGB.getDominantColor(splitted, 5);

                int index = functions.getOptimalImage(rgbRef, listColor, brightness, hue, saturation);

                Bitmap img1 = new Bitmap(listImages[index]);
                //img1 = ColorRGB.adjustColor(img1, rgbRef);

                canvas.DrawImage(img1, new Rectangle(a, b, w, h), new Rectangle(0, 0, img1.Width, img1.Height), GraphicsUnit.Pixel);
                imgBox.Image = bitmap;
                imgBox.Update();
                img1.Dispose();
            }

            return bitmap;
        }

        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics 
            return bmp;
        }

        public static Bitmap mergeImage(Bitmap imageRef, Bitmap mozaicImage, PictureBox imgBox, float opacity)
        {
            
            var bitmap = new Bitmap(imageRef.Width, imageRef.Height);
            var canvas = Graphics.FromImage(bitmap);

            Bitmap imageRefTemp = ChangeOpacity(imageRef, opacity);

            canvas.DrawImageUnscaled(mozaicImage, 0, 0);
            canvas.DrawImageUnscaled(imageRefTemp, 0, 0);

            imgBox.Image = bitmap;
            imgBox.Update();

            return bitmap;
        }

        public static Bitmap resizeImage(Bitmap img, int newWidth)
        {
            double proportion = (double)img.Height / img.Width;
            int newHeight = Convert.ToInt32(Math.Round(newWidth * proportion));

            System.Drawing.Image newImage = img.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            return new Bitmap(newImage);
        }
    }
}
