
namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.histogramCore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histogramZnormalizowany = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GaussianBlur = new System.Windows.Forms.PictureBox();
            this.bluredPicture = new System.Windows.Forms.PictureBox();
            this.obrazekPodstawa = new System.Windows.Forms.PictureBox();
            this.pictureNormalized = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.histogramCore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramZnormalizowany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluredPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazekPodstawa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalized)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramCore
            // 
            chartArea1.Name = "ChartArea1";
            this.histogramCore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogramCore.Legends.Add(legend1);
            this.histogramCore.Location = new System.Drawing.Point(12, 503);
            this.histogramCore.Name = "histogramCore";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "red";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "green";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "blue";
            this.histogramCore.Series.Add(series1);
            this.histogramCore.Series.Add(series2);
            this.histogramCore.Series.Add(series3);
            this.histogramCore.Size = new System.Drawing.Size(419, 300);
            this.histogramCore.TabIndex = 0;
            this.histogramCore.Text = "chart1";
            // 
            // histogramZnormalizowany
            // 
            chartArea2.Name = "ChartArea1";
            this.histogramZnormalizowany.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.histogramZnormalizowany.Legends.Add(legend2);
            this.histogramZnormalizowany.Location = new System.Drawing.Point(437, 503);
            this.histogramZnormalizowany.Name = "histogramZnormalizowany";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "red";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "green";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "blue";
            this.histogramZnormalizowany.Series.Add(series4);
            this.histogramZnormalizowany.Series.Add(series5);
            this.histogramZnormalizowany.Series.Add(series6);
            this.histogramZnormalizowany.Size = new System.Drawing.Size(419, 300);
            this.histogramZnormalizowany.TabIndex = 1;
            this.histogramZnormalizowany.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(129, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Histogram zdjęcia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(575, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Histogram kumulacyjny";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GaussianBlur
            // 
            this.GaussianBlur.Image = global::Lab7.Properties.Resources.IMG_7884_niskokontrast;
            this.GaussianBlur.Location = new System.Drawing.Point(1100, 12);
            this.GaussianBlur.Name = "GaussianBlur";
            this.GaussianBlur.Size = new System.Drawing.Size(328, 447);
            this.GaussianBlur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GaussianBlur.TabIndex = 7;
            this.GaussianBlur.TabStop = false;
            // 
            // bluredPicture
            // 
            this.bluredPicture.Image = global::Lab7.Properties.Resources.IMG_7884_niskokontrast;
            this.bluredPicture.Location = new System.Drawing.Point(733, 12);
            this.bluredPicture.Name = "bluredPicture";
            this.bluredPicture.Size = new System.Drawing.Size(328, 447);
            this.bluredPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluredPicture.TabIndex = 4;
            this.bluredPicture.TabStop = false;
            // 
            // obrazekPodstawa
            // 
            this.obrazekPodstawa.Image = global::Lab7.Properties.Resources.FpJPDxu;
            this.obrazekPodstawa.Location = new System.Drawing.Point(-1, -27);
            this.obrazekPodstawa.Name = "obrazekPodstawa";
            this.obrazekPodstawa.Size = new System.Drawing.Size(3840, 1080);
            this.obrazekPodstawa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obrazekPodstawa.TabIndex = 3;
            this.obrazekPodstawa.TabStop = false;
            // 
            // pictureNormalized
            // 
            this.pictureNormalized.Image = global::Lab7.Properties.Resources.IMG_7884_niskokontrast;
            this.pictureNormalized.Location = new System.Drawing.Point(369, 12);
            this.pictureNormalized.Name = "pictureNormalized";
            this.pictureNormalized.Size = new System.Drawing.Size(328, 447);
            this.pictureNormalized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNormalized.TabIndex = 2;
            this.pictureNormalized.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 815);
            this.Controls.Add(this.GaussianBlur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bluredPicture);
            this.Controls.Add(this.obrazekPodstawa);
            this.Controls.Add(this.pictureNormalized);
            this.Controls.Add(this.histogramZnormalizowany);
            this.Controls.Add(this.histogramCore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.histogramCore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramZnormalizowany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluredPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazekPodstawa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart histogramCore;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramZnormalizowany;
        private System.Windows.Forms.PictureBox pictureNormalized;
        private System.Windows.Forms.PictureBox obrazekPodstawa;
        private System.Windows.Forms.PictureBox bluredPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox GaussianBlur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

