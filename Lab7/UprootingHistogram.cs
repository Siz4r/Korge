using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab7
{
    class UprootingHistogram
    {
        Bitmap podstawaBM;
        Bitmap znormalizowanyBM;
        int NM;
        private Chart histogramCore;
        private Chart histogramNormalized;
        double[] wartosciHistogramuKumulacyjnegoRED = new double[256];
        double[] wartosciHistogramuKumulacyjnegoGREEN = new double[256];
        double[] wartosciHistogramuKumulacyjnegoBLUE = new double[256];

        public UprootingHistogram(Bitmap podstawaBM, Bitmap znormalizowanyBM, Chart histogramCore, Chart histogramNormalized)
        {
            this.podstawaBM = podstawaBM;
            this.znormalizowanyBM = znormalizowanyBM;
            NM = podstawaBM.Width * podstawaBM.Height;
            this.histogramCore = histogramCore;
            this.histogramNormalized = histogramNormalized;
            histogramPodstawa();
            wypelnijHistogramKumulacyjny();
        }


        private void histogramPodstawa()
        {
            double[] red = new double[256];
            double[] green = new double[256];
            double[] blue = new double[256];
            for (int x = 0; x < podstawaBM.Width; x++)
            {
                for (int y = 0; y < podstawaBM.Height; y++)
                {
                    Color pixel = podstawaBM.GetPixel(x, y);
                    red[pixel.R]++;
                    green[pixel.G]++;
                    blue[pixel.B]++;
                }
            }

            //Wyswietl histogram na wykresie
            histogramCore.Series["red"].Points.Clear();
            histogramCore.Series["green"].Points.Clear();
            histogramCore.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                histogramCore.Series["red"].Points.AddXY(i, red[i] / NM);
                histogramCore.Series["green"].Points.AddXY(i, green[i] / NM);
                histogramCore.Series["blue"].Points.AddXY(i, blue[i] / NM);
            }
            histogramCore.Invalidate();
        }

        private void wypelnijHistogramKumulacyjny()
        {

            for (int i = 0; i < 256; i++)
            {
                wartosciHistogramuKumulacyjnegoRED[i] = histogramKumulacyjny(i, "red");
                wartosciHistogramuKumulacyjnegoGREEN[i] = histogramKumulacyjny(i, "green");
                wartosciHistogramuKumulacyjnegoBLUE[i] = histogramKumulacyjny(i, "blue");
                histogramNormalized.Series["red"].Points.AddXY(i, wartosciHistogramuKumulacyjnegoRED[i]);
                histogramNormalized.Series["green"].Points.AddXY(i, wartosciHistogramuKumulacyjnegoGREEN[i]);
                histogramNormalized.Series["blue"].Points.AddXY(i, wartosciHistogramuKumulacyjnegoBLUE[i]);
            }
        }

        private double histogramKumulacyjny(int stopien, string kolor)
        {
            if (stopien == 0) return histogramCore.Series[kolor].Points[0].YValues[histogramCore.Series[kolor].Points[0].YValues.Length - 1];
            else return histogramCore.Series[kolor].Points[stopien].YValues[histogramCore.Series[kolor].Points[0].YValues.Length - 1]
                    + histogramKumulacyjny(stopien - 1, kolor);
        }

        public Bitmap poprawKontrast()
        {
           
            int r, g, b;
            for (int x = 0; x < podstawaBM.Width; x++)
            {
                for (int y = 0; y < podstawaBM.Height; y++)
                {
                    Color pixel = podstawaBM.GetPixel(x, y);
                    r = (int)(255 * wartosciHistogramuKumulacyjnegoRED[pixel.R]);
                    g = (int)(255 * wartosciHistogramuKumulacyjnegoGREEN[pixel.G]);
                    b = (int)(255 * wartosciHistogramuKumulacyjnegoBLUE[pixel.B]);
                    znormalizowanyBM.SetPixel(x, y, Color.FromArgb(pixel.A, r, g, b));
                }
            }
            return znormalizowanyBM;
        }
    }
}
