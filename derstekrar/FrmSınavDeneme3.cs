﻿using System;
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
    public partial class FrmSınavDeneme3 : Form
    {
        public FrmSınavDeneme3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                MessageBox.Show("cevabınız doğru");
            }
            else
            {
                MessageBox.Show("cevabınız yanlış");
            }
        }
    }
}
