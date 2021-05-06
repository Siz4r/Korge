using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Algorithms
    {
        Bitmap image;


        public Algorithms(Bitmap image)
        {
            this.image = image;
        }

        public Bitmap Lap1(List<List<int>> mask)
        {
            Color[,] colors = new Color[3, 3];
            var image2 = new Bitmap(image);
            for (int x = 1; x < image.Width - 1; x++)
            {
                for (int y = 1; y < image.Height - 1; y++)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            colors[i + 1, j + 1] = image.GetPixel(x + i, y + j);
                        }
                    }
                    int r = 0, g = 0, b = 0;
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            r += colors[i + 1, j + 1].R * mask[i + 1][j + 1];
                            g += colors[i + 1, j + 1].G * mask[i + 1][j + 1];
                            b += colors[i + 1, j + 1].B * mask[i + 1][j + 1];

                        }
                    }
                    int avg = (r + g + b) / 3;
                    if (avg > 255) avg = 255;
                    if (avg < 0) avg = 0;
                    image2.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
            return image2;
        }

        public Bitmap maksimum(Bitmap image1, Bitmap image2)
        {
            Bitmap b1 = image1;
            Bitmap b2 = image2;
            Color[,] k = new Color[3, 3];
            int r = 0, g = 0, b = 0;
            int[] red = new int[9];
            int[] green = new int[9];
            int[] blue = new int[9];
            List<int> maska = new List<int>() { -1, 0, -1, 0, 4, 0, -1, 0, -1 };
            int indeks;


            for (int x = 0; x < b1.Width; x++)
            {
                if (x == 0 || x == b1.Width - 1)
                {
                    continue;
                }
                for (int y = 0; y < b1.Height; y++)
                {
                    if (y == 0 || y == b1.Height - 1)
                    {
                        continue;
                    }
                    indeks = 0;
                    r = 0;
                    g = 0;
                    b = 0;
                    for (int i = -1; i < 2; i++)
                    {

                        for (int j = -1; j < 2; j++)
                        {

                            k[i + 1, j + 1] = b1.GetPixel(x + i, y + j);

                            red[indeks] = k[i + 1, j + 1].R;
                            green[indeks] = k[i + 1, j + 1].G;
                            blue[indeks] = k[i + 1, j + 1].B;
                            indeks++;
                        }
                    }


                    Array.Sort(red);
                    Array.Sort(green);
                    Array.Sort(blue);
                    r = red[8];
                    g = green[8];
                    b = blue[8];

                    b2.SetPixel(x, y, Color.FromArgb(checkIfInRgb(r), checkIfInRgb(g), checkIfInRgb(b)));

                }
            }
            return b2;
        }

        public Bitmap minimum(Bitmap image1, Bitmap image2)
        {
            Bitmap b1 = image1;
            Bitmap b2 = image2;
            Color[,] k = new Color[3, 3];
            int r = 0, g = 0, b = 0;
            int[] red = new int[9];
            int[] green = new int[9];
            int[] blue = new int[9];
            int indeks;


            for (int x = 0; x < b1.Width; x++)
            {
                if (x == 0 || x == b1.Width - 1)
                {
                    continue;
                }
                for (int y = 0; y < b1.Height; y++)
                {
                    if (y == 0 || y == b1.Height - 1)
                    {
                        continue;
                    }
                    indeks = 0;
                    for (int i = -1; i < 2; i++)
                    {

                        for (int j = -1; j < 2; j++)
                        {

                            k[i + 1, j + 1] = b1.GetPixel(x + i, y + j);

                            red[indeks] = k[i + 1, j + 1].R;
                            green[indeks] = k[i + 1, j + 1].G;
                            blue[indeks] = k[i + 1, j + 1].B;
                            indeks++;
                        }
                    }
                    Array.Sort(red);
                    Array.Sort(green);
                    Array.Sort(blue);
                    r = red[0];
                    g = green[0];
                    b = blue[0];

                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            return b2;
        }



        public Bitmap mediana(Bitmap image1, Bitmap image2)
        {
            Bitmap b1 = image1;
            Bitmap b2 = image2;
            Color[,] k = new Color[3, 3];
            int r = 0, g = 0, b = 0;
            int[] red = new int[9];
            int[] green = new int[9];
            int[] blue = new int[9];
            int indeks;


            for (int x = 0; x < b1.Width; x++)
            {
                if (x == 0 || x == b1.Width - 1)
                {
                    continue;
                }
                for (int y = 0; y < b1.Height; y++)
                {
                    if (y == 0 || y == b1.Height - 1)
                    {
                        continue;
                    }
                    indeks = 0;
                    r = 0;
                    g = 0;
                    b = 0;
                    for (int i = -1; i < 2; i++)
                    {

                        for (int j = -1; j < 2; j++)
                        {

                            k[i + 1, j + 1] = b1.GetPixel(x + i, y + j);

                            red[indeks] = k[i + 1, j + 1].R;
                            green[indeks] = k[i + 1, j + 1].G;
                            blue[indeks] = k[i + 1, j + 1].B;
                            indeks++;
                        }
                    }
                    Array.Sort(red);
                    Array.Sort(green);
                    Array.Sort(blue);

                    r = red[4];
                    g = green[4];
                    b = blue[4];

                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            return b2;
        }

        private int checkIfInRgb(double temp)
        {
            if (temp > 255) return 255;
            else if (temp < 0) return 0;
            return (int)temp;
        }
    }
}
