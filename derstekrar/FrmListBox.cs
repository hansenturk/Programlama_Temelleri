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
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }
        SortedList<int, string> Liste;
        private void FrmListBox_Load(object sender, EventArgs e)
        {
            // Add Metodu
            listBox1.Items.Add("Tolga");                                            // Listboxa Eleman ekler
            listBox1.Items.Add("Baran");
            listBox1.Items.Add("Berat");
            listBox1.Items.Add("Berkay");
            // SelectionMode Metodu
            listBox1.SelectionMode = SelectionMode.MultiSimple;                     // Listbox ta çoklu eleman seçmeyi açar
            // AddRange Metodu
            string[] isimler = { "Barış", "Kemal", "Hüseyin" };
            listBox1.Items.AddRange(isimler);                                       // listboxa dizinin elemanlarını ekler
            // Insert Metodu
            listBox1.Items.Insert(2,"Hasan");                                       // Listboxa 2. indexe 'Hasan' elemanını ekler
            // Remove Metodu
            listBox1.Items.Remove("selami");                                        // Listboxtan 'selami' elemanını siler
            // RemoveAt Metodu
            listBox1.Items.RemoveAt(4);                                             // Listboxtan 4. indexi siler

            Liste = new SortedList<int, string>();
            Liste.Add(1,"Tolga");
            Liste.Add(2,"Ali");
            Liste.Add(3,"Baran");
            Liste.Add(4,"Berat");
            listBox2.DataSource = new BindingSource(Liste, null);
            listBox2.ValueMember = "Key";
            listBox2.DisplayMember = "Value";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox2.SelectedValue.ToString());                  // Seçilen elemanın index numarasını verir
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int Key = int.Parse(listBox2.SelectedValue.ToString());
            Liste.Remove(Key);
            listBox2.DataSource = new BindingSource(Liste, null);
            listBox2.ValueMember = "Key";
            listBox2.DisplayMember = "Value";
        }
    }
}
