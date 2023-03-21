using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace derstekrar
{
    public partial class FrmButton : Form
    {
        public FrmButton()
        {
            InitializeComponent();
        }

        private void FrmButton_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Ad yazınız");
            }
            else if (textBox2.Text=="")
            {
                MessageBox.Show("Liütfen Soyad Yazınız");
            }
            else
            {
                textBox1.Text = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox1.Text);
                textBox2.Text = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox2.Text);
                textBox3.AppendText(textBox1.Text + " " + textBox2.Text + Environment.NewLine);
                textBox1.Text = "";
                textBox2.Text = null;

            }
        }
    }
}
