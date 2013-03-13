using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace appli_mozaic
{
    class ColorRGB
    {
        public static Color getDominantColor(Bitmap bmp, int n)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = 0; x < bmp.Width - n + 1; x += n)
            {
                for (int y = 0; y < bmp.Height - n + 1; y += n)
                {
                    Color clr = bmp.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    //b += clr.ToArgb();
                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }

        public static Bitmap adjustColor(Bitmap img, Color colRef)
        {
            Color colTemp = new Color();

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    colTemp = img.GetPixel(x, y);

                    int rTemp = (colTemp.R + colRef.R)/2;
                    int gTemp = (colTemp.G + colRef.G)/2;
                    int bTemp = (colTemp.B + colRef.B)/2;

                    colTemp = Color.FromArgb(255, rTemp, gTemp, bTemp);

                    img.SetPixel(x, y, colTemp);
                }
            }

            return img;
        }

        public static List<Color> getColorOfEveryImages(List<string> listImages)
        {
            List<Color> listColorTemp = new List<Color>();
            for (int i = 0; i < listImages.Count(); i++)
            {
                Bitmap imageTemp = new Bitmap(listImages[i]);
                listColorTemp.Add(ColorRGB.getDominantColor(imageTemp, 5));
                imageTemp.Dispose();
            }

            return listColorTemp;
        }

        public static float distanceRGB(Color rgb1, Color rgb2, float brightnessWeight, float hueWeight, float saturationWeight)
        {
            //return (rgb1.R - rgb2.R) ^ 2 + (rgb1.G - rgb2.G) ^ 2 + (rgb1.B - rgb2.B) ^ 2;
            float d = 0;
            d += brightnessWeight * Math.Abs(rgb1.GetBrightness() - rgb2.GetBrightness());
            d += hueWeight * Math.Abs(rgb1.GetHue() - rgb2.GetHue());
            d += saturationWeight * Math.Abs(rgb1.GetSaturation() - rgb2.GetSaturation());

            return d;
        }


    }
}
