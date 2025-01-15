namespace HangMan
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
            this.harfPaneli = new System.Windows.Forms.Panel();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.a_buton = new System.Windows.Forms.Button();
            this.gorselPaneli = new System.Windows.Forms.Panel();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.gorsel = new System.Windows.Forms.PictureBox();
            this.Kelime = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.harfPaneli.SuspendLayout();
            this.gorselPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // harfPaneli
            // 
            this.harfPaneli.BackColor = System.Drawing.SystemColors.ControlLight;
            this.harfPaneli.Controls.Add(this.button26);
            this.harfPaneli.Controls.Add(this.button27);
            this.harfPaneli.Controls.Add(this.button28);
            this.harfPaneli.Controls.Add(this.button29);
            this.harfPaneli.Controls.Add(this.button20);
            this.harfPaneli.Controls.Add(this.button21);
            this.harfPaneli.Controls.Add(this.button22);
            this.harfPaneli.Controls.Add(this.button23);
            this.harfPaneli.Controls.Add(this.button24);
            this.harfPaneli.Controls.Add(this.button15);
            this.harfPaneli.Controls.Add(this.button16);
            this.harfPaneli.Controls.Add(this.button17);
            this.harfPaneli.Controls.Add(this.button18);
            this.harfPaneli.Controls.Add(this.button19);
            this.harfPaneli.Controls.Add(this.button10);
            this.harfPaneli.Controls.Add(this.button11);
            this.harfPaneli.Controls.Add(this.button12);
            this.harfPaneli.Controls.Add(this.button13);
            this.harfPaneli.Controls.Add(this.button14);
            this.harfPaneli.Controls.Add(this.button5);
            this.harfPaneli.Controls.Add(this.button6);
            this.harfPaneli.Controls.Add(this.button7);
            this.harfPaneli.Controls.Add(this.button8);
            this.harfPaneli.Controls.Add(this.button9);
            this.harfPaneli.Controls.Add(this.button4);
            this.harfPaneli.Controls.Add(this.button3);
            this.harfPaneli.Controls.Add(this.button2);
            this.harfPaneli.Controls.Add(this.button1);
            this.harfPaneli.Controls.Add(this.a_buton);
            this.harfPaneli.Location = new System.Drawing.Point(23, 179);
            this.harfPaneli.Name = "harfPaneli";
            this.harfPaneli.Size = new System.Drawing.Size(446, 513);
            this.harfPaneli.TabIndex = 0;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.Location = new System.Drawing.Point(262, 422);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 75);
            this.button26.TabIndex = 28;
            this.button26.Text = "Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.Location = new System.Drawing.Point(100, 422);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 75);
            this.button27.TabIndex = 27;
            this.button27.Text = "V";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.Location = new System.Drawing.Point(181, 422);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 75);
            this.button28.TabIndex = 26;
            this.button28.Text = "Y";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.Location = new System.Drawing.Point(19, 422);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 75);
            this.button29.TabIndex = 25;
            this.button29.Text = "Ü";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(343, 341);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 75);
            this.button20.TabIndex = 24;
            this.button20.Text = "U";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(262, 341);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 75);
            this.button21.TabIndex = 23;
            this.button21.Text = "T";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(100, 341);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 75);
            this.button22.TabIndex = 22;
            this.button22.Text = "S";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(181, 341);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 75);
            this.button23.TabIndex = 21;
            this.button23.Text = "Ş";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.Location = new System.Drawing.Point(19, 341);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 75);
            this.button24.TabIndex = 20;
            this.button24.Text = "R";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(343, 260);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 75);
            this.button15.TabIndex = 19;
            this.button15.Text = "P";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(262, 260);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 75);
            this.button16.TabIndex = 18;
            this.button16.Text = "Ö";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(100, 260);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 75);
            this.button17.TabIndex = 17;
            this.button17.Text = "N";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(181, 260);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 75);
            this.button18.TabIndex = 16;
            this.button18.Text = "O";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(19, 260);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 75);
            this.button19.TabIndex = 15;
            this.button19.Text = "M";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(343, 179);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 14;
            this.button10.Text = "L";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(262, 179);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 13;
            this.button11.Text = "K";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(100, 179);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 75);
            this.button12.TabIndex = 12;
            this.button12.Text = "İ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(181, 179);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 75);
            this.button13.TabIndex = 11;
            this.button13.Text = "J";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(19, 179);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 75);
            this.button14.TabIndex = 10;
            this.button14.Text = "I";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(343, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 9;
            this.button5.Text = "H";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(262, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ğ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(100, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "F";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(181, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 6;
            this.button8.Text = "G";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(19, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 5;
            this.button9.Text = "E";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(343, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(262, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(100, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(181, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // a_buton
            // 
            this.a_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a_buton.Location = new System.Drawing.Point(19, 17);
            this.a_buton.Name = "a_buton";
            this.a_buton.Size = new System.Drawing.Size(75, 75);
            this.a_buton.TabIndex = 0;
            this.a_buton.Text = "A";
            this.a_buton.UseVisualStyleBackColor = true;
            this.a_buton.Click += new System.EventHandler(this.harfButonu_Click);
            // 
            // gorselPaneli
            // 
            this.gorselPaneli.Controls.Add(this.label2);
            this.gorselPaneli.Controls.Add(this.lblKalanHak);
            this.gorselPaneli.Controls.Add(this.gorsel);
            this.gorselPaneli.Location = new System.Drawing.Point(721, 160);
            this.gorselPaneli.Name = "gorselPaneli";
            this.gorselPaneli.Size = new System.Drawing.Size(484, 454);
            this.gorselPaneli.TabIndex = 1;
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHak.Location = new System.Drawing.Point(241, 0);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(240, 39);
            this.lblKalanHak.TabIndex = 4;
            this.lblKalanHak.Text = "Kalan Hak : 10";
            // 
            // gorsel
            // 
            this.gorsel.Image = global::HangMan.Properties.Resources._0;
            this.gorsel.Location = new System.Drawing.Point(0, 0);
            this.gorsel.Name = "gorsel";
            this.gorsel.Size = new System.Drawing.Size(484, 454);
            this.gorsel.TabIndex = 0;
            this.gorsel.TabStop = false;
            // 
            // Kelime
            // 
            this.Kelime.AutoSize = true;
            this.Kelime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kelime.Location = new System.Drawing.Point(29, 55);
            this.Kelime.Name = "Kelime";
            this.Kelime.Size = new System.Drawing.Size(812, 76);
            this.Kelime.TabIndex = 2;
            this.Kelime.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(568, 160);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(48, 17);
            this.debug.TabIndex = 3;
            this.debug.Text = "debug";
            this.debug.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Huzeyfe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.Kelime);
            this.Controls.Add(this.gorselPaneli);
            this.Controls.Add(this.harfPaneli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.harfPaneli.ResumeLayout(false);
            this.gorselPaneli.ResumeLayout(false);
            this.gorselPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel harfPaneli;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button a_buton;
        private System.Windows.Forms.Panel gorselPaneli;
        private System.Windows.Forms.PictureBox gorsel;
        private System.Windows.Forms.Label Kelime;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

