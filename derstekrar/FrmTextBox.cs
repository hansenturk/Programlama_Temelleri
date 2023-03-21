using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace derstekrar
{
    public partial class FrmTextBox : Form
    {
        public FrmTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TxtAdres.Lines.Length; i++)
            {
                
                if (i==0)
                {
                    TxtAd.Text=TxtAdres.Lines[i];
                    continue;
                }
                if (i == 1)
                {
                    TxtSoyad.Text = TxtAdres.Lines[i];
                    continue;
                }
                if (i == 2)
                {
                    TxtSifre.Text = TxtAdres.Lines[i];
                    continue;
                }
               

            }

            char[] Ad = TxtAd.Text.ToCharArray();
            Array.Reverse(Ad);
            string TersAd = new string(Ad);
            TxtAd.Text = TersAd;

        }

        private void BtnKes_Click(object sender, EventArgs e)
        {
            if (TxtMetotUygulama.SelectionLength > 0)
            {
                TxtMetotUygulama.Cut();
            }
            else
            {
                MessageBox.Show("Lütfen Kutu İçerisindeki Yazıyı Seçiniz");
            }
        }

        private void BtnKopyala_Click(object sender, EventArgs e)
        {
            if (TxtMetotUygulama.SelectionLength > 0)
            {
                TxtMetotUygulama.Copy();
            }
            else
            {
                MessageBox.Show("Lütfen Kutu İçerisindeki Yazıyı Seçiniz");
            }
        }

        private void BtnYapistir_Click(object sender, EventArgs e)
        {
            
                TxtMetotUygulama.Paste();
            
        }

        private void BtnGeriAl_Click(object sender, EventArgs e)
        {
            
                TxtMetotUygulama.Undo();
            
        }

        private void BtnAltCizgi_Click(object sender, EventArgs e)
        {
            TxtMetotUygulama.Font = new Font(Font,FontStyle.Underline);
        }

        private void BtnKalın_Click(object sender, EventArgs e)
        {
            TxtMetotUygulama.Font = new Font(Font, FontStyle.Bold);
        }

        private void BtnItalik_Click(object sender, EventArgs e)
        {
            TxtMetotUygulama.Font = new Font(Font, FontStyle.Italic);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string AdSoyad = Environment.NewLine + TxtAd.Text + " " + TxtSoyad.Text ;
            TxtMetotUygulama.AppendText(AdSoyad);
        }

        private void TxtMetotUygulama_TextChanged(object sender, EventArgs e)
        {
            TxtMetotUygulama.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtMetotUygulama.Text);
            TxtMetotUygulama.Select(TxtMetotUygulama.Text.Length, 1);
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Yazı Değişti");
        }

        private void TxtSoyad_MouseEnter(object sender, EventArgs e)
        {
            TxtSoyad.BackColor = Color.Red;
        }

        private void TxtSoyad_MouseLeave(object sender, EventArgs e)
        {
            TxtSoyad.BackColor = DefaultBackColor;
        }

        private void TxtSifre_Enter(object sender, EventArgs e)
        {
            TxtSifre.BackColor = Color.LightBlue;
            TxtSifre.ForeColor = Color.White;
        }
        TextBox TxtTelefon;
        private void FrmTextBox_Load(object sender, EventArgs e)
        {
            Label LblTelefon = new Label();
            LblTelefon.Location = new Point(19,226);
            LblTelefon.AutoSize = true;
            LblTelefon.Text = "Telefon:";
            LblTelefon.Font = new Font("Microsoft Sans Serif", 12);

            TxtTelefon = new TextBox();
            TxtTelefon.Location = new Point(107,224);
            TxtTelefon.Size = new Size(232,20);

            TxtTelefon.Enter += TxtTelefon_Enter;
            TxtTelefon.Leave += TxtTelefon_Leave;
            TxtTelefon.TextChanged += TxtTelefon_TextChanged;



            Controls.Add(TxtTelefon);
            Controls.Add(LblTelefon);
        }

        private void TxtTelefon_TextChanged(object sender, EventArgs e)
        {
            TxtTelefon.Text= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtTelefon.Text);
            TxtTelefon.Select(TxtTelefon.Text.Length, 1);
        }

        private void TxtTelefon_Leave(object sender, EventArgs e)
        {
            TxtTelefon.BackColor = DefaultBackColor;
            TxtTelefon.ForeColor = DefaultForeColor;
        }

        private void TxtTelefon_Enter(object sender, EventArgs e)
        {
            TxtTelefon.BackColor = Color.Goldenrod;
            TxtTelefon.ForeColor = Color.White;
        }
    }
}
