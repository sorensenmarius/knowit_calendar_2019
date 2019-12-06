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
                for (int x = 1; x < bm.Width; x++)
                {
                    Color c1 = bm.GetPixel(x - 1, y);
                    Color c2 = bm.GetPixel(x, y);
                    tmp.SetPixel(x, y, Color.FromArgb(c1.R ^ c2.R, c1.G ^ c2.G, c1.G ^ c2.B));
                }
            }
            tmp.Save("result.jpg", ImageFormat.Jpeg);
        }
    }
}
