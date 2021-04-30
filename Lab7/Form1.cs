using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{

    public partial class Form1 : Form
    {
        Image podstawa;
        Bitmap podstawaBM;
        Bitmap znormalizowanyBM;
        Bitmap gaussBM;
        int NM;

        int sredniaWartoscIntensywnosci;
        int odchylenieStandardowe;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UprootingHistogram uprooting = new UprootingHistogram(
                new Bitmap(obrazekPodstawa.Image),
                new Bitmap(obrazekPodstawa.Image),
                histogramCore, histogramZnormalizowany);
            BlurFilters blur = new BlurFilters(
                new Bitmap(obrazekPodstawa.Image),
                new Bitmap(obrazekPodstawa.Image),
                histogramCore, histogramZnormalizowany);

            pictureNormalized.Image = uprooting.poprawKontrast();
            //bluredPicture.Image = blur.filtrUsredniajacy(5);
            //GaussianBlur.Image = blur.gaussianBlur(3);
        }
      
    }
}
