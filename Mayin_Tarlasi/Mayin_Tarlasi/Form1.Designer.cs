namespace Mayin_Tarlasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mayinSayLabel = new System.Windows.Forms.Label();
            this.standartStart = new System.Windows.Forms.Button();
            this.mapGorBut = new System.Windows.Forms.Button();
            this.hamleLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.numUpMayin = new System.Windows.Forms.NumericUpDown();
            this.sayiTeyitLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.mayinSayisiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpMayin)).BeginInit();
            this.SuspendLayout();
            // 
            // mayinSayLabel
            // 
            this.mayinSayLabel.AutoSize = true;
            this.mayinSayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mayinSayLabel.Location = new System.Drawing.Point(856, 157);
            this.mayinSayLabel.Name = "mayinSayLabel";
            this.mayinSayLabel.Size = new System.Drawing.Size(154, 25);
            this.mayinSayLabel.TabIndex = 21;
            this.mayinSayLabel.Text = "Mayin Sayisi : ";
            this.mayinSayLabel.Visible = false;
            // 
            // standartStart
            // 
            this.standartStart.BackColor = System.Drawing.Color.Bisque;
            this.standartStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standartStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.standartStart.Location = new System.Drawing.Point(423, 489);
            this.standartStart.Name = "standartStart";
            this.standartStart.Size = new System.Drawing.Size(144, 90);
            this.standartStart.TabIndex = 20;
            this.standartStart.Text = "Standart Mayın Sayısı İle Başla";
            this.standartStart.UseVisualStyleBackColor = false;
            this.standartStart.Click += new System.EventHandler(this.standartStart_Click);
            // 
            // mapGorBut
            // 
            this.mapGorBut.BackColor = System.Drawing.Color.Azure;
            this.mapGorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapGorBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mapGorBut.Location = new System.Drawing.Point(918, 132);
            this.mapGorBut.Name = "mapGorBut";
            this.mapGorBut.Size = new System.Drawing.Size(116, 72);
            this.mapGorBut.TabIndex = 19;
            this.mapGorBut.Text = "Haritayı Gör";
            this.mapGorBut.UseVisualStyleBackColor = false;
            this.mapGorBut.Visible = false;
            this.mapGorBut.Click += new System.EventHandler(this.mapGorBut_Click);
            // 
            // hamleLabel
            // 
            this.hamleLabel.AutoSize = true;
            this.hamleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamleLabel.Location = new System.Drawing.Point(856, 132);
            this.hamleLabel.Name = "hamleLabel";
            this.hamleLabel.Size = new System.Drawing.Size(157, 25);
            this.hamleLabel.TabIndex = 18;
            this.hamleLabel.Text = "Hamle Sayısı : ";
            this.hamleLabel.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.PowderBlue;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restartButton.Location = new System.Drawing.Point(893, 22);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(174, 101);
            this.restartButton.TabIndex = 17;
            this.restartButton.Text = "Yeniden Oyna";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Coral;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverLabel.Location = new System.Drawing.Point(198, 253);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(489, 190);
            this.gameOverLabel.TabIndex = 16;
            this.gameOverLabel.Text = " Oyun Bitti\r\nKaybettiniz!";
            this.gameOverLabel.Visible = false;
            // 
            // numUpMayin
            // 
            this.numUpMayin.BackColor = System.Drawing.Color.Linen;
            this.numUpMayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUpMayin.Location = new System.Drawing.Point(437, 304);
            this.numUpMayin.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numUpMayin.Name = "numUpMayin";
            this.numUpMayin.Size = new System.Drawing.Size(117, 60);
            this.numUpMayin.TabIndex = 15;
            // 
            // sayiTeyitLabel
            // 
            this.sayiTeyitLabel.AutoSize = true;
            this.sayiTeyitLabel.BackColor = System.Drawing.Color.Crimson;
            this.sayiTeyitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayiTeyitLabel.Location = new System.Drawing.Point(300, 253);
            this.sayiTeyitLabel.Name = "sayiTeyitLabel";
            this.sayiTeyitLabel.Size = new System.Drawing.Size(398, 29);
            this.sayiTeyitLabel.TabIndex = 14;
            this.sayiTeyitLabel.Text = "Lütfen 1 - 900 arası sayı giriniz!";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Bisque;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartButton.Location = new System.Drawing.Point(410, 379);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(172, 104);
            this.StartButton.TabIndex = 13;
            this.StartButton.Text = "Başla";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // mayinSayisiLabel
            // 
            this.mayinSayisiLabel.AutoSize = true;
            this.mayinSayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mayinSayisiLabel.Location = new System.Drawing.Point(44, 157);
            this.mayinSayisiLabel.Name = "mayinSayisiLabel";
            this.mayinSayisiLabel.Size = new System.Drawing.Size(958, 39);
            this.mayinSayisiLabel.TabIndex = 12;
            this.mayinSayisiLabel.Text = "30 X 30 boyutlu haritada kaç mayın yer almasını istersiniz?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 813);
            this.Controls.Add(this.mayinSayLabel);
            this.Controls.Add(this.standartStart);
            this.Controls.Add(this.mapGorBut);
            this.Controls.Add(this.hamleLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.numUpMayin);
            this.Controls.Add(this.sayiTeyitLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.mayinSayisiLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpMayin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mayinSayLabel;
        private System.Windows.Forms.Button standartStart;
        private System.Windows.Forms.Button mapGorBut;
        private System.Windows.Forms.Label hamleLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.NumericUpDown numUpMayin;
        private System.Windows.Forms.Label sayiTeyitLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label mayinSayisiLabel;
    }
}

