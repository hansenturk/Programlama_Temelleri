using System;
using System.Collections;
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
    public partial class FrmVize2 : Form
    {
        public FrmVize2()
        {
            InitializeComponent();
            FormClosing += FrmVize2_FormClosing;
        }

        private void FrmVize2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "form2",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmVize2 Vize2 = new FrmVize2();
                Vize2.Close();
                FrmVize Vize = new FrmVize();
                Vize.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmVize2_Load(object sender, EventArgs e)
        {
            //3.soru 'a'
            ArrayList ilce = new ArrayList { "ahmetli", "akhisar", "alaşehir", "demirci" };

            foreach (string item in ilce)
            {
                Cmbİlce.Items.Add(item);
            }
            //3.soru 'b'
            btn.Text = "Hafta Gün Kontrol";
            btn.AutoSize = true;
            btn.Location = new Point(250, 80);
            this.Controls.Add(btn);
            btn.Click += Btn_Click;


            lbl.Location = new Point(250, 110);
            lbl.Text = "Gün";
            lbl.AutoSize = true;
            this.Controls.Add(lbl);


            txtbox.Location = new Point(250, 50);
            txtbox.AutoSize = true;
            this.Controls.Add(txtbox);

        }

        //3.soru 'b' devamı
        TextBox txtbox = new TextBox();
        Label lbl = new Label();
        Button btn = new Button();
        private void Btn_Click(object sender, EventArgs e)
        {
            int GunSayi;
            if (int.TryParse(txtbox.Text, out GunSayi))
            {
                switch (GunSayi)
                {
                    case 0:
                        lbl.Text = "Pazartesi";
                        break;
                    case 1:
                        lbl.Text = "Salı";
                        break;
                    case 2:
                        lbl.Text = "Çarşamba";
                        break;
                    case 3:
                        lbl.Text = "Perşembe";
                        break;
                    case 4:
                        lbl.Text = "Cuma";
                        break;
                    case 5:
                        lbl.Text = "Cumartesi";
                        break;
                    case 6:
                        lbl.Text = "Pazar";
                        break;
                    default:
                        MessageBox.Show("haftanın böyle bir günü yok");
                        break;
                }
            }
            else
            {
                MessageBox.Show("yanlış değer girdiniz");
            }
        }
        //3.soru 'c'
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = char.ToUpper(textBox1.Text[0]).ToString() + textBox1.Text.Substring(1);
                textBox1.SelectionStart = textBox1.TextLength;
            }
        }
        //3.soru 'd'
        private void BtnSayac_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 0; i--)
            {
                if (i == 6)
                {
                    continue;
                }
                LblSay.Text = LblSay.Text + "\n" + i;
            }
        }
        //3.soru 'e'
        private void BtnFax_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi, sonuc = 1;
                sayi = Convert.ToInt32(TxtFak.Text);
                for (int i = 1; i <= sayi; i++)
                {
                    sonuc *= i;
                }
                LblFak.Text = sonuc.ToString();
            }
            catch
            {

            }
        }
    }
}
