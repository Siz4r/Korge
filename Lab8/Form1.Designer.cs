
namespace Lab8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RobertsPionowy = new System.Windows.Forms.Button();
            this.RobertsPoziomy = new System.Windows.Forms.Button();
            this.PrewittPionowy = new System.Windows.Forms.Button();
            this.PrewittPoziomy = new System.Windows.Forms.Button();
            this.SobelPionowy = new System.Windows.Forms.Button();
            this.SobelPoziomy = new System.Windows.Forms.Button();
            this.Laplace = new System.Windows.Forms.Button();
            this.MaksimumBT = new System.Windows.Forms.Button();
            this.MedianaBT = new System.Windows.Forms.Button();
            this.MinimumBT = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab8.Properties.Resources.kwiatek;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 669);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab8.Properties.Resources.kwiatek;
            this.pictureBox2.Location = new System.Drawing.Point(963, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 669);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // RobertsPionowy
            // 
            this.RobertsPionowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RobertsPionowy.Location = new System.Drawing.Point(637, 50);
            this.RobertsPionowy.Name = "RobertsPionowy";
            this.RobertsPionowy.Size = new System.Drawing.Size(200, 40);
            this.RobertsPionowy.TabIndex = 2;
            this.RobertsPionowy.Text = "RobertsPionowy";
            this.RobertsPionowy.UseVisualStyleBackColor = true;
            this.RobertsPionowy.Click += new System.EventHandler(this.RobertsPionowy_Click);
            // 
            // RobertsPoziomy
            // 
            this.RobertsPoziomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RobertsPoziomy.Location = new System.Drawing.Point(637, 96);
            this.RobertsPoziomy.Name = "RobertsPoziomy";
            this.RobertsPoziomy.Size = new System.Drawing.Size(200, 40);
            this.RobertsPoziomy.TabIndex = 3;
            this.RobertsPoziomy.Text = "RobertsPoziomy";
            this.RobertsPoziomy.UseVisualStyleBackColor = true;
            this.RobertsPoziomy.Click += new System.EventHandler(this.RobertsPoziomy_Click);
            // 
            // PrewittPionowy
            // 
            this.PrewittPionowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrewittPionowy.Location = new System.Drawing.Point(637, 142);
            this.PrewittPionowy.Name = "PrewittPionowy";
            this.PrewittPionowy.Size = new System.Drawing.Size(200, 40);
            this.PrewittPionowy.TabIndex = 4;
            this.PrewittPionowy.Text = "PrewittPionowy";
            this.PrewittPionowy.UseVisualStyleBackColor = true;
            this.PrewittPionowy.Click += new System.EventHandler(this.PrewittPionowy_Click);
            // 
            // PrewittPoziomy
            // 
            this.PrewittPoziomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrewittPoziomy.Location = new System.Drawing.Point(637, 188);
            this.PrewittPoziomy.Name = "PrewittPoziomy";
            this.PrewittPoziomy.Size = new System.Drawing.Size(200, 40);
            this.PrewittPoziomy.TabIndex = 5;
            this.PrewittPoziomy.Text = "PrewittPoziomy";
            this.PrewittPoziomy.UseVisualStyleBackColor = true;
            this.PrewittPoziomy.Click += new System.EventHandler(this.PrewittPoziomy_Click);
            // 
            // SobelPionowy
            // 
            this.SobelPionowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SobelPionowy.Location = new System.Drawing.Point(637, 234);
            this.SobelPionowy.Name = "SobelPionowy";
            this.SobelPionowy.Size = new System.Drawing.Size(200, 40);
            this.SobelPionowy.TabIndex = 6;
            this.SobelPionowy.Text = "SobelPionowy";
            this.SobelPionowy.UseVisualStyleBackColor = true;
            this.SobelPionowy.Click += new System.EventHandler(this.SobelPionowy_Click);
            // 
            // SobelPoziomy
            // 
            this.SobelPoziomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SobelPoziomy.Location = new System.Drawing.Point(637, 280);
            this.SobelPoziomy.Name = "SobelPoziomy";
            this.SobelPoziomy.Size = new System.Drawing.Size(200, 40);
            this.SobelPoziomy.TabIndex = 7;
            this.SobelPoziomy.Text = "SobelPoziomy";
            this.SobelPoziomy.UseVisualStyleBackColor = true;
            this.SobelPoziomy.Click += new System.EventHandler(this.SobelPoziomy_Click);
            // 
            // Laplace
            // 
            this.Laplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Laplace.Location = new System.Drawing.Point(637, 326);
            this.Laplace.Name = "Laplace";
            this.Laplace.Size = new System.Drawing.Size(200, 40);
            this.Laplace.TabIndex = 8;
            this.Laplace.Text = "Laplace";
            this.Laplace.UseVisualStyleBackColor = true;
            this.Laplace.Click += new System.EventHandler(this.Laplace_Click);
            // 
            // MaksimumBT
            // 
            this.MaksimumBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaksimumBT.Location = new System.Drawing.Point(637, 563);
            this.MaksimumBT.Name = "MaksimumBT";
            this.MaksimumBT.Size = new System.Drawing.Size(200, 40);
            this.MaksimumBT.TabIndex = 9;
            this.MaksimumBT.Text = "Maksimum";
            this.MaksimumBT.UseVisualStyleBackColor = true;
            this.MaksimumBT.Click += new System.EventHandler(this.MaksimumBT_Click);
            // 
            // MedianaBT
            // 
            this.MedianaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedianaBT.Location = new System.Drawing.Point(637, 609);
            this.MedianaBT.Name = "MedianaBT";
            this.MedianaBT.Size = new System.Drawing.Size(200, 40);
            this.MedianaBT.TabIndex = 10;
            this.MedianaBT.Text = "Mediana";
            this.MedianaBT.UseVisualStyleBackColor = true;
            this.MedianaBT.Click += new System.EventHandler(this.MedianaBT_Click);
            // 
            // MinimumBT
            // 
            this.MinimumBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumBT.Location = new System.Drawing.Point(637, 655);
            this.MinimumBT.Name = "MinimumBT";
            this.MinimumBT.Size = new System.Drawing.Size(200, 40);
            this.MinimumBT.TabIndex = 11;
            this.MinimumBT.Text = "Minimum";
            this.MinimumBT.UseVisualStyleBackColor = true;
            this.MinimumBT.Click += new System.EventHandler(this.MinimumBT_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.BackColor = System.Drawing.SystemColors.Highlight;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.F.Location = new System.Drawing.Point(690, 12);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(82, 35);
            this.F.TabIndex = 12;
            this.F.Text = "Filtry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(608, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtry statystyczne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 818);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F);
            this.Controls.Add(this.MinimumBT);
            this.Controls.Add(this.MedianaBT);
            this.Controls.Add(this.MaksimumBT);
            this.Controls.Add(this.Laplace);
            this.Controls.Add(this.SobelPoziomy);
            this.Controls.Add(this.SobelPionowy);
            this.Controls.Add(this.PrewittPoziomy);
            this.Controls.Add(this.PrewittPionowy);
            this.Controls.Add(this.RobertsPoziomy);
            this.Controls.Add(this.RobertsPionowy);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RobertsPionowy;
        private System.Windows.Forms.Button RobertsPoziomy;
        private System.Windows.Forms.Button PrewittPionowy;
        private System.Windows.Forms.Button PrewittPoziomy;
        private System.Windows.Forms.Button SobelPionowy;
        private System.Windows.Forms.Button SobelPoziomy;
        private System.Windows.Forms.Button Laplace;
        private System.Windows.Forms.Button MaksimumBT;
        private System.Windows.Forms.Button MedianaBT;
        private System.Windows.Forms.Button MinimumBT;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label label1;
    }
}

