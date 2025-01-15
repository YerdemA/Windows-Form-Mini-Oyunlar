using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayin_Tarlasi
{
    public partial class Form1 : Form
    {
        /*
          Mayınlar text'te çift boşlukla temsil edildi.
          İlk hamlede mayın bulunmaması
         */


        int toplamMayinSayisi = 0;
        int guncelMayinSayisi = 0;
        int hamleSayisi = 0;
        int konulanBayrak = 0;

        Button[,] kareler = new Button[30, 30]; // Harita kareleri


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numUpMayin.Minimum = 0; // Kullanıcıdan alınacak minimum sayı
            numUpMayin.Maximum = 900; // Kullanıcıdan alınacak maximum sayı

            for (int i = 0; i < kareler.GetLength(0); i++)
            {
                for (int j = 0; j < kareler.GetLength(1); j++)
                {
                    // Butonu oluşturup özelliklerini ayarlıyoruz
                    kareler[i, j] = new Button();
                    kareler[i, j].BackColor = Color.Moccasin; // Kare renkleri
                    kareler[i, j].Font = new Font(kareler[i, j].Font.FontFamily, 7); // Text ayarı
                    kareler[i, j].Size = new Size(20, 20); // Kare büyüklüğü ayarı
                    kareler[i, j].Location = new Point(25 + 20 * j, 15 + 20 * i); // Konum ayarı
                    kareler[i, j].Text = ""; // Başlangıçta karenin üzerindeki yazıyı boş bırakıyoruz
                    kareler[i, j].Visible = false; // Başta harita gözükmüyor

                    // Butonun koordinatlarını Tag özelliğine kaydediyoruz
                    kareler[i, j].Tag = new Point(i, j);

                    // Tıklama olayını ekliyoruz
                    kareler[i, j].Click += new EventHandler(Button_Click);
                    kareler[i, j].MouseDown += new MouseEventHandler(Button_MouseDown);

                    // Butonu forma ekliyoruz
                    this.Controls.Add(kareler[i, j]);

                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null && hamleSayisi == 0)
            {
                clickedButton.Text = " ";
                MayinYerlestir(kareler, toplamMayinSayisi);
                // Butonun koordinatlarını Tag'den al
                Point koordinat = (Point)clickedButton.Tag;
                int x = koordinat.X; // Satır indeksi
                int y = koordinat.Y; // Sütun indeksi

                hamleSayisi++;
                hamleLabel.Text = $"Hamle Sayısı : {hamleSayisi}";

                EtraftakiMayinKontrolu(clickedButton, x, y);
                kareler[x, y].BackColor = Color.OldLace;

                if (KazanmaKontrolu(kareler, toplamMayinSayisi))
                {
                    MessageBox.Show("Tebrikler kazandınız!", "Bütün mayınlar bulundu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hamleLabel.Visible = false;
                    mayinSayLabel.Visible = false;
                    Restart();
                }
            }

            if (clickedButton != null && clickedButton.Text == "") // Tıklanan buton mevcutsa ve mayın yoksa
            {
                // Butonun koordinatlarını Tag'den al
                Point koordinat = (Point)clickedButton.Tag;
                int x = koordinat.X; // Satır indeksi
                int y = koordinat.Y; // Sütun indeksi

                hamleSayisi++;
                hamleLabel.Text = $"Hamle Sayısı : {hamleSayisi}";

                EtraftakiMayinKontrolu(clickedButton, x, y);
                if (kareler[x, y].Text == "")
                    kareler[x, y].BackColor = Color.OldLace;

                if (KazanmaKontrolu(kareler, toplamMayinSayisi))
                {
                    MessageBox.Show("Tebrikler kazandınız!", "Bütün mayınlar bulundu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hamleLabel.Visible = false;
                    mayinSayLabel.Visible = false;
                    Restart();
                }

            }
            else if (clickedButton != null && clickedButton.Text == "  ")
            {
                hamleSayisi++;
                hamleLabel.Text = $"Hamle Sayısı : {hamleSayisi}";
                MayinlariGoster();
                OyunBittiKayip();
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Sağ tık kontrolü
                if (e.Button == MouseButtons.Right)
                {
                    // Buton zaten işaretli ise işareti kaldır
                    if (clickedButton.Image != null) // İşaret sembolü
                    {
                        clickedButton.Image = null;
                        konulanBayrak--;
                        guncelMayinSayisi++;
                        mayinSayLabel.Text = $"Mayın Sayısı : {guncelMayinSayisi}";
                    }
                    else if (clickedButton.BackColor == Color.Moccasin && konulanBayrak < toplamMayinSayisi) // İşaretli değilse işaretle
                    {
                        konulanBayrak++;
                        guncelMayinSayisi--;
                        mayinSayLabel.Text = $"Mayın Sayısı : {guncelMayinSayisi}";
                        clickedButton.ForeColor = Color.Transparent;
                        clickedButton.Image = Properties.Resources.flag2; // İşaretli karelerde bayrak göster
                        clickedButton.BackgroundImageLayout = ImageLayout.Stretch; // Görseli tam sığdır

                        if (KazanmaKontrolu(kareler, toplamMayinSayisi))
                        {
                            MessageBox.Show("Bütün mayınlar bulundu!", "Kazandınız!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hamleLabel.Visible = false;
                            mayinSayLabel.Visible = false;
                            Restart();
                        }
                    }
                }
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            toplamMayinSayisi = (int)numUpMayin.Value;
            guncelMayinSayisi = toplamMayinSayisi;
            mayinSayLabel.Text = $"Mayın Sayısı : {toplamMayinSayisi}";

            if (toplamMayinSayisi >= 0 && toplamMayinSayisi <= 900) // Girilen mayın sayısı geçerliyse
            {
                // Mayın sayısı giriş aşamasını gizle
                mayinSayisiLabel.Visible = false;
                sayiTeyitLabel.Visible = false;
                numUpMayin.Visible = false;
                StartButton.Visible = false;
                standartStart.Visible = false;

                //MayinYerlestir(kareler, mayinSayisi); // Mayınları rastgele yerleştir

                // Haritayı göster
                foreach (Button kare in kareler)
                {
                    kare.Visible = true;
                    kare.Enabled = true;
                }
                restartButton.Visible = true;
                restartButton.Location = new Point(650, 12);
                hamleLabel.Visible = true;
                mayinSayLabel.Visible = true;
            }
            else
            { // Girilen sayı 0-900 aralıpı dışındaysa hata kutusu göster.
                MessageBox.Show("Lütfen 1 ile 900 arasında bir sayı girin!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void MayinYerlestir(Button[,] harita, int mayinSayisi)
        {
            Random rnd = new Random();
            int yerlestirilenMayin = 0;

            while (yerlestirilenMayin < mayinSayisi)
            {        // Rastgele kare seçimi
                int satir = rnd.Next(0, 30);
                int sutun = rnd.Next(0, 30);

                if (harita[satir, sutun].Text == "") // Eğer seçilen kare boş ise
                {
                    //harita[satir, sutun].ForeColor = Color.Moccasin; // Mayın işareti gözükmesin diye kareyle aynı renk olmalı
                    harita[satir, sutun].Text = "  "; // Mayın temsili için çift boşlukla değiştir
                    yerlestirilenMayin++;
                }
            }
        }

        private void bosKareleriAc(int x, int y)
        {
            if (x + 1 < kareler.GetLength(0)) // Aşağı doğru kontrol
            {
                if (kareler[x + 1, y].Text == "" && EtraftakiMayinSayisi(x + 1, y) == 0)
                {

                    kareler[x + 1, y].BackColor = Color.OldLace;
                    kareler[x + 1, y].Text = " ";
                    bosKareleriAc(x + 1, y);
                }
                else if (kareler[x + 1, y].Text == "" && EtraftakiMayinSayisi(x + 1, y) != 0)
                {
                    kareler[x + 1, y].BackColor = Color.OldLace;
                    kareler[x + 1, y].Text = $"{EtraftakiMayinSayisi(x + 1, y)}";

                    if (y + 1 < kareler.GetLength(1)) // Bir sağ kontrolü
                    {
                        if (kareler[x + 1, y + 1].Text == "" && EtraftakiMayinSayisi(x + 1, y + 1) != 0)
                        {
                            kareler[x + 1, y + 1].BackColor = Color.OldLace;
                            kareler[x + 1, y + 1].Text = $"{EtraftakiMayinSayisi(x + 1, y + 1)}";
                        }
                    }
                    if (y - 1 >= 0) // Bir sol kontrolü
                    {
                        if (kareler[x + 1, y - 1].Text == "" && EtraftakiMayinSayisi(x + 1, y - 1) != 0)
                        {
                            kareler[x + 1, y - 1].BackColor = Color.OldLace;
                            kareler[x + 1, y - 1].Text = $"{EtraftakiMayinSayisi(x + 1, y - 1)}";
                        }
                    }
                }
            }

            if (x - 1 >= 0) // Yukarı doğru kontrol
            {
                if (kareler[x - 1, y].Text == "" && EtraftakiMayinSayisi(x - 1, y) == 0)
                {
                    kareler[x - 1, y].BackColor = Color.OldLace;
                    kareler[x - 1, y].Text = " ";
                    bosKareleriAc(x - 1, y);
                }
                else if (kareler[x - 1, y].Text == "" && EtraftakiMayinSayisi(x - 1, y) != 0)
                {
                    kareler[x - 1, y].BackColor = Color.OldLace;
                    kareler[x - 1, y].Text = $"{EtraftakiMayinSayisi(x - 1, y)}";

                    if (y + 1 < kareler.GetLength(1)) // Bir sağ kontrolü
                    {
                        if (kareler[x - 1, y + 1].Text == "" && EtraftakiMayinSayisi(x - 1, y + 1) != 0)
                        {
                            kareler[x - 1, y + 1].BackColor = Color.OldLace;
                            kareler[x - 1, y + 1].Text = $"{EtraftakiMayinSayisi(x - 1, y + 1)}";
                        }
                    }
                    if (y - 1 >= 0) // Bir sol kontrolü
                    {
                        if (kareler[x - 1, y - 1].Text == "" && EtraftakiMayinSayisi(x - 1, y - 1) != 0)
                        {
                            kareler[x - 1, y - 1].BackColor = Color.OldLace;
                            kareler[x - 1, y - 1].Text = $"{EtraftakiMayinSayisi(x - 1, y - 1)}";
                        }
                    }
                }
            }

            if (y + 1 < kareler.GetLength(0)) // Sağa doğru kontrol
            {
                if (kareler[x, y + 1].Text == "" && EtraftakiMayinSayisi(x, y + 1) == 0)
                {
                    kareler[x, y + 1].BackColor = Color.OldLace;
                    kareler[x, y + 1].Text = " ";
                    bosKareleriAc(x, y + 1);
                }
                else if (kareler[x, y + 1].Text == "" && EtraftakiMayinSayisi(x, y + 1) != 0)
                {
                    kareler[x, y + 1].BackColor = Color.OldLace;
                    kareler[x, y + 1].Text = $"{EtraftakiMayinSayisi(x, y + 1)}";

                    if (x + 1 < kareler.GetLength(0)) // Bir alt kontrolü
                    {
                        if (kareler[x + 1, y + 1].Text == "" && EtraftakiMayinSayisi(x + 1, y + 1) != 0)
                        {
                            kareler[x + 1, y + 1].BackColor = Color.OldLace;
                            kareler[x + 1, y + 1].Text = $"{EtraftakiMayinSayisi(x + 1, y + 1)}";
                        }
                    }
                    if (x - 1 >= 0) // Bir üst kontrolü
                    {
                        if (kareler[x - 1, y + 1].Text == "" && EtraftakiMayinSayisi(x - 1, y + 1) != 0)
                        {
                            kareler[x - 1, y + 1].BackColor = Color.OldLace;
                            kareler[x - 1, y + 1].Text = $"{EtraftakiMayinSayisi(x - 1, y + 1)}";
                        }
                    }
                }
            }

            if (y - 1 >= 0) // Sola doğru kontrol
            {
                if (kareler[x, y - 1].Text == "" && EtraftakiMayinSayisi(x, y - 1) == 0)
                {
                    kareler[x, y - 1].BackColor = Color.OldLace;
                    kareler[x, y - 1].Text = " ";
                    bosKareleriAc(x, y - 1);
                }
                else if (kareler[x, y - 1].Text == "" && EtraftakiMayinSayisi(x, y - 1) != 0)
                {
                    kareler[x, y - 1].BackColor = Color.OldLace;
                    kareler[x, y - 1].Text = $"{EtraftakiMayinSayisi(x, y - 1)}";

                    if (x + 1 < kareler.GetLength(0)) // Bir alt kontrolü
                    {
                        if (kareler[x + 1, y - 1].Text == "" && EtraftakiMayinSayisi(x + 1, y - 1) != 0)
                        {
                            kareler[x + 1, y - 1].BackColor = Color.OldLace;
                            kareler[x + 1, y - 1].Text = $"{EtraftakiMayinSayisi(x + 1, y - 1)}";
                        }
                    }
                    if (x - 1 >= 0) // Bir üst kontrolü
                    {
                        if (kareler[x - 1, y - 1].Text == "" && EtraftakiMayinSayisi(x - 1, y - 1) != 0)
                        {
                            kareler[x - 1, y - 1].BackColor = Color.OldLace;
                            kareler[x - 1, y - 1].Text = $"{EtraftakiMayinSayisi(x - 1, y - 1)}";
                        }
                    }
                }
            }
        }

        private void EtraftakiMayinKontrolu(Button tiklananButon, int x, int y)
        {
            int etraftakiMayinSayisi = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    // Harita sınırlarının dışına çıkmayı engelle
                    if (i >= 0 && i < kareler.GetLength(0) && j >= 0 && j < kareler.GetLength(1))
                    {
                        if (kareler[i, j].Text == "  ")
                        {
                            etraftakiMayinSayisi++;
                        }
                    }
                }
            }
            if (etraftakiMayinSayisi == 0)
            {
                bosKareleriAc(x, y);
            }
            else
            {
                kareler[x, y].BackColor = Color.OldLace; // Karenin açıldığını göstermek için rengi değiştir
                tiklananButon.Text = $"{etraftakiMayinSayisi}"; // Kareye etrafındaki mayın sayısını yaz
            }
        }

        private int EtraftakiMayinSayisi(int x, int y) // Boş karelerin açılmasında kontrol sağlamak için
        {
            int etraftakiMayinSayisi = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    // Harita sınırlarının dışına çıkmayı engelle
                    if (i >= 0 && i < kareler.GetLength(0) && j >= 0 && j < kareler.GetLength(1))
                    {
                        if (kareler[i, j].Text == "  ")
                        {
                            etraftakiMayinSayisi++;
                        }
                    }
                }
            }
            return etraftakiMayinSayisi;

        }

        private void MayinlariGoster()
        {
            foreach (Button kare in kareler)
            {
                if (kare.Text == "  ") // Eğer kare bir mayın içeriyorsa
                {
                    // Mayın görselini ekle
                    kare.Image = Properties.Resources.mine41; // Mayın karelerinde bomba görseli göster
                    kare.BackgroundImageLayout = ImageLayout.Stretch; // Görseli tam sığdır
                }
            }
        }

        private void OyunBittiKayip()
        {
            MayinlariGoster();
            gameOverLabel.Text = $"Oyun Bitti\nKaybettiniz!\nHamle Sayısı : {hamleSayisi}";
            gameOverLabel.Visible = true;
            hamleLabel.Visible = false;
            mayinSayLabel.Visible = false;
            mapGorBut.Visible = true;

            foreach (Button kare in kareler)
            {
                kare.Enabled = false;
            }
        }

        private bool KazanmaKontrolu(Button[,] harita, int mayinSayisi)
        {
            int bayrakSayisi = 0;
            int acilanKareSayisi = 0;
            foreach (Button kare in harita)
            {
                if (kare.BackColor == Color.OldLace)
                    acilanKareSayisi++;
                if (kare.Image != null && kare.Text == "  ")
                    bayrakSayisi++;
            }
            if (acilanKareSayisi + bayrakSayisi == 900)
                return true;
            else
                return false;
        }

        private void Restart()
        {
            mapGorBut.Visible = false;
            //Game Over sayfasını gizle
            restartButton.Visible = false;
            restartButton.Location = new Point(896, 12);
            gameOverLabel.Visible = false;

            //Haritayı gizle
            foreach (Button kare in kareler)
            {
                kare.Visible = false;
                // Haritayı sıfırla
                kare.Text = "";
                kare.BackColor = Color.Moccasin;
                kare.ForeColor = Color.Black;
                kare.Image = null;
            }


            hamleSayisi = 0; // Hamle sayısını sıfırla
            konulanBayrak = 0; // Konulan bayrağı sıfırla
            hamleLabel.Text = $"Hamle Sayısı : {hamleSayisi}";

            // Mayın sayısı giriş aşamasını göster
            mayinSayisiLabel.Visible = true;
            sayiTeyitLabel.Visible = true;
            numUpMayin.Visible = true;
            StartButton.Visible = true;
            standartStart.Visible = true;

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            hamleLabel.Visible = false;
            mayinSayLabel.Visible = false;
            Restart();
        }

        private void mapGorBut_Click(object sender, EventArgs e)
        {
            foreach (Button kare in kareler)
            {
                if (kare.Text != "  ")
                    kare.Image = null;
                else if (kare.Image != null && kare.Text == "  ")
                {
                    kare.Image = Properties.Resources.mine41;
                    kare.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            gameOverLabel.Visible = false;
        }

        private void standartStart_Click(object sender, EventArgs e)
        {
            toplamMayinSayisi = 150;
            guncelMayinSayisi = toplamMayinSayisi;
            mayinSayLabel.Text = $"Mayın Sayısı : {toplamMayinSayisi}";


            // Mayın sayısı giriş aşamasını gizle
            mayinSayisiLabel.Visible = false;
            sayiTeyitLabel.Visible = false;
            numUpMayin.Visible = false;
            StartButton.Visible = false;
            standartStart.Visible = false;

            //MayinYerlestir(kareler, mayinSayisi); // Mayınları rastgele yerleştir

            // Haritayı göster
            foreach (Button kare in kareler)
            {
                kare.Visible = true;
                kare.Enabled = true;
            }
            restartButton.Visible = true;
            restartButton.Location = new Point(650, 12);
            hamleLabel.Visible = true;
            mayinSayLabel.Visible = true;
        }
    }
}
