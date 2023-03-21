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
    public partial class FrmSınavDeneme1 : Form
    {
        public FrmSınavDeneme1()
        {
            InitializeComponent();
        }

        List<string> AskerAdListe = new List<string>() { "Ahmet Veli", "Adem Kemal", "Hakkı Tufan", "Arda Gülmez", "Ali Güneş", "Veli Halil", "Kerem Soylu" };
        int sayac = 0;
        private void FrmSınavDeneme1_Load(object sender, EventArgs e)
        {
            
        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(AskerAdListe[sayac]);
            if (AskerAdListe[sayac] == "Ruby")
            {
               

            }
            sayac++;
            if (sayac == AskerAdListe.Count - 1)
            {
                Zamanlayici.Enabled = false;
                sayac = 0;
                
                button1.Enabled = true;
            }
        }

        private void BtnKontrol1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Zamanlayici.Enabled = true;
            treeView1.Controls.Clear();
        }
    }
}
