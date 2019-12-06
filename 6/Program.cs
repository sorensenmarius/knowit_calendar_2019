using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bm = (Bitmap)System.Drawing.Image.FromFile("mush.png", true);
            Bitmap tmp = new Bitmap(bm.Width, bm.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (x == 0 && y == 0) continue;
                    Color c1;
                    Color c2 = bm.GetPixel(x, y);
                    if(x == 0)
                    {
                        c1 = bm.GetPixel(bm.Width - 1, y - 1);
                    }
                    else
                    {
                        c1 = bm.GetPixel(x - 1, y);
                    }
                    tmp.SetPixel(x, y, Color.FromArgb(c1.R ^ c2.R, c1.G ^ c2.G, c1.B ^ c2.B));
                }
            }
            tmp.Save("result.jpg", ImageFormat.Jpeg);
        }
    }
}
