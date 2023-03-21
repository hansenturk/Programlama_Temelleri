using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace derstekrar
{
    public partial class FrmLinkLabel : Form
    {
        public FrmLinkLabel()
        {
            InitializeComponent();
        }

        

        private void FrmLinkLabel_Load(object sender, EventArgs e)
        {
            LinkLabel LblUrl = new LinkLabel();
            LblUrl.AutoSize = true;
            LblUrl.Location = new Point(200, 29);
            LblUrl.Text = "Akhisar MYO";
            LblUrl.Links.Add(0, LblUrl.Text.Length, "https://akhisarmyo.mcbu.edu.tr/");
            LblUrl.LinkClicked += LblUrl_LinkClicked;
            Controls.Add(LblUrl);
        }

        private void LblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
