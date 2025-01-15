using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xOx
{
    public partial class Form1 : Form
    {
        int sayac = 0; // Sıra kontrolünü sağlamak için
        
        // 7x7 boyutunda bir 2D Button dizisi oluştur
        Button[,] bloks = new Button[7, 7]; 
        Label haritaSecimLabel = new Label(); // Harita seçimi için metin
        //Label playerSecimLabel = new Label(); // Tek oyuncu - 2 oyuncu seçimi için metin
        Button[] haritalar = new Button[3]; // 3x3 - 5x5 - 7x7 seçimi için
        Button[] playerSecimBut = new Button[2]; // Tek oyuncu - 2 oyuncu seçimi için
        bool programlaMiOynaniyor; // Tek - çift kişilik
        int haritaBoyutu; // Harita seçimine yönelik kontroller için
        bool programSirasi = false; // Programla oynanılan durumda kontrol için
        int kacBlokDolu = 0; // Oyun sıfırlama ve sonsuz döngüyü kırmak için

        Timer bilgisayarHamleTimer = new Timer(); // Bilgisayarın hamlesini gerçekçi kılmak için
        


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            bilgisayarHamleTimer.Interval = 1000; // 1000 ms = 1 saniye
            bilgisayarHamleTimer.Tick += BilgisayarHamleYap;

            for (int i = 0; i < playerSecimBut.Length; i++) // Tek - Çift kişilik seçim ekranı
            {
                playerSecimBut[i] = new Button(); // Buton oluştur
                playerSecimBut[i].Text = (i+1) + " Player"; // Buton metnini ata
                playerSecimBut[i].Font = new Font(playerSecimBut[i].Font.FontFamily, 30); // Metnin font ve boyutu
                playerSecimBut[i].Size = new Size(200, 150); // Label boyutu
                playerSecimBut[i].Location = new Point(130 + 280*i , 200); // Metin konumu
                playerSecimBut[i].Click += new EventHandler(Button_Click); // Etkileşim tutucu
                playerSecimBut[i].BackColor = Color.BurlyWood; // Metin arkası renk
                this.Controls.Add(playerSecimBut[i]); // Metni ekle
            }

                // Harita Seçimi İçin 
            haritaSecimLabel.Location = new Point(150,80); // Metin konumu
            haritaSecimLabel.Text = "Harita boyutunu seçiniz!"; // Metin
            haritaSecimLabel.AutoSize = true; // Büyüklük ayarı
            haritaSecimLabel.ForeColor = Color.Black; // Metin rengi
            haritaSecimLabel.BackColor = Color.Chocolate; // Metin arkası renk
            haritaSecimLabel.Font = new Font(Font.FontFamily, 30); // Metin font ve boyutu
            this.Controls.Add(haritaSecimLabel); // Metni ekle
            haritaSecimLabel.Visible = false; // Metni gizle (player seçim ekranı için)

                // 3x3 - 5x5 - 7x7 harita seçenekleri
            for(int i = 0; i < haritalar.Length; i++) 
            {
                haritalar[i] = new Button(); 
                haritalar[i].Text = (i*2 + 3) + " x " + (i*2 + 3); 
                haritalar[i].Font = new Font(haritalar[i].Font.FontFamily, 30); 
                haritalar[i].Size = new Size(200, 150);
                haritalar[i].Location = new Point(30 + 220*i, 200);
                haritalar[i].Click += new EventHandler(Button_Click);
                haritalar[i].BackColor = Color.BurlyWood;
                this.Controls.Add(haritalar[i]);
                haritalar[i].Visible = false;
            }
            

            for (int i = 0; i < bloks.GetLength(0); i++)
            {
                for (int j = 0; j < bloks.GetLength(1); j++)
                {
                    // Butonu oluşturup özelliklerini ayarlıyoruz
                    bloks[i, j] = new Button();
                    bloks[i, j].Font = new Font(bloks[i, j].Font.FontFamily, 30); // Text ayarı
                    bloks[i, j].Size = new Size(60, 60); // Buton büyüklüğü ayarı
                    bloks[i, j].Location = new Point(29 + 66 * j, 59 + 66 * i); // Konum ayarı
                    bloks[i, j].Text = ""; // Başlangıçta butonun üzerindeki yazıyı boş bırakıyoruz

                    // Tıklama olayını ekliyoruz
                    bloks[i, j].Click += new EventHandler(Button_Click);

                    // Butonu forma ekliyoruz
                    this.Controls.Add(bloks[i, j]);
                    bloks[i, j].Visible = false;
                }
            }
        }

        private void BilgisayarHamleYap(object sender, EventArgs e)
        {
            Random rnd = new Random();
            while (kacBlokDolu < haritaBoyutu * haritaBoyutu)
            {
                int satir = rnd.Next(0, haritaBoyutu);
                int sutun = rnd.Next(0, haritaBoyutu);
                if (bloks[satir, sutun].Text == "")
                {
                    bloks[satir, sutun].Text = "O"; // Bilgisayar hamlesi
                    sayac = 0; // Sıra oyuncuya geçiyor
                    programSirasi = false;
                    kacBlokDolu++; // Dolu blok sayısını artır

                    // Kazanma kontrolü
                    if ((CheckWinThree() && haritaBoyutu == 3) || (CheckWinFour() && haritaBoyutu > 3))
                    {
                        MessageBox.Show("O (bilgisayar) kazandı!");
                        ResetGame();
                    }

                    break; // Döngüden çık
                }
            }

            // Harita tamamen doluysa sıfırla
            if (kacBlokDolu == haritaBoyutu * haritaBoyutu)
            {
                ResetGame();
            }

            // Timer'ı durdur
            bilgisayarHamleTimer.Stop();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Tıklanan butona erişiyoruz
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Text == "" ) // Buton mevcutsa, basılmamışsa
            {
                if (programlaMiOynaniyor && sayac == 0 && kacBlokDolu % 2 == 0) // Sıra X'te ve program sırasını yaptıysa (1 player)
                {
                    clickedButton.Text = "X"; // Tıklanan butonun üzerine "X" yazıyoruz
                    sayac = 1; // Sıra O'da
                    programSirasi = true; // Sıra bilgisayarda
                    kacBlokDolu++; // Dolu blok sayısı arttı
                }
                else if (sayac == 0) // Sıra X'te (2 player)
                {
                    clickedButton.Text = "X"; // Tıklanan butonun üzerine "X" yazıyoruz
                    sayac = 1; // Sıra O'da
                    programSirasi = true; // Sıra bilgisayarda
                    kacBlokDolu++; // Dolu blok sayısı arttı
                }
                else if(!programlaMiOynaniyor) // Sıra O'daysa (2 player)
                {
                    clickedButton.Text = "O"; // Tıklanan butonun üzerine "O" yazıyoruz
                    sayac = 0; // Sıra X'te
                    kacBlokDolu++; // Dolu blok sayısı arttı
                }

                
                if ( (CheckWinThree() && haritaBoyutu == 3) || (CheckWinFour() && haritaBoyutu>3) )
                {
                    string kazanan = clickedButton.Text; // Kazananı belirliyoruz
                    MessageBox.Show(kazanan + " kazandı!");
                    ResetGame();
                }
                else if (programlaMiOynaniyor && programSirasi)
                {
                    bilgisayarHamleTimer.Start(); // Timer'ı başlat

                }

                if (kacBlokDolu == haritaBoyutu * haritaBoyutu)
                    ResetGame();
                
            }

            if (clickedButton == playerSecimBut[0]) // Tek kişilik seçildiyse
            {
                programlaMiOynaniyor = true;
                    // Player seçim ekranını geç
                playerSecimBut[0].Visible = false;
                playerSecimBut[1].Visible = false;
                    // Harita seçim aşamasını göster
                haritaSecimLabel.Visible = true;
                haritalar[0].Visible = true;
                haritalar[1].Visible = true;
                haritalar[2].Visible = true;

            }
            else if (clickedButton == playerSecimBut[1]) // Çift kişilik seçildiyse
            {
                programlaMiOynaniyor = false;
                    // Player seçim ekranını geç
                playerSecimBut[0].Visible = false;
                playerSecimBut[1].Visible = false;
                // Harita seçim aşamasını göster
                haritaSecimLabel.Visible = true;
                haritalar[0].Visible = true;
                haritalar[1].Visible = true;
                haritalar[2].Visible = true;
            }
                

            if(clickedButton == haritalar[0]) // 3x3 harita seçildiyse
            {
                haritaBoyutu = 3;
                // Seçim ekranını kaldır
                haritalar[0].Visible = false;
                haritalar[1].Visible = false;
                haritalar[2].Visible = false;
                haritaSecimLabel.Visible = false;

                for (int i = 0; i < 3; i++) // 3x3 haritayı göster
                {
                    for (int j = 0; j < 3; j++)
                    {
                        bloks[i, j].Visible = true;
                    }
                }
            }else if(clickedButton == haritalar[1]) // 5x5 harita seçildiyse
            {
                haritaBoyutu = 5;
                //Seçim ekranını kaldır
                haritalar[0].Visible = false;
                haritalar[1].Visible = false;
                haritalar[2].Visible = false;
                haritaSecimLabel.Visible = false;

                for (int i = 0; i < 5; i++) // 5x5 haritayı göster
                {
                    for (int j = 0; j < 5; j++)
                    {
                        bloks[i, j].Visible = true;
                    }
                }
            }else if(clickedButton == haritalar[2]) // 7x7 harita seçildiyse
            {
                haritaBoyutu = 7;
                // Seçim ekranını kaldır
                haritalar[0].Visible = false;
                haritalar[1].Visible = false;
                haritalar[2].Visible = false;
                haritaSecimLabel.Visible = false;

                for (int i = 0; i < 7; i++) // 7x7 haritayı göster
                {
                    for (int j = 0; j < 7; j++)
                    {
                        bloks[i, j].Visible = true;
                    }
                }
            }
        }

        private bool CheckWinThree()
        {
            
            // Satır kontrolü
            for(int i = 0; i < 7; i++) // 7 satır için de dönsün
            {
                for(int j = 0; j < 5; j++) // satırların 5. sütunundan sonra dönmesine gerek yok
                {
                        // Yan yana 3 tane aynı var ise
                        if ( bloks[i,j].Text != "" && bloks[i,j].Text == bloks[i,j+1].Text && bloks[i,j].Text == bloks[i,j+2].Text )
                        {
                            
                            return true; // Oyun bitti
                        }
                    
                }
            }

            // Sütun kontrolü
            for (int j = 0; j < 7; j++) // 7 sütun için de dönsün
            {
                for (int i = 0; i < 5; i++) // sutünların 5. satırından sonra dönmesine gerek yok
                {
                    
                        if (bloks[i,j].Text != "" && bloks[i,j].Text == bloks[i + 1,  j].Text && bloks[i, j].Text == bloks[i+2,j].Text)
                        {
                            
                            return true; // Oyun bitti
                        }
                    // 3 tane alt alta aynı var ise
                    
                }
            }

            // Sol üstten sağ alta kontrol
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                        if (bloks[i, j].Text != "" && bloks[i,j].Text == bloks[i+1, j+1].Text 
                            && bloks[i, j].Text == bloks[i+2, j+2].Text) // 3 tane çapraz aynı var ise
                        {
                            return true;
                        }
                    
                   
                }
            }

            // Sağ üstten sol alta kontrol
            for (int i = 2; i < 7; i ++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bloks[i, j].Text != "" && bloks[i, j].Text == bloks[i - 1, j +1].Text 
                        && bloks[i, j].Text == bloks[i - 2, j +2].Text) // 3 tane çapraz aynı var ise
                    {
                        return true;
                    }
                    
                }
            }

            return false;


        }

        private bool CheckWinFour() // 5x5 ve 7x7 harita için 4 tane aynı sembol kontrolü
        {

            // Satır kontrolü
            for (int i = 0; i < 7; i++) // 7 satır için de dönsün
            {
                for (int j = 0; j < 4; j++) // satırların 4. sütunundan sonra dönmesine gerek yok
                {
                    // Yan yana 4 tane aynı var ise
                    if (bloks[i, j].Text != "" && bloks[i, j].Text == bloks[i, j + 1].Text && 
                        bloks[i, j].Text == bloks[i, j + 2].Text && bloks[i, j].Text == bloks[i, j + 3].Text)
                    {

                        return true; // Oyun bitti
                    }

                }
            }

            // Sütun kontrolü
            for (int j = 0; j < 7; j++) // 7 sütun için de dönsün
            {
                for (int i = 0; i < 4; i++) // sutünların 4. satırından sonra dönmesine gerek yok
                {

                    if (bloks[i, j].Text != "" && bloks[i, j].Text == bloks[i + 1, j].Text && 
                        bloks[i, j].Text == bloks[i + 2, j].Text && bloks[i, j].Text == bloks[i + 3, j].Text)
                    {

                        return true; // Oyun bitti
                    }
                    // 4 tane alt alta aynı var ise

                }
            }

            // Sol üstten sağ alta kontrol
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (bloks[i, j].Text != "" && bloks[i, j].Text == bloks[i + 1, j + 1].Text
                        && bloks[i, j].Text == bloks[i + 2, j + 2].Text 
                        && bloks[i, j].Text == bloks[i + 3, j + 3].Text) // 4 tane çapraz aynı var ise
                    {
                        return true;
                    }


                }
            }

            // Sağ üstten sol alta kontrol
            for (int i = 3; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (bloks[i, j].Text != "" && bloks[i, j].Text == bloks[i - 1, j + 1].Text
                        && bloks[i, j].Text == bloks[i - 2, j + 2].Text
                        && bloks[i, j].Text == bloks[i - 3, j + 3].Text) // 4 tane çapraz aynı var ise
                    {
                        return true;
                    }

                }
            }

            return false;


        }

        private void ResetGame()
        {
            // Player seçim ekranına dön
            playerSecimBut[0].Visible = true;
            playerSecimBut[1].Visible = true;

            // Oyun tahtasını sıfırlıyoruz
            for (int i = 0; i < bloks.GetLength(0); i++)
            {
                for (int j = 0; j < bloks.GetLength(1); j++)
                {
                    bloks[i, j].Text = ""; // Bütün sembolleri sıfırla
                    bloks[i, j].Visible = false;
                }
            }
            sayac = 0; // Sıra sayacını sıfırla
            kacBlokDolu = 0; // Haritayı sıfırla
            programSirasi = false; // Sıra kullanıcıda
        }

        


    }
}
