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
    public partial class FrmGroupBox : Form
    {
        public FrmGroupBox()
        {
            InitializeComponent();
        }

        private void FrmGroupBox_Load(object sender, EventArgs e)
        {
            string[] Diller = { "C#", "VB.net", "C", "C++", "Java", "Python", "Ruby" };
            int Y = 19;
            foreach (var item in Diller)
            {
                RadioButton Rdb = new RadioButton();
                Rdb.Text = item;
                Rdb.AutoSize = true;
                Rdb.Location = new Point(6, Y);
                Y += 23;
                groupBox2.Controls.Add(Rdb);
                if (item == "Ruby")
                {
                    Button BtnKontrol1 = new Button();
                    BtnKontrol1.Location = new Point(6, Y);
                    BtnKontrol1.Click += BtnKontrol1_Click;
                    BtnKontrol1.Text = "kontrol";
                    groupBox2.Controls.Add(BtnKontrol1);

                }
            }
        }

        private void BtnKontrol1_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBox2.Controls)
            {

                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton Rdb = (RadioButton)(control);
                    if (Rdb.Checked)
                    {
                        MessageBox.Show("istenilen buton: " + Rdb.Text);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBox1.Controls)
            {

                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton Rdb = (RadioButton)(control);
                    if (Rdb.Checked)
                    {
                        MessageBox.Show("istenilen buton: " + Rdb.Text);
                    }
                }

            }
        }
    }
}
