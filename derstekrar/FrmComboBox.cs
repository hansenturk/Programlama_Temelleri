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
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void FrmComboBox_Load(object sender, EventArgs e)
        {
            string[] Isimler = {"Ali","Veli","Selami","Baran" };
            // Add Metodu
            comboBox1.Items.Add("Tolga");                                       // Tek bir eleman ekler 
            comboBox1.Items.Add(5);
            // AddRange Metodu
            comboBox1.Items.AddRange(Isimler);                                  //  önceden oluşturlumuş bir diziyi ekler
            // Count Metodu 
            //MessageBox.Show(comboBox1.Items.Count.ToString()+" eleman vardır");     // kaç eleman olduğunun söyler
            // Remove Metodu
            comboBox1.Items.Remove("Ali");                                          // Ali elemanını siler
            // RemoveAt Metodu
            comboBox1.Items.RemoveAt(3);                                            // 3. indexteki elemanı siler
            // Insert Metodu
            comboBox1.Items.Insert(2,"Berat");                                      // 2. indexe Berat elemanını ekler
            // Contains Metodu
            //bool Sonuc = comboBox1.Items.Contains("Veli");                          // Veli Değeri varsa true döner 
            //MessageBox.Show(Sonuc.ToString());
            // Celar Metodu
            //comboBox1.Items.Clear();                                               // Tüm elemanları siler    


        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            // SelectedIndex Metodu
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());                // Seçilen elemaın index numarasını verir
            // SelectedItem Metodu
            //MessageBox.Show(comboBox1.SelectedItem.ToString());                   // Seçilen elemanı ekran yazdırır
            Hashtable Liste = new Hashtable();
            Liste.Add(0,"Cem");
            Liste.Add(1,"Gül");
            Liste.Add(2,"Berkay");
            Liste.Add(3,"Barış");
            comboBox1.DataSource = new BindingSource(Liste, null);
            comboBox1.DisplayMember = "value";
            comboBox1.ValueMember = "key";

        }
    }
}
