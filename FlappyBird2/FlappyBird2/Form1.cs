using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird2
{
    public partial class Form1 : Form
    {
        bool isGameActive = true;
        int skor = 0;
        int topSkor = 0;
        int gravity = 4; // Yerçekimi
        int jumpForce = 50; // Sıçrama gücü
        int pipeSpeed = 6; // Boruların hızı
        int pipeGap = 384; // Üst - Alt boru arası mesafe
        int pipeSpacing = 382; // Art arda borular arası mesafe
        Random rnd = new Random();

        // Skor arttırma kontrolü
        bool pipePassedLL = false;
        bool pipePassedL = false;
        bool pipePassedR = false;
        bool pipePassedRR = false;

        bool isJumping = false; // Sıçrama kontrolü
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gameTimerEvent()
        {
            bird.Top += gravity;

            // Dört boru setini hareket ettir
            MovePipe(pipeTopLL, pipeBottomLL, ref pipePassedLL);
            MovePipe(pipeTopL, pipeBottomL, ref pipePassedL);
            MovePipe(pipeTopR, pipeBottomR, ref pipePassedR);
            MovePipe(pipeTopRR, pipeBottomRR, ref pipePassedRR);

            // Kuşun borulara çarpıp çarpmadığını kontrol et
            if (bird.Bounds.IntersectsWith(pipeTopLL.Bounds) || bird.Bounds.IntersectsWith(pipeBottomLL.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTopL.Bounds) || bird.Bounds.IntersectsWith(pipeBottomL.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTopR.Bounds) || bird.Bounds.IntersectsWith(pipeBottomR.Bounds) ||
                bird.Bounds.IntersectsWith(pipeTopRR.Bounds) || bird.Bounds.IntersectsWith(pipeBottomRR.Bounds))
            {
                endGame(); // Eğer çarpışma olduysa oyunu bitir
            }

            if (bird.Top < 0 || bird.Top >= floor.Top - 50) // Kuş düştüğünde veya kafasını yukarı çarptığında
            {
                endGame(); // Oyuncu yanar
            }

            skorLabel.Text = "Skor : " + skor;
        }

        private void MovePipe(PictureBox topPipe, PictureBox bottomPipe, ref bool pipePassed)
        {
            topPipe.Left -= pipeSpeed;
            bottomPipe.Left -= pipeSpeed;

            if(topPipe.Left < bird.Left && !pipePassed) // Kuş boruyu geçtiğinde
            {
                skor++; // Skor arttır
                pipePassed = true; // Boru geçildi, skor eklendi
            }

            if(skor >= topSkor) // En yüksek skor güncelle
            {
                topSkor = skor;
                topSkorLabel.Text = "En Yüksek Skor : " + topSkor;
            }

            if(topPipe.Left < -topPipe.Width) // Borular ekranın solundan çıktığında
            {
                // Boruları ekranın sağına yerleştir
                topPipe.Left = ClientSize.Width + pipeSpacing;
                bottomPipe.Left = ClientSize.Width + pipeSpacing;

                // Boruların dikey konumunu rastgele ayarla
                topPipe.Top = rnd.Next(-150, -70);
                bottomPipe.Top = topPipe.Top + pipeGap;

                pipePassed = false; // Yeni boru gibi işaretle
            }

        }

        private void endGame() // Oyuncu yandığında
        {
            skorLabel.Visible = false;
            gameOverLabel.Visible = true; // Game Over'ı ve Skor'u göster
            gameOverLabel.Text = "Game Over\nSkor : " + skor;

            bird.Top = 200;
            timer1.Stop(); // Yerçekimi vesaire dursun
            
            button1.Visible = true; // Yeniden Oyna butonunu göster
            button1.Enabled = true; // Yeniden Oyna butonunu aktive et

            isGameActive = false; // Oyun oynanıyor durumda değil
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTimerEvent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // Tuşa basıldığında
        {
            if(e.KeyCode == Keys.Space && !isJumping && isGameActive)
            {
                bird.Top -= jumpForce; // Kuş sıçrar
                isJumping = true; // Sıçrama gerçekleşti
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) // Tuş bırakıldığında
        {
            if(e.KeyCode == Keys.Space && isGameActive)
            {
                isJumping = false; // Kuş sıçramaya hazır
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            button1.Visible = false; // Yeniden Oyna butonunu gizle
            button1.Enabled = false; // Yeniden Oyna butonunun devre dışı bırak

            gameOverLabel.Visible = false; // Game Over yazısını gizle
            skor = 0; // Skor'u sıfırla
            skorLabel.Visible = true; // Skor sayacını görünür kıl
         
            bird.Top = 200; // Kuşu başlangıç konumuna getir
         
            //Boruları başlangıç konumlarına getir
            pipeTopLL.Left = ClientSize.Width + 300;
            pipeBottomLL.Left = ClientSize.Width + 300;

            pipeTopL.Left = ClientSize.Width + 600;
            pipeBottomL.Left = ClientSize.Width + 600;

            pipeTopR.Left = ClientSize.Width + 900;
            pipeBottomR.Left = ClientSize.Width + 900;

            pipeTopRR.Left = ClientSize.Width + 1200;
            pipeBottomRR.Left = ClientSize.Width + 1200;
         
            //Boruların geçiş işaretlerini sıfırla
            pipePassedLL = false;
            pipePassedL = false;
            pipePassedR = false;
            pipePassedRR = false;

            isJumping = false; // Zıplama kontrolünü sıfırla
            timer1.Start(); // Fonksiyonları çalıştır
            isGameActive = true; // Oyun oynanıyor durumda*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Visible = false; // Yeniden Oyna butonunu gizle
            button1.Enabled = false; // Yeniden Oyna butonunun devre dışı bırak

            gameOverLabel.Visible = false; // Game Over yazısını gizle
            skor = 0; // Skor'u sıfırla
            skorLabel.Visible = true; // Skor sayacını görünür kıl

            bird.Top = 200; // Kuşu başlangıç konumuna getir

            //Boruları başlangıç konumlarına getir
            pipeTopLL.Left = ClientSize.Width + 300;
            pipeBottomLL.Left = ClientSize.Width + 300;

            pipeTopL.Left = ClientSize.Width + 600;
            pipeBottomL.Left = ClientSize.Width + 600;

            pipeTopR.Left = ClientSize.Width + 900;
            pipeBottomR.Left = ClientSize.Width + 900;

            pipeTopRR.Left = ClientSize.Width + 1200;
            pipeBottomRR.Left = ClientSize.Width + 1200;

            //Boruların geçiş işaretlerini sıfırla
            pipePassedLL = false;
            pipePassedL = false;
            pipePassedR = false;
            pipePassedRR = false;

            isJumping = false; // Zıplama kontrolünü sıfırla
            timer1.Start(); // Fonksiyonları çalıştır
            isGameActive = true; // Oyun oynanıyor durumda
        }
    }
}
