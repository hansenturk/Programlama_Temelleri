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
    public partial class FrmKontrolYapilari : Form
    {
        public FrmKontrolYapilari()
        {
            InitializeComponent();
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            ////***** Koşul Operatörü ****\\\\
            //int Sayi1 = 10;
            //int Sayi2;
            //int.TryParse(TxtBilgi.Text,out Sayi2);
            //MessageBox.Show(Sayi2 > Sayi1 ? "Büyük Sayı girdiniz" : "Sayı Uygundur");

            ////***** if else Kontrol Yapısı ****\\\\

            //// if      ----> Eğer         ---> Başta kullanılır 1 kere
            //// else if ----> Eğer Değilse ---> if den Sora Kullanılır elseden sonra kullanılmaz sınır yok
            //// else    ----> Değilse      ---> if ve else if den sonra kullanılır 1 kere


            //// if else 1.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2;
            //if (int.TryParse(TxtBilgi.Text, out Sayi2))
            //{
            //    MessageBox.Show("Girilen Değer Doğru Biçimdedir");
            //}

            //else
            //{
            //    MessageBox.Show("Girilen Değer Doğru Biçimde Değil");
            //}

            //// if else 2.Örnek \\
            //int Sayi1 = 10;
            //int Sayi2;
            //if (int.TryParse(TxtBilgi.Text, out Sayi2))
            //{
            //    if (Sayi2>Sayi1)
            //    {
            //        MessageBox.Show("Büyük Sayı Girdiniz");
            //    }
            //    else if (Sayi2 > Sayi1 && Sayi2!=11)
            //    {
            //        MessageBox.Show("Büyük Sayı Girdiniz");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sayı Uygundur");
            //    }
            //}

            //else
            //{
            //    MessageBox.Show("Girilen Değer Doğru Biçimde Değil");
            //}

            //// if else 3.Örnek \\
            //int Sayi;
            //if (int.TryParse(TxtBilgi.Text,out Sayi))
            //{
            //    if (Sayi %2 ==0)
            //    {
            //        MessageBox.Show("Girilen Sayı Çift Sayıdır...");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Girilen Sayı Tek Sayıdır...");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz Değer Girdiniz");
            //}

            //// if else 4.Örnek \\
            //int Sayi;
            //if (int.TryParse(TxtBilgi.Text, out Sayi))
            //{
            //    if (Sayi % 2 == 1)
            //    {
            //        MessageBox.Show("Girilen Sayı Tek Sayıdır...");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Girilen Sayı Çift Sayıdır...");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz Değer Girdiniz");
            //}


            //// if else 5.Örnek \\
            //int not;
            //if (int.TryParse(TxtBilgi.Text, out not))
            //{
            //    if (not<25)
            //    {
            //        MessageBox.Show("Notunuz:'0'");
            //    }
            //    else if (not<45)
            //    {
            //        MessageBox.Show("Notunuz: '1'");
            //    }
            //    else if (not < 55)
            //    {
            //        MessageBox.Show("Notunuz: '2'");
            //    }
            //    else if (not < 75)
            //    {
            //        MessageBox.Show("Notunuz: '3'");
            //    }
            //    else if (not < 85)
            //    {
            //        MessageBox.Show("Notunuz: '4'");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Notunuz:'5'");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz Değer Girdiniz");
            //}

            //// switch case Örnek \\
            //int GunSayi;
            //if (int.TryParse(TxtBilgi.Text, out GunSayi))
            //{
            //    switch (GunSayi)
            //    {
            //        case 1:
            //            MessageBox.Show("Pazartesi Günü");
            //            break;
            //        case 2:
            //            MessageBox.Show("Salı Günü");
            //            break;
            //        case 3:
            //            MessageBox.Show("Çarşamba Günü");
            //            break;
            //        case 4:
            //            MessageBox.Show("Perşembe Günü");
            //            break;
            //        case 5:
            //            MessageBox.Show("Cuma Günü");
            //            break;
            //        case 6:
            //            MessageBox.Show("Cumartesi Günü");
            //            break;
            //        case 7:
            //            MessageBox.Show("Pazar Günü");
            //            break;
            //        default:
            //            MessageBox.Show("Haftanın Böyle Bir GÜnü yok");
            //            break;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz Değer Girdiniz");
            //}



        }

        private void FrmKontrolYapilari_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }
    }
}
 