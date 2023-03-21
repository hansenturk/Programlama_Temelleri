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
    public partial class FrmKontroller : Form
    {
        public FrmKontroller()
        {
            InitializeComponent();
        }

        private void FrmKontroller_Load(object sender, EventArgs e)
        {
            //// Kodla Button oluşturma \\\\

            //Button Btn = new Button();
            //Btn.Size = new Size(150,150);
            //Btn.Location = new Point(111,46);
            //Btn.Text = "button2";

            //Controls.Add(Btn);
            
        }

        FrmDeneme deneme = new FrmDeneme();
        private void BtnGoster_Click(object sender, EventArgs e)
        {
            deneme.Show();
        }
        private void BtnGizle_Click(object sender, EventArgs e)
        {

            deneme.Hide();
        }

        private void BtnArkayaGonder_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void BtnOneGonder_Click(object sender, EventArgs e)
        {
            deneme.BringToFront();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Tuşuna Basıldı");
        }

        private void BtnEsc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc Tuşuna Basıldı");
        }
    }
}
