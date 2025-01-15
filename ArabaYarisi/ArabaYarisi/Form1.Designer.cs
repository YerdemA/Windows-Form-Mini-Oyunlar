namespace ArabaYarisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            this.SuspendLayout();
            // 
            // araba2
            // 
            this.araba2.Image = global::ArabaYarisi.Properties.Resources.arabaNo7;
            this.araba2.Location = new System.Drawing.Point(315, 413);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(135, 179);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 1;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::ArabaYarisi.Properties.Resources.arabaNo3;
            this.araba1.Location = new System.Drawing.Point(88, 413);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(135, 179);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 0;
            this.araba1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "-------------------------Bitis-------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "W ve yukarı ok tuşuyla oynanır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.araba1);
            this.Controls.Add(this.araba2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

