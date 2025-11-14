using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {

        string[] sehirler = new string[]
        {
           "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AKSARAY", "AMASYA", "ANKARA", "ANTALYA", "ARDAHAN", "ARTVİN",
            "AYDIN", "BALIKESİR", "BARTIN", "BATMAN", "BAYBURT", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR",
            "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "DÜZCE", "EDİRNE", "ELAZIĞ", "ERZİNCAN",
            "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "IĞDIR", "ISPARTA", "İSTANBUL",
            "İZMİR", "KAHRAMANMARAŞ", "KARABÜK", "KARAMAN", "KARS", "KASTAMONU", "KAYSERİ", "KIRIKKALE", "KIRKLARELİ", "KIRŞEHİR",
            "KİLİS", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "MARDİN", "MERSİN", "MUĞLA", "MUŞ",
            "NEVŞEHİR", "NİĞDE", "ORDU", "OSMANİYE", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS",
            "ŞANLIURFA", "ŞIRNAK", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "UŞAK", "VAN", "YALOVA", "YOZGAT", "ZONGULDAK"
        };

        private string secilenSehir;
        private int hataSayisi = 0;
        private const int maxHataSayisi = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RastgeleSehirSec();
            altTireGoster();
            
        }

        private void RastgeleSehirSec()
        {
            // Rastgele bir şehir seçiyoruz
            Random rnd = new Random();
            int index = rnd.Next(sehirler.Length);
            secilenSehir = sehirler[index];

            // Debug için şehri ekranda gösteriyoruz
            //debug.Text = secilenSehir;
        }

        private void altTireGoster()
        {
            // Seçilen şehrin harf sayısı kadar alt tire oluşturuyoruz (boşluk bırakacak şekilde)
            string altTireler = string.Join(" ", secilenSehir.Select(c => "_"));

            // Alt tireleri label'da gösteriyoruz
            Kelime.Text = altTireler;
        }

        private void harfButonu_Click(object sender, EventArgs e)
        {
            Button buton = sender as Button; // Buton nesnesini alıyoruz
            string tahminEdilenHarf = buton.Text; // Butondaki harfi alıyoruz

            // Doğru tahmin mi kontrol et
            if (secilenSehir.Contains(tahminEdilenHarf))
            {
                // Harfi bulduk, alt tireleri güncelle
                KelimeGuncelle(tahminEdilenHarf);
                buton.Enabled = false;

                // Oyunun kazanılıp kazanılmadığını kontrol et
                if (TumHarflerBulundu())
                {
                    MessageBox.Show("Tebrikler! Kazandınız!");
                    this.Close(); // Oyunu kapatabilir veya başka bir işlem yapabilirsin
                }
            }
            else
            {
                // Yanlış tahmin, hata sayısını artır
                hataSayisi++;
                // Butonu deaktif et
                buton.Enabled = false;
                // Görsel güncelle
                GoruntuGuncelle(hataSayisi);
            }

            // Kalan hak sayısını güncelle
            KalanHakGuncelle();

            // Eğer hata sayısı maksimumu geçtiyse, oyunu kaybettin
            if (hataSayisi >= maxHataSayisi)
            {
                MessageBox.Show("Kaybettiniz! Doğru şehir: " + secilenSehir);
                this.Close(); // Oyunu kapatabilir veya başka bir işlem yapabilirsin
            }
        }

        private void KalanHakGuncelle()
        {
            // Kalan hak sayısını hesapla
            int kalanHak = maxHataSayisi - hataSayisi;
            // Label'da göster
            lblKalanHak.Text = "Kalan Hak: " + kalanHak;
        }


        private bool TumHarflerBulundu()
        {
            // Seçilen şehrin tüm harflerinin tahmin edilip edilmediğini kontrol et
            foreach (char harf in secilenSehir)
            {
                if (!Kelime.Text.Contains(harf.ToString())) // Harflerin alt tirelerde olup olmadığını kontrol et
                {
                    return false; // Eğer bir harf bulunamadıysa false döner
                }
            }
            return true; // Tüm harfler bulunduysa true döner
        }


        private void KelimeGuncelle(string tahminEdilenHarf)
        {
            // Seçilen şehirdeki harfleri güncelle
            char[] guncelKelime = Kelime.Text.Replace(" ", "").ToCharArray();
            string tahminHarfiKucuk = tahminEdilenHarf.ToLower(); // Tahmin edilen harfi küçük harfe çevir

            for (int i = 0; i < secilenSehir.Length; i++)
            {
                // Eğer harf doğru tahmin edilmişse
                if (secilenSehir[i].ToString().ToLower() == tahminHarfiKucuk)
                {
                    guncelKelime[i] = secilenSehir[i]; // Doğru tahmin edilen harfi güncelle
                }
            }

            // Güncellenmiş kelimeyi boşluklu olarak göster
            Kelime.Text = string.Join(" ", guncelKelime);
        }

        private void GoruntuGuncelle(int yanlisTahmin)
        {
            try
            {
                // Yanlış tahmin sayısına göre görseli güncelle
                string gorselAdi = $"{yanlisTahmin}.png";
                string gorselYolu = Path.Combine("Resources", gorselAdi);
                
                gorsel.Image = Image.FromFile(gorselYolu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görsel yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }







}

