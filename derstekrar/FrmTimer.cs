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
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {

        }
        string[] Diller = { "C#", "VB.net", "C", "C++", "Java", "Python", "Ruby" };
        int Y = 19;
        int sayac = 0;
        

        private void BtnKontrol1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Zamanlayici.Enabled = true;
            groupBox1.Controls.Clear();
        }

        private void Zamanlayici_Tick_1(object sender, EventArgs e)
        {
            RadioButton Rdb = new RadioButton();
            Rdb.Text = Diller[sayac];
            Rdb.AutoSize = true;
            Rdb.Location = new Point(6, Y);
            Y += 23;
            groupBox1.Controls.Add(Rdb);
            if (Diller[sayac] == "Ruby")
            {
                Button BtnKontrol1 = new Button();
                BtnKontrol1.Location = new Point(6, Y);
                BtnKontrol1.Click += BtnKontrol1_Click;
                BtnKontrol1.Text = "kontrol";
                groupBox1.Controls.Add(BtnKontrol1);

            }
            sayac++;
            if (sayac == Diller.Length - 1)
            {
                Zamanlayici.Enabled = false;
                sayac = 0;
                Y = 19;
                button1.Enabled = true;
            }
        }
    }
}
