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
    public partial class FrmRadioButton : Form
    {
        public FrmRadioButton()
        {
            InitializeComponent();
        }

        private void FrmRadioButton_Load(object sender, EventArgs e)
        {
            string[] Diller = { "C#", "VB.net", "C", "C++", "Java", "Python", "Ruby" };
            int Y = 12;
            foreach (var item in Diller)
            {
                RadioButton Rdb = new RadioButton();
                Rdb.Text = item;
                Rdb.AutoSize = true;
                Rdb.Location = new Point(12, Y);
                Y += 34;
                Controls.Add(Rdb);
                if (item == "Ruby")
                {
                    Button BtnKontrol = new Button();
                    BtnKontrol.Location = new Point(12, Y);
                    BtnKontrol.Click += BtnKontrol_Click;
                    BtnKontrol.Text = "kontrol";
                    Controls.Add(BtnKontrol);
                    // Label
                    Label LblBilgi = new Label();
                    LblBilgi.AutoSize = true;
                    LblBilgi.Location = new Point(12, Y + 34);
                    LblBilgi.Text = "";
                    Controls.Add(LblBilgi);
                }

            }
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            string Dil = null;
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label LblBilgi = (Label)(control);

                    if (Dil == null)
                    {
                        LblBilgi.Text = "Lütfen Seçim Yapınız...";
                    }

                    else
                    {
                        LblBilgi.Text = "En Sevdiğiniz Yazılım Dili:  " + Dil;
                    }
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton Rdb = (RadioButton)(control);
                    if (Rdb.Checked)
                    {
                        Dil = Rdb.Text;
                    }
                }

            }
        }
    }
}
