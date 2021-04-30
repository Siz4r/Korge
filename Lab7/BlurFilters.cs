using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab7
{

    class BlurFilters
    {
        Bitmap podstawaBM;
        private Chart histogramCore;
        private Chart histogramNormalized;
        private int[] sredniaIntensywnosc = new int[3];
        private int[] odchylenieStandardowe = new int[3];

        public BlurFilters(Bitmap podstawaBM, Bitmap znormalizowanyBM, Chart histogramCore, Chart histogramNormalized)
        {
            this.podstawaBM = podstawaBM;
            this.histogramCore = histogramCore;
            this.histogramNormalized = histogramNormalized;
        }


        public Bitmap filtrUsredniajacy(int n)
        {
            Color[,] maska = new Color[n, n];
            int[] srednia;
            for (int i = n - 1; i < podstawaBM.Width; i += n)
            {
                for (int j = n - 1; j < podstawaBM.Height; j += n)
                {
                    for (int x = 0; x < n; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            maska[x, y] = podstawaBM.GetPixel(i - x, j - y);
                        }
                    }
                    srednia = sredniaArytmetyczna(maska);
                    for (int x = 0; x < n; x++)
                    {
                        for (int y = 0; y < n; y++)
                        {
                            podstawaBM.SetPixel(i - x, j - y, Color.FromArgb(srednia[0],
                                srednia[1],
                                srednia[2]));
                        }
                    }
                }
            }
            return podstawaBM;
        }

        private int[] sredniaArytmetyczna(Color[,] maska)
        {
            int maskSize = maska.Length / maska.GetLength(1);
            int[] srednie = new int[maskSize];
            for (int i = 0; i < maskSize; i++)
            {
                for (int j = 0; j < maskSize; j++)
                {
                    srednie[0] += maska[i, j].R;
                    srednie[1] += maska[i, j].G;
                    srednie[2] += maska[i, j].B;
                }
            }
            srednie[0] /= maska.Length;
            srednie[1] /= maska.Length;
            srednie[2] /= maska.Length;

            return srednie;
        }
        
        public Bitmap gaussianBlur(int radius)
        {
            var size = (radius * 2) + 1;
            var deviation = radius / 2;
            var mask = new double[size,size];
            double sum = 0.0;
            for(int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    int numerator = -(i * i + j * j);
                    int denominator = 2 * deviation * deviation;
                    var eExpre = Math.Pow(Math.E, numerator / denominator);
                    var value = (eExpre / (2 * Math.PI * deviation * deviation));

                    mask[i + radius, j + radius] = value;
                    sum += value;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mask[i, j] /= sum;
                }
            }

            for (int x = radius; x < podstawaBM.Width - radius; x++)
            {
                for (int y = radius; y < podstawaBM.Height - radius; y++)
                {
                    double red = 0, green = 0, blue = 0;

                    for (int i = -radius; i <= radius; i++)
                    {
                        for (int j = -radius; j <= radius; j++)
                        {
                            double temp = mask[i + radius, j + radius];
                            var pixel = podstawaBM.GetPixel(x - i, y - j);

                            red += pixel.R * temp;
                            green += pixel.G * temp;
                            blue += pixel.B * temp;
                        }
                    }
                    podstawaBM.SetPixel(x, y, Color.FromArgb(
                        checkIfInRgb(red), checkIfInRgb(green), checkIfInRgb(blue)));
                }
            }
            return podstawaBM;
        }

        private int checkIfInRgb(double temp)
        {
            if (temp > 255) return 255;
            else if (temp < 0) return 0;
            return (int)temp;
        }
    }
}
