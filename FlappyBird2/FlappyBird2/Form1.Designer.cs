namespace FlappyBird2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skorLabel = new System.Windows.Forms.Label();
            this.topSkorLabel = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeTopRR = new System.Windows.Forms.PictureBox();
            this.pipeBottomRR = new System.Windows.Forms.PictureBox();
            this.pipeTopR = new System.Windows.Forms.PictureBox();
            this.pipeBottomR = new System.Windows.Forms.PictureBox();
            this.pipeTopL = new System.Windows.Forms.PictureBox();
            this.pipeBottomL = new System.Windows.Forms.PictureBox();
            this.pipeTopLL = new System.Windows.Forms.PictureBox();
            this.pipeBottomLL = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // skorLabel
            // 
            this.skorLabel.AutoSize = true;
            this.skorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLabel.Location = new System.Drawing.Point(0, 0);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(121, 39);
            this.skorLabel.TabIndex = 0;
            this.skorLabel.Text = "Skor : ";
            // 
            // topSkorLabel
            // 
            this.topSkorLabel.AutoSize = true;
            this.topSkorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topSkorLabel.Location = new System.Drawing.Point(12, 523);
            this.topSkorLabel.Name = "topSkorLabel";
            this.topSkorLabel.Size = new System.Drawing.Size(322, 39);
            this.topSkorLabel.TabIndex = 1;
            this.topSkorLabel.Text = "En Yüksek Skor : 0";
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBird2.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(15, 200);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(72, 54);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 11;
            this.bird.TabStop = false;
            // 
            // pipeTopRR
            // 
            this.pipeTopRR.Image = global::FlappyBird2.Properties.Resources.pipedown;
            this.pipeTopRR.Location = new System.Drawing.Point(1866, 28);
            this.pipeTopRR.Name = "pipeTopRR";
            this.pipeTopRR.Size = new System.Drawing.Size(100, 262);
            this.pipeTopRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTopRR.TabIndex = 10;
            this.pipeTopRR.TabStop = false;
            // 
            // pipeBottomRR
            // 
            this.pipeBottomRR.Image = global::FlappyBird2.Properties.Resources.pipe;
            this.pipeBottomRR.Location = new System.Drawing.Point(1866, 459);
            this.pipeBottomRR.Name = "pipeBottomRR";
            this.pipeBottomRR.Size = new System.Drawing.Size(100, 262);
            this.pipeBottomRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottomRR.TabIndex = 9;
            this.pipeBottomRR.TabStop = false;
            // 
            // pipeTopR
            // 
            this.pipeTopR.Image = global::FlappyBird2.Properties.Resources.pipedown;
            this.pipeTopR.Location = new System.Drawing.Point(1529, -48);
            this.pipeTopR.Name = "pipeTopR";
            this.pipeTopR.Size = new System.Drawing.Size(100, 262);
            this.pipeTopR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTopR.TabIndex = 8;
            this.pipeTopR.TabStop = false;
            // 
            // pipeBottomR
            // 
            this.pipeBottomR.Image = global::FlappyBird2.Properties.Resources.pipe;
            this.pipeBottomR.Location = new System.Drawing.Point(1529, 383);
            this.pipeBottomR.Name = "pipeBottomR";
            this.pipeBottomR.Size = new System.Drawing.Size(100, 262);
            this.pipeBottomR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottomR.TabIndex = 7;
            this.pipeBottomR.TabStop = false;
            // 
            // pipeTopL
            // 
            this.pipeTopL.Image = global::FlappyBird2.Properties.Resources.pipedown;
            this.pipeTopL.Location = new System.Drawing.Point(1192, -41);
            this.pipeTopL.Name = "pipeTopL";
            this.pipeTopL.Size = new System.Drawing.Size(100, 262);
            this.pipeTopL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTopL.TabIndex = 6;
            this.pipeTopL.TabStop = false;
            // 
            // pipeBottomL
            // 
            this.pipeBottomL.Image = global::FlappyBird2.Properties.Resources.pipe;
            this.pipeBottomL.Location = new System.Drawing.Point(1192, 390);
            this.pipeBottomL.Name = "pipeBottomL";
            this.pipeBottomL.Size = new System.Drawing.Size(100, 262);
            this.pipeBottomL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottomL.TabIndex = 5;
            this.pipeBottomL.TabStop = false;
            // 
            // pipeTopLL
            // 
            this.pipeTopLL.Image = global::FlappyBird2.Properties.Resources.pipedown;
            this.pipeTopLL.Location = new System.Drawing.Point(855, -117);
            this.pipeTopLL.Name = "pipeTopLL";
            this.pipeTopLL.Size = new System.Drawing.Size(100, 262);
            this.pipeTopLL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTopLL.TabIndex = 4;
            this.pipeTopLL.TabStop = false;
            // 
            // pipeBottomLL
            // 
            this.pipeBottomLL.Image = global::FlappyBird2.Properties.Resources.pipe;
            this.pipeBottomLL.Location = new System.Drawing.Point(855, 314);
            this.pipeBottomLL.Name = "pipeBottomLL";
            this.pipeBottomLL.Size = new System.Drawing.Size(100, 262);
            this.pipeBottomLL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottomLL.TabIndex = 3;
            this.pipeBottomLL.TabStop = false;
            // 
            // floor
            // 
            this.floor.Image = global::FlappyBird2.Properties.Resources.ground;
            this.floor.Location = new System.Drawing.Point(-2, 470);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(895, 103);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 2;
            this.floor.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverLabel.Location = new System.Drawing.Point(180, 127);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(574, 113);
            this.gameOverLabel.TabIndex = 12;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(351, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 108);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yeniden Oyna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 571);
            this.Controls.Add(this.skorLabel);
            this.Controls.Add(this.topSkorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeTopRR);
            this.Controls.Add(this.pipeTopR);
            this.Controls.Add(this.pipeTopL);
            this.Controls.Add(this.pipeTopLL);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.pipeBottomLL);
            this.Controls.Add(this.pipeBottomRR);
            this.Controls.Add(this.pipeBottomR);
            this.Controls.Add(this.pipeBottomL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTopLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottomLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Label topSkorLabel;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox pipeBottomLL;
        private System.Windows.Forms.PictureBox pipeTopLL;
        private System.Windows.Forms.PictureBox pipeTopL;
        private System.Windows.Forms.PictureBox pipeBottomL;
        private System.Windows.Forms.PictureBox pipeTopRR;
        private System.Windows.Forms.PictureBox pipeBottomRR;
        private System.Windows.Forms.PictureBox pipeTopR;
        private System.Windows.Forms.PictureBox pipeBottomR;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button button1;
    }
}

