using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        int red, green, blue;
        Bitmap podstawa, zmodyfikowany;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            podstawa = new Bitmap(pictureBox1.Image);
            zmodyfikowany = new Bitmap(pictureBox2.Image);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            przeksztalc(trackBar1.Value);
            obliczHistogram();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            przeksztalc(50);
        }

        private void przeksztalc(int delta)
        {
            Color cModified;

            for(int i  = 0; i < podstawa.Height; i++)
            {
                for(int j = 0; j < podstawa.Width; j++)
                {
                    Color c = podstawa.GetPixel(j, i);
                    if (delta >= 0)
                    {
                        red = zmianaKontrastuDlaDodatnich(c.R, 127  - delta);
                        green = zmianaKontrastuDlaDodatnich(c.G, 127 - delta);
                        blue = zmianaKontrastuDlaDodatnich(c.B, 127 - delta);
                    } 
                    else
                    {
                        red = zmianaKontrastuDlaUjemnych(c.R, delta);
                        green = zmianaKontrastuDlaUjemnych(c.G, delta);
                        blue = zmianaKontrastuDlaUjemnych(c.B, delta);
                    }
                    
                    zmodyfikowany.SetPixel(j, i, Color.FromArgb(c.A, red, green, blue));
                }
            }

            pictureBox2.Image = zmodyfikowany;
        }

        private int zmianaKontrastuDlaDodatnich(int color, int delta)
        {
            if (color < 127) return (127 - delta) / 127 * color;
            else return (127 - delta) / 127 * color + 2 * delta;
        }

        private int zmianaKontrastuDlaUjemnych(int color, int delta) 
        {
            if (color < 127 + delta) return (127 / (127 + delta)) * color;
            else if (color > 127 - delta) return (127 * color + 255 * delta) / (127 + delta);
            else return 127;
        }


        private void obliczHistogram()
        {
            int[] czerw = new int[256];
            int[] ziel = new int[256];
            int[] nieb = new int[256];

            for(int i = 0; i < podstawa.Width; i++)
            {
                for(int j = 0; j < podstawa.Height; j++)
                {
                    Color pixel = zmodyfikowany.GetPixel(i, j);
                    czerw[pixel.R]++;
                    ziel[pixel.G]++;
                    nieb[pixel.B]++;
                }
            }

            chart1.Series["red"].Points.Clear();
            chart1.Series["green"].Points.Clear();
            chart1.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["red"].Points.AddXY(i, czerw[i]);
                chart1.Series["green"].Points.AddXY(i, czerw[i]);
                chart1.Series["blue"].Points.AddXY(i, czerw[i]);
            }
            chart1.Invalidate();
        }
    }
}
