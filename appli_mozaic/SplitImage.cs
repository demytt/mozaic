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
    class SplitImage
    {

        public static Bitmap getRectangle(Bitmap img, int x, int y, int largeur, int hauteur)
        {
            int xlim = Math.Min(largeur, img.Width - x);
            int ylim = Math.Min(hauteur, img.Height - y);
            return img.Clone(new Rectangle(x, y, xlim, ylim), img.PixelFormat);
        }

        

        /*public void splitImage(int N, Bitmap img)
        {
            int height = img.Height;
            int width = img.Width;

            for (int i = 0; i < N * N; i++)
            {
                int h = height / N;
                int w = width / N;
                int a = w * (i % N);
                int b = h * (i / N);
                Bitmap splitted = getRectangle(img, a, b, w, h);
                splitted.Save(@"C:\Users\demytt\Desktop\temp\mozaic\test" + i + ".png");
            }
        }*/
    }
}
