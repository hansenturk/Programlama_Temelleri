using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace derstekrar
{
    public partial class FrmHataKontrolu : Form
    {
        public FrmHataKontrolu()
        {
            InitializeComponent();
        }

        private void FrmHataKontrolu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            //try
            //{
            //    //// Hata oluşabilecek kodlar buraya yazılır
            //}
            //catch
            //{
            //    //// Hata oluştupunda çalıştırılacak kod bloğu
            //}
            //finally 
            //{
            //    //// Hata olsun olmasın çalıştırılacak kodlar
            //}



            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font,FontStyle.Bold);
            //try
            //{
            //    int sifir = 0;
            //    int sonuc = 10 / sifir;
            //}
            //catch (Exception)
            //{
            //    LblBilgi.Text += "Hata oluştu..." + Environment.NewLine;

            //}
            //finally
            //{
            //    MessageBox.Show("Sürekli Çalışırım Ben....");
            //}

            //Controls.Add(LblBilgi);


        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            //// Konrtol Örneği 1 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //    LblBilgi.Text += " " + Environment.NewLine;
            //    int Not = int.Parse(Interaction.InputBox("Noyu giriniz"));
            //    if (Not < 45)
            //    {
            //        MessageBox.Show("Kaldınız");
            //    }
            //    else if (Not >= 45 && Not <= 100)
            //    {
            //        MessageBox.Show("Geçtiniz");
            //    }
            //}
            //catch (Exception)
            //{
            //    LblBilgi.Text += "Yanlış Not Girişi Yaptınız..." + Environment.NewLine;                /// Kod hata verirse bursaı çalışır

            //}

            //Controls.Add(LblBilgi);

            ////// Konrtol Örneği 2 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //    LblBilgi.Text += " " + Environment.NewLine;
            //    int Not = int.Parse(Interaction.InputBox("Noyu giriniz"));
            //    if (Not < 45)
            //    {
            //        MessageBox.Show("Kaldınız");
            //    }
            //    else if (Not >= 45 && Not <= 100)
            //    {
            //        MessageBox.Show("Geçtiniz");
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    LblBilgi.Text += Ex.ToString() + Environment.NewLine;                      //// Kod hata verirse burası çalışır ve tüm hata komutlarını ekrana yazdırı
            //}

            //Controls.Add(LblBilgi);



            ////// Konrtol Örneği 3 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //    LblBilgi.Text += " " + Environment.NewLine;
            //    int Not = int.Parse(Interaction.InputBox("Noyu giriniz"));
            //    if (Not < 45)
            //    {
            //        MessageBox.Show("Kaldınız");
            //    }
            //    else if (Not >= 45 && Not <= 100)
            //    {
            //        MessageBox.Show("Geçtiniz");
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    LblBilgi.Text += Ex.Message + Environment.NewLine;                      //// kod hata verirse hatanın ne olduğunu söyler

            //}

            //Controls.Add(LblBilgi);



            //// Konrtol Örneği 4 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //    LblBilgi.Text += " " + Environment.NewLine;
            //    int Not = int.Parse(Interaction.InputBox("Noyu giriniz"));
            //    if (Not < 45)
            //    {
            //        MessageBox.Show("Kaldınız");
            //    }
            //    else if (Not >= 45 && Not <= 100)
            //    {
            //        MessageBox.Show("Geçtiniz");
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    LblBilgi.Text += Ex.TargetSite.Name + Environment.NewLine;                      //// kod hata verirse hatayı oluşturan metodun adını verir

            //}

            //Controls.Add(LblBilgi);


            //// Konrtol Örneği 5 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //    LblBilgi.Text += " " + Environment.NewLine;
            //    int Not = int.Parse(Interaction.InputBox("Notu Giriniz", "Not Girişi"));
            //    if (Not < 45)
            //    {
            //        MessageBox.Show("Kaldınız");
            //    }
            //    else if (Not >= 45 && Not <= 100)
            //    {
            //        int sonuc = Not / 0;
            //    }
            //}
            //catch (FormatException)
            //{
            //    LblBilgi.Text += "Lütfen Tam Sayı Giriniz" + Environment.NewLine;                   //// Hata format kaynalıysa burası çalışır
            //}
            //catch (DivideByZeroException)
            //{
            //    LblBilgi.Text += "Bir Sayıyı Sıfıra Bölemezsiniz" + Environment.NewLine;            //// Hata Sayıyı 0'a bölme ise burası çalışır
            //}
            //catch (Exception Ex)
            //{
            //    LblBilgi.Text += Ex.Message + Environment.NewLine;                                 //// Hata format kaynaklı değilse burası çalışır

            //}

            //Controls.Add(LblBilgi);


            //// Konrtol Örneği 6 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{   
            //    LblBilgi.Text += " " + Environment.NewLine;  
            //    int Sayi = int.Parse(Interaction.InputBox("Notu Giriniz", "Not Girişi"));
            //    int Faktoriyel = 1;
            //    if (Sayi % 2 == 1)
            //    {
            //        for (int i = 1; i <= Sayi; i++)
            //        {
            //            Faktoriyel *= i;
            //        }
            //        LblBilgi.Text += $"Sayının Faktöriyeli: {Faktoriyel}"+Environment.NewLine;
            //    }
            //    else 
            //    {
            //        LblBilgi.Text += $"{Sayi} Çift Sayıdır" + Environment.NewLine;
            //    }
            //}
            //catch (FormatException)
            //{
            //    LblBilgi.Text += "Lütfen Tam Sayı Giriniz" + Environment.NewLine;                   //// Hata format kaynalıysa burası çalışır
            //}           
            //catch (Exception Ex)
            //{
            //    LblBilgi.Text += Ex.Message + Environment.NewLine;                                 //// Hata format kaynaklı değilse burası çalışır

            //}

            //Controls.Add(LblBilgi);

            //// Konrtol Örneği 7 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //LblBilgi.Text += " " + Environment.NewLine;
            //    int Not = int.Parse(Interaction.InputBox("Notu Giriniz", "Not Girişi"));

            //    if (Not < 45)
            //    {
            //        LblBilgi.Text += "Kaldınız..." + Environment.NewLine;
            //    }
            //    else if (Not >= 45 && Not <= 100)
            //    {
            //        LblBilgi.Text += "Geçtiniz.." + Environment.NewLine;
            //    }
            //    else if (Not > 100)
            //    {
            //        throw new Exception("100'den Büyük Not Girişi Yapamazsınız..");
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message);                                         //// Kod hata verirse hatanın ne olduğunu söyler
            //}
            //    Controls.Add(LblBilgi);


            //// Konrtol Örneği 7 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //try
            //{
            //    LblBilgi.Text += " " + Environment.NewLine;
            //    string sifre =Interaction.InputBox("Şifre Girişi", "Şifre Giriniz");
            //    if (sifre.Length<7 || sifre.Length>15 )
            //    {
            //        throw new Exception("Şifre En Az 8 En Fazla 14 Karakter Olmalıdır");
            //    }
            //    else if (!sifre.Any(char.IsDigit))
            //    {
            //        throw new Exception("Şifre En Az 1 Rakam İçermelidir");
            //    }

            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message);                                         //// Kod hata verirse hatanın ne olduğunu söyler
            //}
            //Controls.Add(LblBilgi);


            //// Konrtol Örneği 8 \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //LblBilgi.Font = new Font(LblBilgi.Font, FontStyle.Bold);
            //LblBilgi.Text += " " + Environment.NewLine;

            //try
            //{
            //    int[] sayi = new int[3];
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        sayi[i] = i ;
            //    }
            //    foreach (int sayilar in sayi)
            //    {
            //        LblBilgi.Text += $"{sayilar}" + Environment.NewLine;
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message);
            //}
            
            
            //Controls.Add(LblBilgi);

        }
    }
}
