using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace derstekrar
{
    public partial class FrmKolleksiyonlar : Form
    {
        public FrmKolleksiyonlar()
        {
            InitializeComponent();
        }

        private void FrmKolleksiyonlar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            ////***** Non Generic Kolleksiyonlar *****\\\\

            ////// ArryList Sınıfı \\\\
            ////// AddRange Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");                                                                 //// ArryList kolleksiyonuna string değer ekleme
            //isimler.Add("Ali");
            //isimler.Add(125);                                                                     //// ArryList kolleksiyonuna int değer ekleme
            //LblBilgi.Text +="0. İndex: " +isimler[0].ToString()+Environment.NewLine;              //// 0. index'i Ekrana Yazdırır

            //LblBilgi.Text += "isimler kolleksiyonu" + Environment.NewLine;
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString()+Environment.NewLine;
            //}
            //ArrayList isimler2 = new ArrayList();
            //isimler2.Add("Berat");                                                
            //isimler2.Add("Berkay");

            //isimler.AddRange(isimler2);                                         //// isimler2 kolleksiyonunun elemanlarını isimler kolleksiyonuna ekledi

            //LblBilgi.Text += "isimler kolleksiyonu" + Environment.NewLine;
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);

            ////// ArryList Sınıfı \\\\
            //////  Insert Metodu   \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");                                                //// ArryList kolleksiyonuna string değer ekleme
            //isimler.Add("Ali");
            //isimler.Add(125);                                                   //// ArryList kolleksiyonuna int değer ekleme
            //foreach (object isim in isimler)
            //{
            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;
            //isimler.Insert(1,"Berat");                                          //// isimler kolleksiyonuna 1. index'e yeni değer ekledi 1. index 2. index oldu

            //LblBilgi.Text += "isimler kolleksiyonu" + Environment.NewLine;
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //// ArryList Sınıfı \\\\
            ////  InsertRange Metodu   \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");                                                //// ArryList kolleksiyonuna string değer ekleme
            //isimler.Add("Ali");
            //isimler.Add(125);                                                   //// ArryList kolleksiyonuna int değer ekleme
            //ArrayList isimler2 = new ArrayList();
            //isimler2.Add("Berat");
            //isimler2.Add("Berkay");
            //foreach (object isim in isimler)
            //{
            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;
            //isimler.InsertRange(0,isimler2);                                              //// isimler 2 kolleksiyonu elemanlarını 0. index'den başlayarak isimlere ekledi
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //// ArryList Sınıfı \\\\
            ////  Sort Metodu    \\\\
            ////    1.Örnek      \\\\


            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");                                                //// ArryList kolleksiyonuna string değer ekleme
            //isimler.Add("Ali");
            //isimler.Add("Baran");                                                   //// ArryList kolleksiyonuna int değer ekleme
            //isimler.Add("Berat");
            //isimler.Add("Berkay");

            //foreach (object isim in isimler)
            //{
            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Sort();
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //// ArryList Sınıfı \\\\
            ////  Sort Metodu    \\\\
            ////    2.Örnek      \\\\


            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add(10);                                               
            //isimler.Add(9);
            //isimler.Add(8);                                                   
            //isimler.Add(7);
            //isimler.Add(6);

            //foreach (object isim in isimler)
            //{
            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Sort();
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            ////    ArryList Sınıfı    \\\\
            ////  Sort+Reverse Metodu   \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add(18);                                                
            //isimler.Add(20);
            //isimler.Add(8);                                                   
            //isimler.Add(3);
            //isimler.Add(9);

            //foreach (object isim in isimler)
            //{
            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Sort();                                                                 //// Küçükten büyüğe sıralar
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}
            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Reverse();                                                            ////  Kolleksiyonu ters çevirir sıralar
            //foreach (object isim in isimler)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);

            //// ArryList Sınıfı \\\\
            ////   count Metodu   \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add(18);
            //isimler.Add(20);
            //isimler.Add(8);
            //isimler.Add(3);
            //isimler.Add(9);

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Sort();                                                                 //// Küçükten büyüğe sıralar
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}
            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Reverse();                                                            ////  Kolleksiyonu ters çevirir
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //// ArryList Sınıfı \\\\
            ////  Remove Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");                                               
            //isimler.Add("Ali");
            //isimler.Add("Baran");                                                  
            //isimler.Add("Berat");
            //isimler.Add("Berkay");

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Remove("Tolga");                                                                 //// Kolleksiyondan 'Tolga' elemanını siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}
            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Remove("Ali");                                                                 ////  Kolleksiyondan 'Ali' elemanını siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            ////// ArryList Sınıfı \\\\
            ////// RemoveAt Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");
            //isimler.Add("Ali");
            //isimler.Add("Baran");
            //isimler.Add("Berat");
            //isimler.Add("Berkay");

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.RemoveAt(1);                                                                 //// Kolleksiyondan 1. İndex'si siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}
            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.RemoveAt(3);                                                                 ////  Kolleksiyondan 3. İndex'si siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);



            //// ArryList Sınıfı \\\\
            //// RemoveRange Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");
            //isimler.Add("Ali");
            //isimler.Add("Baran");
            //isimler.Add("Berat");
            //isimler.Add("Berkay");

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.RemoveRange(1,2);                                                                 //// Kolleksiyondan 1. İndex'den 2.index'e Kadar siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}
            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.RemoveRange(0,3);                                                                 ////  Kolleksiyondan 0. İndex'den 3.index'e Kadar siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //// ArryList Sınıfı \\\\
            //// Clear Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");
            //isimler.Add("Ali");
            //isimler.Add("Baran");
            //isimler.Add("Berat");
            //isimler.Add("Berkay");

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //isimler.Clear();                                                                 //// Kolleksiyonun tüm elemanları siler
            //for (int i = 0; i < isimler.Count; i++)
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);


            //// ArryList Sınıfı \\\\
            //// GetRange Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");
            //isimler.Add("Ali");
            //isimler.Add("Baran");
            //isimler.Add("Berat");
            //isimler.Add("Berkay");
            //isimler.Add("Baran");
            //isimler.Add("Veli");
            //isimler.Add("Eray");
            //isimler.Add("Selami");

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //ArrayList isimler2 = isimler.GetRange(2,3);                                              //// 2. index'den başlayıp 3 elemanı ekrana yazdırır
            //for (int i = 0; i < isimler2.Count; i++)
            //{
            //    LblBilgi.Text += isimler2[i].ToString() + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);

            //// ArryList Sınıfı \\\\
            //// ToArray Metodu   \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //ArrayList isimler = new ArrayList();
            //isimler.Add("Tolga");
            //isimler.Add("Ali");
            //isimler.Add("Baran");
            //isimler.Add("Berat");
            //isimler.Add("Berkay");
            //isimler.Add("Baran");
            //isimler.Add("Veli");
            //isimler.Add("Eray");
            //isimler.Add("Selami");

            //for (int i = 0; i < isimler.Count; i++)                                         //// Arryliste length değil count kullanılır eleman sayısı için
            //{
            //    LblBilgi.Text += isimler[i].ToString() + Environment.NewLine;
            //}

            //LblBilgi.Text += "********************" + Environment.NewLine;

            //string[] isimler2 =(string[]) isimler.ToArray(typeof(string));                             //// ismler kolleksiyonunu isimler2 dizisine çevirir
            //for (int i = 0; i < isimler2.Length; i++)
            //{
            //    LblBilgi.Text += isimler2[i].ToString() + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);


            ////// HashTable Objesi \\\\
            //////    Add Metodu    \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Hashtable Liste = new Hashtable();
            //Liste.Add(1,"Tolga");
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");

            //foreach (var isim in Liste.Keys)                                                                          //// İlk değere ulaşmak için 'Keys'
            //{
            //    LblBilgi.Text += "Anahtar: " + isim + Environment.NewLine;                                             
            //}

            //LblBilgi.Text += "*************************************" + Environment.NewLine;

            //foreach (var isim in Liste.Keys)                                                                          //// İlk değere ulaşmak için 'Keys'  
            //{
            //    LblBilgi.Text +=$"Anahtar: {isim}"+ Environment.NewLine;                                              
            //}

            //LblBilgi.Text += "_____________________________________" + Environment.NewLine;

            //foreach (var isim in Liste.Values)                                                                        //// İkinci değere ulaşmak için 'Values'
            //{
            //    LblBilgi.Text += "Değer: " + isim + Environment.NewLine;
            //}

            //LblBilgi.Text += "*************************************" + Environment.NewLine;

            //foreach (var isim in Liste.Values)                                                                        //// İkinci değere ulaşmak için 'Values'
            //{
            //    LblBilgi.Text += $"Değer: {isim}" + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //////    HashTable Objesi    \\\\
            ////// DictionaryEntry Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Hashtable Liste = new Hashtable();
            //Liste.Add(1, "Tolga");
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");

            //foreach (DictionaryEntry Bilgi in Liste)
            //{
            //    LblBilgi.Text += $"Anahtar: {Bilgi.Key} Değer: {Bilgi.Value}" + Environment.NewLine;                  //// İki değeride ekrana yazdırır
            //}

            //Controls.Add(LblBilgi);


            //// HashTable Objesi \\\\
            //// Contains Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Hashtable Liste = new Hashtable();
            //Liste.Add(1, "Tolga");
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");

            //if (Liste.Contains(2))                                                                                                  //// İlk değerde '2' numaralı eleman vermı diye bakar 
            //{
            //    LblBilgi.Text += $"Aradığınız 2 Numaralı Anahtar Mevcut {Liste.Contains(2)}"+Environment.NewLine;                   //// '2' eleman varsa true verir
            //}

            //else
            //{
            //    LblBilgi.Text += $"Aradığınız 2 Numaralı Anahtar Mevcut Değildir {Liste.Contains(2)}" + Environment.NewLine;         //// '2' eleman yoksa false verir    
            //}

            //Controls.Add(LblBilgi);


            ////// HashTable Objesi \\\\
            ////// Contains Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Hashtable Liste = new Hashtable();
            //Liste.Add(1, "Tolga");
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");

            //if (Liste.ContainsValue("Tolga"))                                                                                                         //// İkinci değerde 'Tolga' numaralı eleman vermı diye bakar 
            //{
            //    LblBilgi.Text += $"Aradığınız Tolga Numaralı Anahtar Mevcut {Liste.ContainsValue("Tolga")}" + Environment.NewLine;                    //// 'Tolga' eleman varsa true verir
            //}

            //else
            //{
            //    LblBilgi.Text += $"Aradığınız Tolga Numaralı Anahtar Mevcut Değildir {Liste.ContainsValue("Tolga")}" + Environment.NewLine;           //// 'Tolga' eleman yoksa false verir    
            //}

            //Controls.Add(LblBilgi);


            //// HashTable Objesi \\\\
            //// Remove Metodu  \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Hashtable Liste = new Hashtable();
            //Liste.Add(1, "Tolga");
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");

            //foreach (DictionaryEntry Bilgi in Liste)
            //{
            //    LblBilgi.Text += $"Anahtar: {Bilgi.Key} Değer: {Bilgi.Value}" + Environment.NewLine;                  //// İki değeride ekrana yazdırır
            //}

            //LblBilgi.Text += "_____________________________________" + Environment.NewLine;

            //Liste.Remove(3);                                                                                          //// 3 numaralı key silinir

            //foreach (DictionaryEntry Bilgi in Liste)                                                                  
            //{
            //    LblBilgi.Text += $"Anahtar: {Bilgi.Key} Değer: {Bilgi.Value}" + Environment.NewLine;                  //// İki değeride ekrana yazdırır
            //}

            //Controls.Add(LblBilgi);


            ////// SortedList Objesi \\\\
            //////      1.Örnek       \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //SortedList Liste = new SortedList();
            //Liste.Add(1, "Tolga");                                                                              
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");
            //Liste.Add(5, "Baran");
            //foreach (DictionaryEntry Deger in Liste)
            //{
            //    LblBilgi.Text += $"Anahtar: {Deger.Key} Değer: {Deger.Value}"+Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);

            //// SortedList Objesi \\\\
            ////      2.Örnek       \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //SortedList Liste = new SortedList();
            //Liste.Add(1, "Tolga");
            //Liste.Add(2, "Ali");
            //Liste.Add(3, "Berat");
            //Liste.Add(4, "Berkay");
            //Liste.Add(5, "Baran");
            //for (int i = 1; i <= Liste.Count; i++)
            //{
            //    LblBilgi.Text += $"{Liste[i]}"+Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);



            ////***** Generic Kolleksiyonlar *****\\\\
            ////// List Objesi \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //// Listeleme
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "*****************************" + Environment.NewLine;

            //// AddRange 
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Liste.AddRange(Yeni);
            //foreach (string bilgi in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {bilgi}" + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);


            //// Find Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Liste.AddRange(Yeni);

            //LblBilgi.Text += Liste.Find(isim => isim == "Berat") + Environment.NewLine;                         //// Liste kolleksiyonunda 'Berat' Değeri varsa ekrana yazdırır

            //Controls.Add(LblBilgi);

            //// Remove Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Liste.AddRange(Yeni);

            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}
            //LblBilgi.Text += "******************************" + Environment.NewLine;
            //Liste.Remove("Berat");                                                                             //// Liste kolleksiyonundan 'Berat' değerini siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);

            //// RemoveAt Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Liste.AddRange(Yeni);

            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}
            //LblBilgi.Text += "******************************" + Environment.NewLine;
            //Liste.RemoveAt(2);                                                                             //// Liste kolleksiyonundan 2.index'i siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);


            ////// RemoveRange Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Yeni.Add("Baran");
            //Yeni.Add("Veli");
            //Yeni.Add("Hüseyin");
            //Yeni.Add("Selami");
            //Yeni.Add("Barış");
            //Yeni.Add("Yücel");
            //Liste.AddRange(Yeni);

            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}
            //LblBilgi.Text += "******************************" + Environment.NewLine;
            //Liste.RemoveRange(2,7);                                                                             //// Liste kolleksiyonunda 2.index'den itibaren 7 elemanı siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);

            //// RemoveAll Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Yeni.Add("Baran");
            //Yeni.Add("Veli");
            //Yeni.Add("Hüseyin");
            //Yeni.Add("Selami");
            //Yeni.Add("Barış");
            //Yeni.Add("Yücel");
            //Liste.AddRange(Yeni);

            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}
            //LblBilgi.Text += "******************************" + Environment.NewLine;

            //Liste.RemoveAll(isim=> isim.StartsWith("B"));                                                                             //// Liste kolleksiyonunda baş harfi'B' olan elemanları siler

            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "******************************" + Environment.NewLine;

            //Liste.RemoveAll(isim => isim.EndsWith("i"));                                                                             //// Liste kolleksiyonunda son harfi'i' olan elemanları siler

            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"{isim}" + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            //// Sort Metodu \\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //List<string> Liste = new List<string>();
            //Liste.Add("Tolga");
            //Liste.Add("Ali");
            //List<string> Yeni = new List<string>();
            //Yeni.Add("Berat");
            //Yeni.Add("Berkay");
            //Yeni.Add("Baran");
            //Yeni.Add("Veli");
            //Yeni.Add("Hüseyin");
            //Yeni.Add("Selami");
            //Yeni.Add("Barış");
            //Yeni.Add("Yücel");
            //Liste.AddRange(Yeni);

            ////Liste.Sort();                                                                               //// Alfanetik şekilde küçükten büyüğe sıralar
            //foreach (object isim in Liste)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}
            //LblBilgi.Text += "********************" + Environment.NewLine;

            //Liste.Reverse();                                                                            //// Kolleksiyonu ters çevirir
            //foreach (object isim in Liste)
            //{

            //    LblBilgi.Text += isim.ToString() + Environment.NewLine;
            //}

            //Controls.Add(LblBilgi);


            ////***** Stack *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Stack<string> Liste = new Stack<string>();
            //// Push  
            //Liste.Push("Tolga");                                                                    //// yeni eleman ekler en son eklenen eleman en üste gelir
            //Liste.Push("Ali");
            //Liste.Push("Berat");
            //Liste.Push("Berkay");
            //Liste.Push("Baran");
            //Liste.Push("Veli");
            //Liste.Push("Hüseyin");
            //Liste.Push("Selami");
            //Liste.Push("Barış");
            //Liste.Push("Yücel");
            //// Listeleme
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// pop Metodu
            //Liste.Pop();                                                                           //// en üsteki elemanı siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// ElementAt
            //// listeleme
            //for (int i = 0; i < Liste.Count; i++)
            //{
            //    LblBilgi.Text += $"İsim: {Liste.ElementAt(i)}" + Environment.NewLine;                   //// Tüm index'leri ekrana yazdırır
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// peek Metodu
            //LblBilgi.Text += Liste.Peek() + Environment.NewLine;                                      //// en üsteki elemanı ekrana yazdırır



            //Controls.Add(LblBilgi);


            ////***** Queue Objesi *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Queue < String > Liste= new Queue<String>();
            //// Enqueue  
            //Liste.Enqueue("Tolga");                                                                    //// yeni eleman ekler 
            //Liste.Enqueue("Ali");
            //Liste.Enqueue("Berat");
            //Liste.Enqueue("Berkay");
            //Liste.Enqueue("Baran");
            //Liste.Enqueue("Veli");
            //Liste.Enqueue("Hüseyin");
            //Liste.Enqueue("Selami");
            //Liste.Enqueue("Barış");
            //Liste.Enqueue("Yücel");

            //// Listeleme
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            ////Dequeue
            //Liste.Dequeue();
            //foreach (string isim in Liste)                                                          /// En üsteki elemanı siler
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            ////peek
            //LblBilgi.Text += Liste.Peek() + Environment.NewLine;                                        //// En üstteki elemanı getirir




            //Controls.Add(LblBilgi);


            ////***** linkedList Objesi *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //LinkedList<String> Liste = new LinkedList<string>();
            //// AddFirst  
            //Liste.AddFirst("Tolga");                                                                    //// En üste yeni eleman ekler 
            //Liste.AddFirst("Ali");
            //// AddLast
            //Liste.AddLast("Berat");                                                                     //// En sona yeni eleman ekler
            //Liste.AddLast("Berkay");
            //// AddBefore
            //Liste.AddBefore(Liste.Find("Berat"),"Baran");                                               //// Berat'dan önce Berkay'ı ekler
            //Liste.AddBefore(Liste.Find("Berkay"), "Veli");
            //// AddAfter
            //Liste.AddAfter(Liste.Find("Berkay"), "Hüseyin");                                            //// Berkay'dan sonra Hüseyin'i ekler
            //Liste.AddAfter(Liste.Find("Hüseyin"), "Selami");
            //Liste.AddLast("Barış");
            //Liste.AddLast("Yücel");

            //// Listeleme
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// First
            //LblBilgi.Text += Liste.First.Next.Value +Environment.NewLine;                               //// İlk elemandan sonraki elemanı getirir

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Last
            //LblBilgi.Text += Liste.Last.Previous.Value + Environment.NewLine;                               //// Son elemandan önceki elemanı getirir

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Remove
            //Liste.Remove("Berat");                                                                          //// Berat elemanını siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// RemoveFirste
            //Liste.RemoveFirst();                                                                          //// İlk elemanını siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}
            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Remove
            //Liste.RemoveLast();                                                                          //// Son elemanını siler
            //foreach (string isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}


            //Controls.Add(LblBilgi);


            ////***** Dictionary Objesi *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //Dictionary<int, string> Liste = new Dictionary<int, string>();
            //// Add 
            //Liste.Add(1,"Tolga");                                                                    //// Yeni eleman ekler 
            //Liste.Add(2,"Ali");
            //Liste.Add(3,"Berat");                                                                    
            //Liste.Add(4,"Berkay");
            //Liste.Add(5,"Baran");                                               
            //Liste.Add(6,"Veli");
            //Liste.Add(7,"Hüseyin");                                            
            //Liste.Add(8,"Selami");
            //Liste.Add(9,"Barış");
            //Liste.Add(10,"Yücel");

            //// Listeleme
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;                                 //// Hepsini listeler
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Listeleme
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"Sayı: {isim.Key} İsim: {isim.Value}" + Environment.NewLine;                 //// Öğeleri ayırıp listeler
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Remove
            //Liste.Remove(3);                                                                                    //// 3 Numaralı index'i siler
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;                                 
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;


            //Controls.Add(LblBilgi);



            ////***** SortedSet Objesi *****\\\\                                                //// Küçükten büyüğe doğru sılarlar

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //SortedSet<string> Liste = new SortedSet<string>();
            //// Add 
            //Liste.Add("Tolga");                                                                    //// Yeni eleman ekler 
            //Liste.Add("Ali");
            //Liste.Add("Berat");
            //Liste.Add("Berkay");
            //Liste.Add("Baran");
            //Liste.Add("Veli");
            //Liste.Add("Hüseyin");
            //Liste.Add("Selami");
            //Liste.Add("Barış");
            //Liste.Add("Yücel");

            //// Listeleme
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;                                 //// Hepsini listeler
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Remove
            //Liste.Remove("Berat");                                                                      //// Berat elemanını siler
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// RemoveWhere
            //Liste.RemoveWhere(item=> item.StartsWith("B"));                                                                      //// İlk Harfi 'B' olan elemanları siler
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;


            //Controls.Add(LblBilgi);


            ////***** HashSet Objesi *****\\\\

            //int X = 10, Y = 10;
            //Label LblBilgi = new Label();
            //LblBilgi.AutoSize = true;
            //LblBilgi.Location = new Point(X, Y);

            //HashSet<string> Liste = new HashSet<string>();
            //// Add 
            //Liste.Add("Tolga");                                                                    //// Yeni eleman ekler 
            //Liste.Add("Ali");
            //Liste.Add("Berat");
            //Liste.Add("Berkay");
            //Liste.Add("Baran");
            //Liste.Add("Veli");
            //Liste.Add("Hüseyin");
            //Liste.Add("Selami");
            //Liste.Add("Barış");
            //Liste.Add("Yücel");

            //// Listeleme
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;                                 //// Hepsini listeler
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// Remove
            //Liste.Remove("Berat");                                                                      //// Berat elemanını siler
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;

            //// RemoveWhere
            //Liste.RemoveWhere(item => item.StartsWith("B"));                                                                      //// İlk Harfi 'B' olan elemanları siler
            //foreach (var isim in Liste)
            //{
            //    LblBilgi.Text += $"İsim: {isim}" + Environment.NewLine;
            //}

            //LblBilgi.Text += "***************************************" + Environment.NewLine;


            //Controls.Add(LblBilgi);
























        }
    }
}
