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
    public partial class FrmSınavDeneme2 : Form
    {
        public FrmSınavDeneme2()
        {
            InitializeComponent();
        }
        
        private void FrmSınavDeneme2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ali");
            listBox1.Items.Add("Tolga");
            listBox1.Items.Add("Berat");
            listBox2.Items.Add("Berkay");
            listBox2.Items.Add("Baran");
            listBox2.Items.Add("Hüseyin");
            listBox2.Items.Add("Barış");
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count-1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }
    }
}
