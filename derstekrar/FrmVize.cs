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
    public partial class FrmVize : Form
    {
        public FrmVize()
        {
            InitializeComponent();
            FormClosing += FrmVize_FormClosing;
        }

        private void FrmVize_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void FrmVize_Load(object sender, EventArgs e)
        {
            TxtSifre.UseSystemPasswordChar = true;
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string[] bilgi = new string[2] { "Tolga", "123456" };
            if (TxtAd.Text == bilgi[0] && TxtSifre.Text == bilgi[1])
            {
                MessageBox.Show("Giriş Başarılı");
                this.Hide();
                //Application.Exit();
                FrmVize2 Vize2 = new FrmVize2();
                Vize2.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }

        
    }
}
