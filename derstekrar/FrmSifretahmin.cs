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
    public partial class FrmSifretahmin : Form
    {
        public FrmSifretahmin()
        {
            InitializeComponent();
        }
        int hak = 1;
        string sifre = ("Admin1234");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == sifre)
            {
                MessageBox.Show("Sifre Doğru");
                Application.Exit();
            }
            else if (hak == 1)
            {
                hak++;
                MessageBox.Show("Yanlış Sifre Lütfen Tekrar Deneyiniz Kalan Deneme Hakkınız:2");
            }
            else if (hak == 2)
            {
                hak++;
                MessageBox.Show("Yanlış Sifre Lütfen Tekrar Deneyiniz Kalan Deneme Hakkınız:1");
            }
            else if (hak == 3)
            {
                hak++;
                MessageBox.Show("Yanlış Sifre Girdiniz Hakkınız Kalmadı");
                Application.Exit();
            }
        }

        private void FrmSifretahmin_Load(object sender, EventArgs e)
        {

        }
    }
}
