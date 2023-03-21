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
    public partial class FrmDonguler : Form
    {
        public FrmDonguler()
        {
            InitializeComponent();
        }

        private void FrmDonguler_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            //// For Döngüsü 1. örnek \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);
            //LblBilgi.Text = "0 ";                                     //// For döngüsü kullanmadan 0' dan 10'a kadar yazdıran kod satırı
            //LblBilgi.Text += "1 ";
            //LblBilgi.Text += "2 ";
            //LblBilgi.Text += "3 ";
            //LblBilgi.Text += "4 ";
            //LblBilgi.Text += "5 ";
            //LblBilgi.Text += "6 ";
            //LblBilgi.Text += "7 ";
            //LblBilgi.Text += "8 ";
            //LblBilgi.Text += "9 ";
            //     for (int i = 0; i < 10; i++)                                 //// 0'dan 10'a kadar 1'er 1'er arttırır 
            //    {
            //        LblBilgi.Text += i.ToString()+" ";                        //// Yan yana yazdırır
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        LblBilgi.Text += i.ToString() + "\n ";                    //// Alt alta yazdırır
            //    }
            //    for (int i = 0; i < 10; i++)
            //    {
            //        LblBilgi.Text += i.ToString() + Environment.NewLine;      //// Alt alta yazdırır
            //    }

            //    Controls.Add(LblBilgi);


            //// For Döngüsü 2. örnek \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);

            //for (int i = 0; i <= 10; i+=2)                                      //// 2'şer 2'şer attırır
            //{
            //    LblBilgi.Text += i.ToString() + " ";                            //// Yan yana yazdırır
            //}

            //Controls.Add(LblBilgi);

            //// For Döngüsü 3. örnek \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);

            //for (int i = 10; i >= 0; i--)                                       //// 1'er 1'er azaltır
            //{
            //    LblBilgi.Text += i.ToString() + " ";                            //// Yan yana yazdırır
            //}

            //Controls.Add(LblBilgi);

            //// For Döngüsü 4. örnek \\\\
            //// continune deyimi      \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);

            //for (int sayac=0; sayac <=10 ;sayac++)                              //// 1'er 1'er azaltır
            //{
            //    if (sayac==5)                                                   //// 5'i yazdırmaz
            //    {
            //        continue;                                                   
            //    }
            //    LblBilgi.Text += sayac.ToString() + " ";                        //// Yan yana yazdırır
            //}

            //Controls.Add(LblBilgi);

            //// For Döngüsü 5. örnek \\\\
            //// break deyimi      \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);

            //for (int sayac = 0; sayac <= 10; sayac++)                             //// 1'er 1'er azaltır
            //{
            //    if (sayac == 5)                                                   //// 5'e geldiğinde döngü durur
            //    {
            //        break;                                                        //// 0,1,2,3,4 Ekrana yazdırılan sayılar   
            //    }
            //    LblBilgi.Text += sayac.ToString() + " ";                          //// Yan yana yazdırır
            //}

            //Controls.Add(LblBilgi);

            //// For Döngüsü 6. örnek \\\\
            //// İç İçe Döngüler      \\\\

            //int X = 10, Y = 10;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Label LblCarpim = new Label();
            //    LblCarpim.AutoSize = true;

            //    for (int j = 1; j <= 10; j++)
            //    {
            //        LblCarpim.Text += i.ToString() + "*" + j.ToString() + "=" + (i * j).ToString() + Environment.NewLine;
            //    }
            //    LblCarpim.Location = new Point(X, Y);
            //    X += 100;
            //    if (i == 5)
            //    {
            //        X = 10;
            //        Y += 140;
            //    }
            //    Controls.Add(LblCarpim);
            //}

            //// Diziler \\\\
            //// 1.Örnek \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);
            //string[] isimler = { "Tolga", "Ali", "Berat", "Berkay", "Baran" };
            //int[] notlar = { 95, 87, 55, 90, 70 };
            //LblBilgi.Text = isimler[4];

            //Controls.Add(LblBilgi);

            //// 2.Örnek \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);
            //string[] isimler = new string[5];
            //isimler[0] = "Tolga";
            //isimler[1] = "Ali";
            //isimler[2] = "Berat";
            //isimler[3] = "Berkay";
            //isimler[4] = "Baran";
            //LblBilgi.Text = isimler[4];

            //Controls.Add(LblBilgi);

            //// 3.Örnek \\\\

            //Label LblBilgi = new Label();
            //LblBilgi.Text = "";
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(10, 10);
            //string[] isimler = { "Tolga", "Ali", "Berat", "Berkay", "Baran","Hüseyin" };
            //int[] notlar = { 95, 87, 55, 90, 70,65 };
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    LblBilgi.Text += isimler[i]+" Aldığı Not: "+notlar[i] + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);


        }
    }

}

