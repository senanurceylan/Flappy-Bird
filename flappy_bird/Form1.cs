using System;  // Temel sistem fonksiyonlarını içe aktarıyoruz (giriş-çıkış işlemleri gibi).
using System.Collections.Generic;  // Generic koleksiyonları kullanmak için gerekli kütüphane.
using System.ComponentModel;  // Bileşenlerle çalışmayı sağlar (genellikle tasarım bileşenleri).
using System.Data;  // Veritabanı işlemleri için kullanılan kütüphane (bu projede kullanılmamış).
using System.Drawing;  // Grafiksel işlemler ve görüntü çizimleri için kütüphane.
using System.Linq;  // LINQ sorgulama fonksiyonları için kullanılan kütüphane.
using System.Text;  // Metin işlemleri için kullanılan kütüphane.
using System.Threading.Tasks;  // Asenkron programlama ve görevler için kullanılan kütüphane (bu projede kullanılmamış).
using System.Windows.Forms;  // Windows Forms uygulamaları için gerekli olan kütüphane (arayüz ve olaylar için).

namespace flappy_bird  // Projenin ad alanı, kodun proje içinde organize edilmesi için kullanılır.
{
    public partial class Form1 : Form  // Form1 adında bir sınıf oluşturuluyor ve bu sınıf bir formdur (Windows Forms arayüzü).
    {

        // Oyunla ilgili değişkenler tanımlanıyor.
        int pipeSpeed = 4;  // Boruların (disklerin) hareket hızı başlangıçta 4 olarak ayarlanıyor.
        int gravity = 10;  // Kuşun yerçekimi kuvveti başlangıçta 10 olarak ayarlanıyor (kuş aşağı doğru düşer).
        int score = 0;  // Oyuncunun başlangıç skoru 0 olarak ayarlanıyor.



        public Form1()  // Form1 sınıfının constructor (yapıcı) metodu, form ilk yüklendiğinde çalışır.
        {
            InitializeComponent();  // Formun bileşenleri (butonlar, etiketler vs.) bu fonksiyonla başlatılıyor.
        }



        // Oyun zamanlayıcısı ile ilgili olay bu fonksiyonda kontrol ediliyor. Oyun her karede bu olayı çalıştırır.
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;  // Kuşun dikey konumu yerçekimi kuvvetine göre güncellenir (aşağı düşer).
            altDisk.Left -= pipeSpeed;  // Alt boru soldan sağa doğru hareket eder (hızı pipeSpeed ile ayarlanır).
            ustDisk.Left -= pipeSpeed;  // Üst boru da aynı şekilde soldan sağa doğru hareket eder.
            scoreText.Text = "score " + score;  // Skor ekrana güncellenmiş haliyle yazdırılır.

            // Alt boru ekranın soluna geldiğinde tekrar sağ tarafa resetlenir (yeniden görünür hale gelir).
            if (altDisk.Left < -150)
            {
                altDisk.Left = 800;  // Alt boru ekranın sağında yeniden ortaya çıkar.
                score++;  // Skor artırılır.
            }

            // Üst boru da ekranın soluna geldiğinde resetlenir.
            if (ustDisk.Left < -180)
            {
                ustDisk.Left = 950;  // Üst boru ekranın sağında yeniden ortaya çıkar.
                score++;  // Skor artırılır.
            }

            // Eğer kuş alt veya üst borulara ya da yere çarparsa oyun sona erer.
            if (flappyBird.Bounds.IntersectsWith(altDisk.Bounds) ||  // Kuş alt boruya çarparsa...
                flappyBird.Bounds.IntersectsWith(ustDisk.Bounds) ||   // Kuş üst boruya çarparsa...
                flappyBird.Bounds.IntersectsWith(zemin.Bounds))  // Ya da kuş yere çarparsa...
            {
                endGame();  // Oyun bitirme fonksiyonu çağrılır.
            }

            // Skor 5'i geçerse boruların hızı artırılır, bu da oyunu zorlaştırır.
            if (score > 5)
            {
                pipeSpeed = 15;  // Boruların hızı 15 olarak güncellenir.
            }
        }

        // Bu fonksiyon, bir tuşa basıldığında çalışır (özellikle Space tuşu).
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)  // Eğer Space tuşuna basılırsa...
            {
                gravity = -15;  // Kuş yukarı doğru hareket eder (negatif yerçekimi kuvveti uygulanır).
            }
        }

        // Bu fonksiyon, tuş bırakıldığında çalışır (özellikle Space tuşu bırakıldığında).
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)  // Eğer Space tuşu bırakılırsa...
            {
                gravity = 10;  // Yerçekimi tekrar pozitif hale gelir ve kuş aşağı düşmeye başlar.
            }
        }

        // Oyun sona erdiğinde bu fonksiyon çalışır.
        private void endGame()
        {
            gameTimer.Stop();  // Oyun zamanlayıcısı durdurulur, oyun bitmiş olur.
            scoreText.Text = " game over!";  // Ekrana "game over" (oyun bitti) yazısı yazılır.
        }
    }
}
