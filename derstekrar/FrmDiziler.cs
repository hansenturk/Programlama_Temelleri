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
    public partial class FrmDiziler : Form
    {
        public FrmDiziler()
        {
            InitializeComponent();
        }

        private void FrmDiziler_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            ////***** Diziler *****\\\\

            //// 1. Dizi Tanımlama \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[] Ad = { "Tolga", "Ali","Berat" };
            //LblBilgi.Text += Ad[0] + Environment.NewLine;                                                     //// 1. Elemanı ekrana yazdırır
            //LblBilgi.Text += Ad[1] + Environment.NewLine;                                                     //// 2. Elemanı ekrana yazdırır
            //LblBilgi.Text += Ad[2] + Environment.NewLine;                                                     //// 3. Elemanı ekrana yazdırır
            //LblBilgi.Text += Ad[Ad.Length-1] + Environment.NewLine;                                           //// Dizinin son elemanını verir
            //LblBilgi.Text += Ad.Length.ToString() + Environment.NewLine;                                      //// Dizinin kaç elemanı olduğunu ekrana yazdırır

            //Controls.Add(LblBilgi);


            //// 2. Dizi Tanımlama \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[] Ad = new string[3];
            //Ad[0] = "Tolga";
            //Ad[1] = "Ali";
            //Ad[2] = "Berat";
            //int[] Numara = { 1, 2, 3 };
            //LblBilgi.Text += Ad[0] + " " + Numara[0] + Environment.NewLine;                                                   //// 1. Elemanı ekrana yazdırır
            //LblBilgi.Text += Ad[1] + " " + Numara[1] + Environment.NewLine;                                                   //// 2. Elemanı ekrana yazdırır
            //LblBilgi.Text += Ad[2] + " " + Numara[2] + Environment.NewLine;                                                   //// 3. Elemanı ekrana yazdırır
            //LblBilgi.Text += Ad[Ad.Length - 1] + " "  + Numara[Numara.Length-1] + Environment.NewLine;                        //// Dizinin son elemanını verir
            //LblBilgi.Text += Ad.Length.ToString() + " " + Numara.Length.ToString() + Environment.NewLine;                     //// Dizinin kaç elemanı olduğunu ekrana yazdırır

            //Controls.Add(LblBilgi);

            ////      3. Dizi Tanımlama       \\\\
            //// For Döngüsü İle Dizi Yazdırma \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[] Ad = new string[3];
            //Ad[0] = "Tolga";
            //Ad[1] = "Ali";
            //Ad[2] = "Berat";
            //int[] Numara = { 1, 2, 3 };
            //for (int i = 0; i < Ad.Length; i++)
            //{
            //    LblBilgi.Text += Ad[i] + " " + Numara[i] + Environment.NewLine;                            //// Dizinin tüm elemanlarını alt alta yazdırır 

            //}

            //Controls.Add(LblBilgi);

            ////         4. Dizi Tanımlama         \\\\
            //// foreach Döngüsü İle Dizi Tanımlama \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[] Ad = new string[3];
            //Ad[0] = "Tolga";
            //Ad[1] = "Ali";
            //Ad[2] = "Berat";
            //int[] Numara = { 1, 2, 3 };
            //foreach (string item in Ad)
            //{
            //    LblBilgi.Text += item + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);

            ////         5. Dizi Tanımlama          \\\\
            ////   for Döngüsü İle Dizi Tanımlama   \\\\
            //// foreach Döngüsü İle Dizi Yazdırma  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //int[] Sayilar = new int[10];
            //for (int i = 0; i < Sayilar.Length; i++)                            //// for ile dizinin elemanlarını tanımladık
            //{
            //    Sayilar[i] = i+1;
            //}
            //foreach (int Sayi in Sayilar)                                       //// foreach ile dizinin elemanlarını yazdırdık
            //{
            //    LblBilgi.Text += Sayi + Environment.NewLine;
            //}




            //Controls.Add(LblBilgi);

            ////         6. Dizi Tanımlama           \\\\
            //// do while Döngüsü İle Dizi Tanımlama \\\\
            ////   while Döngüsü İle Dizi Yazdırma   \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //int[] Sayilar = new int[10];
            //int Sayi1 = 0;
            //do                                                                          //// do while ile dizinin elemanlarını tanımladık
            //{
            //    Sayilar[Sayi1] = Sayi1 + 1;
            //    Sayi1++;
            //} while (Sayi1<Sayilar.Length);

            //int Sayi2 = 0;
            //while (Sayi2<Sayilar.Length)                                                //// while ile dizinin elemanlarını yazdırdık
            //{
            //    LblBilgi.Text += Sayilar[Sayi2] + Environment.NewLine;
            //    Sayi2++;
            //}



            //Controls.Add(LblBilgi);




            ////***** Çok Boyutlu Diziler *****\\\\

            ////// 1. Çok Boyutlu Dizi Tanımlama \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[,] AdSoyad = { { "Tolga", "Ali", "Berat" }, { "Can", "Ön", "Erdinç" } };
            //for (int i = 0; i < AdSoyad.GetLength(0); i++)
            //{
            //    for (int j = 0; j < AdSoyad.GetLength(1); j++)
            //    {
            //        LblBilgi.Text += AdSoyad[i,j]+ Environment.NewLine;                                                             //// Dizinin tüm elemanlarını alt alta yazdırır 
            //    }
            //}
            //LblBilgi.Text += "Toplam Eleman Sayısı" + " " + AdSoyad.Length.ToString() + Environment.NewLine;                        //// Dizinin toplam eleman sayısını verir
            //LblBilgi.Text += "Satır Sayısı" + " " + AdSoyad.GetLength(0).ToString() + Environment.NewLine;                        //// Dizinin satır sayısını verir
            //LblBilgi.Text += "Sütun Sayısı" + " " + AdSoyad.GetLength(1).ToString() + Environment.NewLine;                        //// Dizinin sütun sayısını verir
            //Controls.Add(LblBilgi);

            //// 2. Çok Boyutlu Dizi Tanımlama \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[,] AdSoyad = new string[2,4];
            //AdSoyad[0, 0] = "Tolga";
            //AdSoyad[0, 1] = "Ali";
            //AdSoyad[0, 2] = "Berat";
            //AdSoyad[0, 3] = "Berkay";
            //AdSoyad[1, 0] = "Can";
            //AdSoyad[1, 1] = "Ön";
            //AdSoyad[1, 2] = "Erdinç";
            //AdSoyad[1, 3] = "Fidan";
            //LblBilgi.Text += "Toplam Eleman Sayısı" + " " + AdSoyad.Length.ToString() + Environment.NewLine;                      //// Dizinin toplam eleman sayısını verir
            //LblBilgi.Text += "Satır Sayısı" + " " + AdSoyad.GetLength(0).ToString() + Environment.NewLine;                        //// Dizinin satır sayısını verir
            //LblBilgi.Text += "Sütun Sayısı" + " " + AdSoyad.GetLength(1).ToString() + Environment.NewLine;                        //// Dizinin sütun sayısını verir
            //Controls.Add(LblBilgi);



            ////*****Diziyi Yeniden Bıyutlandırma *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[] isimler = new string[2];
            //isimler[0] = "Tolga";
            //isimler[1] = "Ali";
            //LblBilgi.Text += "İlk Eleman Sayısı" + isimler.Length.ToString()+Environment.NewLine+isimler[1]+" ";
            //Array.Resize(ref isimler, 1);                                                                                           //// 2 elemanlı diziyi 1 elemanlı yapar
            //LblBilgi.Text += "Son Eleman Sayısı" + isimler.Length.ToString() + Environment.NewLine + isimler[0];



            //Controls.Add(LblBilgi);



            //////***** CreateInstance Metodu *****\\\\


            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Array isimler = Array.CreateInstance(typeof(string), 2);                                                    //// 2 elemanlı string üründe dizi oluşturdu
            //isimler.SetValue("Togla", 1);                                                                               //// 1. index'e değer atandı
            //isimler.SetValue("Ali", 0);                                                                                 //// 0. index'e Değer atandı
            //LblBilgi.Text += isimler.GetValue(1)+Environment.NewLine;                                                   //// 1. İndex'i ekrana yazdırıdı
            //LblBilgi.Text += "Eleman Sayısı " + isimler.Length.ToString() + Environment.NewLine;                        //// Dizinin eleman sayısı yazdırdı

            //Controls.Add(LblBilgi);


            ////***** Isarray Metodu *****\\\\
            //// 1. Örnek ////

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string isimler="Tolga,Ali";
            //LblBilgi.Text += isimler.GetType().IsArray.ToString();                                      //// Dizi olup olmadığını söyler 
            //                                                                                            //// Dizi değil false yazdırır
            //Controls.Add(LblBilgi);

            //// 2. Örnek ////

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //string[] isimler = { "Tolga", "Ali" };
            //LblBilgi.Text += isimler.GetType().IsArray.ToString();                                      //// Dizi olup olmadığını söyler 
            //                                                                                            //// Dizi true yazdırır
            //Controls.Add(LblBilgi);


            ////***** Join Metodu *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //string[] isimler = { "Tolga", "Ali", "Berat", "Berkay" };
            //LblBilgi.Text = string.Join("-", isimler);                                              //// Dizi elemanları arasına '-' koyar


            //Controls.Add(LblBilgi);


            //////***** Contains Metodu *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //string[] isimler = { "Tolga", "Ali", "Berat", "Berkay" };
            //if (isimler.Contains("Tolgaa"))                                                              //// Dizi elemanları içinde 'Tolga' değeri arar
            //{
            //    LblBilgi.Text = "Dizi Elemanları İçinde Bu İsim Mevcut";                                
            //}
            //else
            //{
            //    LblBilgi.Text= "Dizi Elemanları İçinde Bu İsim Mevcut Değil!";
            //}


            //Controls.Add(LblBilgi);


            //////***** IndexOf Metodu *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //string[] isimler = { "Tolga", "Ali", "Berat", "Berkay" };

            //LblBilgi.Text = Array.IndexOf(isimler, "Tolga").ToString();                                     //// Dizi elemanları içinde baştan arayarak ilk bulduğu 'Tolga' değerinib index numarasını verir
            //                                                                                                //// Dizi elemanları içinde baştan arayarak 'Tolga' değerini bulamazsa -1 yazar


            //Controls.Add(LblBilgi);


            ////***** LastIndexOf Metodu *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);
            //string[] isimler = { "Tolga", "Ali", "Berat", "Berkay","Tolga" };

            //LblBilgi.Text = Array.LastIndexOf(isimler, "Tolgaa").ToString();                            //// Dizi elemanları içinde sondan arayarak ilk bulduğu 'Tolga' değerininin index numarasını verir
            //                                                                                            //// Dizi elemanları içinde sondan arayarak'Tolga' değerini bulamazsa -1 yazar


            //Controls.Add(LblBilgi);

































        }
    }
}
