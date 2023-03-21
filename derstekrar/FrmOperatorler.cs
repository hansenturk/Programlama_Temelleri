using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace derstekrar
{
    public partial class FrmOperatorler : Form
    {
        public FrmOperatorler()
        {
            InitializeComponent();
        }
            
        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            //***** Aritmatiksel Operatörler *****\\

            //// Toplama Operatörü  '+' \\ 
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //int Sonuc = Sayi1 + Sayi2;
            //LblBilgi.Text = Sonuc.ToString();

            //// Çıkarma Operatörü  '*' \\ 
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //int Sonuc = Sayi1 - Sayi2;
            //LblBilgi.Text = Sonuc.ToString();

            //// Çarpma Operatörü  '*' \\ 
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //int Sonuc = Sayi1 * Sayi2;
            //LblBilgi.Text = Sonuc.ToString();

            //// Bölme Operatörü  '/' \\ 
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //int Sonuc = Sayi1 / Sayi2;
            //LblBilgi.Text = Sonuc.ToString();

            //// Mod Operatörü  '%' \\ 
            //int Sayi1 = 7;
            //int Sayi2 = 5;
            //int Sonuc = Sayi1 % Sayi2;
            //LblBilgi.Text = Sonuc.ToString();

            //***** İşlem Önceliği *****\\

            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //int Sayi3 = 12;
            //int Sonuc = (Sayi1 - Sayi2) * Sayi3;
            //LblBilgi.Text = Sonuc.ToString();

            //***** Mantıksal Operatörler *****\\

            // Ve Operatörü '&' \\
            //bool Dogru = true;
            //bool Yanlis = false;
            //bool Kontrol = true;
            //bool Sonuc = Dogru & Yanlis & Kontrol;       //// 1 tane false varsa false verir
            //LblBilgi.Text = Sonuc.ToString();

            //// VeDeğil Operatörü '&&' \\
            //bool Dogru = true;
            //bool Yanlis = false;
            //bool Kontrol = true;
            //bool Sonuc = Dogru && Yanlis && Kontrol;     //// 1. fasle ise false verir 1. ture ise ikinciye bakar eğer false varsa false verir yoksa true verir
            //LblBilgi.Text = Sonuc.ToString();            //// false bulana kadar sıra sıra kontrol eder bulunca kontrol etmeyi brakır eğer false yoksa true verir

            //// Vaya Operatörü '|' \\
            //bool Dogru = true;
            //bool Yanlis = false;
            //bool Kontrol = true;
            //bool Sonuc = Dogru | Yanlis | Kontrol;       //// 1 tane true varsa true verir
            //LblBilgi.Text = Sonuc.ToString();

            //// VayaDeğil Operatörü '||' \\
            //bool Dogru = true;
            //bool Yanlis = false;
            //bool Kontrol = true;
            //bool Sonuc = Dogru || Yanlis || Kontrol;     //// 1. true ise true verir 1. false ise ikinciye bakar eğer true varsa true verir yoksa false verir
            //LblBilgi.Text = Sonuc.ToString();            //// true bulana kadar sıra sıra kontrol eder bulunca kontrol etmeyi brakır eğer true yoksa false verir

            //// Özel Vaya Operatörü '^' \\                //// '^' İşareti için "shift+3'e iki defa basıp 1 kere silin" 
            //bool Dogru = true;
            //bool Yanlis = false;
            //bool Sonuc = Dogru ^ Yanlis ;                //// eğer iki değerde false ise false verir eğer true varsa true verir 
            //LblBilgi.Text = Sonuc.ToString();            

            //// Koşul Operatörü '??' \\
            //string Ad = null;
            //string Durum = Ad ?? "Ad Girilmedi";
            //LblBilgi.Text = Durum;

            //***** Karşılaştırma Operatörleri *****\\

            //// Eşittir Operatörü '==' \\ 

            //// 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 == Sayi2;                 //// False
            //LblBilgi.Text = Sonuc.ToString();

            //// 2.Örnek \\
            //int Sayi1 = 5;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 == Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// Büyüktür Operatörü '>' \\ 

            // 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 > Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// 2.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 15;
            //bool Sonuc = Sayi1 > Sayi2;                 //// False
            //LblBilgi.Text = Sonuc.ToString();

            //// Büyük Eşittir Operatörü '>=' \\ 

            // 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 >= Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// 2.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 10;
            //bool Sonuc = Sayi1 >= Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// 3.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 15;
            //bool Sonuc = Sayi1 >= Sayi2;                 //// False
            //LblBilgi.Text = Sonuc.ToString();

            //// Küçüktür Operatörü '>' \\ 

            // 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 < Sayi2;                 //// False
            //LblBilgi.Text = Sonuc.ToString();

            //// 2.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 15;
            //bool Sonuc = Sayi1 < Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// Küçük Eşittir Operatörü '<=' \\ 

            // 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 <= Sayi2;                 //// False
            //LblBilgi.Text = Sonuc.ToString();

            //// 2.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 10;
            //bool Sonuc = Sayi1 <= Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// 3.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 15;
            //bool Sonuc = Sayi1 <= Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            //// Eşit Değil Operatörü '!=' \\ 

            // 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 5;
            //bool Sonuc = Sayi1 != Sayi2;                 //// True
            //LblBilgi.Text = Sonuc.ToString();

            // 2.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2 = 10;
            //bool Sonuc = Sayi1 != Sayi2;                 //// False
            //LblBilgi.Text = Sonuc.ToString();













        }

        private void FrmOperatorler_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}
