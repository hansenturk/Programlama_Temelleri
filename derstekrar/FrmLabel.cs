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
    public partial class FrmLabel : Form
    {
        public FrmLabel()
        {
            InitializeComponent();
        }

        private void FrmLabel_Load(object sender, EventArgs e)
        {
            Label LblAd = new Label();
            LblAd.AutoSize = true;
            LblAd.Location = new Point(40,9);
            LblAd.ForeColor = Color.Red;
            LblAd.Text = "Tolga";
            LblAd.Font= new Font("Calbire",12,FontStyle.Bold);
            Controls.Add(LblAd);
        }
    }
}
