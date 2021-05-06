using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    
    public partial class Form1 : Form
    {
        List<List<int>> LaplaceV1 = new List<List<int>>() { new List<int>() { 0, 1, 0 },
                                                            new List<int>() { 1, -4, 1 },
                                                            new List<int>() { 0, 1, 0 }};
        List<List<int>> LaplaceV2 = new List<List<int>>() { new List<int>() { 1, 1, 1 },
                                                            new List<int>() { 1, -8, 1 },
                                                            new List<int>() { 1, 1, 1 }};
        List<List<int>> LaplaceV3 = new List<List<int>>() { new List<int>() { 2, -1, 2 },
                                                            new List<int>() { -1, -4, -1 },
                                                            new List<int>() { 2, -1, 2 }};
        List<List<int>> RobertsPion = new List<List<int>>() { new List<int>() { 0, 0, 0 },
                                                              new List<int>() { 0, 1, -1 },
                                                              new List<int>() { 0, 0, 0 }};
        List<List<int>> RobertsPozi = new List<List<int>>() { new List<int>() { 0, 0, 0 },
                                                              new List<int>() { 0, 1, 0 },
                                                              new List<int>() { 0, -1, 0 }};
        List<List<int>> PrewittPion = new List<List<int>>() { new List<int>() { 1, 1, 1 },
                                                              new List<int>() { 0, 0, 0 },
                                                              new List<int>() { -1, -1, -1 }};
        List<List<int>> PrewittPozi = new List<List<int>>() { new List<int>() { 1, 0, -1 },
                                                              new List<int>() { 1, 0, -1 },
                                                              new List<int>() { 1, 0, -1 }};
        List<List<int>> SobelPionow = new List<List<int>>() { new List<int>() { 1, 2, 1 },
                                                              new List<int>() { 0, 0, 0 },
                                                              new List<int>() { -1, -2, -1 }};
        List<List<int>> SobelPoziom = new List<List<int>>() { new List<int>() { 1, 0, -1 },
                                                              new List<int>() { 2, 0, -2 },
                                                              new List<int>() { 1, 0, -1 }};
        Algorithms algorithms;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            algorithms = new Algorithms((Bitmap)pictureBox1.Image);
        }

        private void RobertsPionowy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(RobertsPion);
        }

        private void RobertsPoziomy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(RobertsPozi);
        }

        private void PrewittPionowy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(PrewittPion);
        }

        private void PrewittPoziomy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(PrewittPozi);
        }

        private void SobelPionowy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(SobelPionow);
        }

        private void SobelPoziomy_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(SobelPoziom);
        }

        private void Laplace_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.Lap1(LaplaceV2);
        }

        private void MaksimumBT_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.maksimum((Bitmap)pictureBox1.Image, (Bitmap)pictureBox2.Image);
        }

        private void MedianaBT_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.mediana((Bitmap)pictureBox1.Image, (Bitmap)pictureBox2.Image);
        }

        private void MinimumBT_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = algorithms.minimum((Bitmap)pictureBox1.Image, (Bitmap)pictureBox2.Image);
        }
    }
}
