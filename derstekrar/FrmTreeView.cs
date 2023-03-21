using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace derstekrar
{
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }
        TreeView treeView2;
        TextBox textbox2;
        Button button2;
        Button button3;
        TextBox textbox3;
        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Klasör Listesi");                                  // TreeView e eleman ekler
            treeView2 = new TreeView();
            treeView2.Location = new Point(341,38);
            treeView2.Size = new Size(265,257);
            treeView2.Nodes.Add("Klasör Listesi");
            treeView2.NodeMouseClick += TreeView2_NodeMouseClick;
            Controls.Add(treeView2);
            textbox2 = new TextBox();
            textbox2.Location = new Point(341, 12);
            textbox2.Size = new Size(265, 20);
            Controls.Add(textbox2);
            button2 = new Button();
            button2.Location = new Point(341, 301);
            button2.Size = new Size(150, 27);
            button2.Click += Button2_Click;
            button2.Text = "Listele";
            Controls.Add(button2);
            // Soyağacı
            button3 = new Button();
            button3.Location = new Point(12, 630);
            button3.Size = new Size(150, 27);
            button3.Text = "Oluştur";
            button3.Click += Button3_Click;
            Controls.Add(button3);
            treeView3 = new TreeView();
            treeView3.Location = new Point(12, 367);
            treeView3.Size = new Size(265, 257);
            Controls.Add(treeView3);
            textbox3 = new TextBox();
            textbox3.Location = new Point(12, 341);
            textbox3.Size = new Size(265, 20);
            Controls.Add(textbox3);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //treeView3.Nodes[0].Text = textbox3.Text;
            //TreeNode Anadugum = treeView3.Nodes[0];
            //string[] Cocuklar = { "Ali", "Feyzullah", "Hanefi", "Recep", "Şaban" };
            //string[] Torunlar = { "Mecit", "İbrahim", "Abdullah", "Erkan", "Rıza" };
            //foreach (var Cocuk in Cocuklar)
            //{
            //    TreeNode CocukNode = new TreeNode(Cocuk);
            //    TreeNode TorunDugum;
            //    foreach (var Torun in Torunlar)
            //    {
            //        TorunDugum = new TreeNode(Torun);
            //        Anadugum.Nodes.Add(TorunDugum);

            //    }
                
            //}
            //treeView3.ExpandAll();
        }

        private void TreeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textbox2.Text = e.Node.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            treeView2.Nodes[0].Text = textbox2.Text;
            TreeNode AnaDugum = treeView2.Nodes[0];
            AnaDugum.Nodes.Clear();
            if (Directory.Exists(textbox2.Text))
            {
                string[] Klasorler = Directory.GetDirectories(textbox2.Text);
                foreach (string Klasor in Klasorler)
                {
                    TreeNode Cocukdugum = new TreeNode(Klasor);
                    AnaDugum.Nodes.Add(Cocukdugum);

                }
                treeView2.ExpandAll();
            }
            else
            {
                MessageBox.Show("Girdiğiniz adreste klasör mevcut değil");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Text = textBox1.Text;
            TreeNode AnaDugum = treeView1.Nodes[0];
            AnaDugum.Nodes.Clear();
            if (Directory.Exists(textBox1.Text))
            {
                string[] Klasorler = Directory.GetDirectories(textBox1.Text);
                foreach (string Klasor in Klasorler)
                {
                    TreeNode Cocukdugum = new TreeNode(Klasor);
                    AnaDugum.Nodes.Add(Cocukdugum);

                }
                treeView1.ExpandAll();
            }
            else
            {
                MessageBox.Show("Girdiğiniz adreste klasör mevcut değil");
            }
           
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Text = e.Node.Text;
        }
    }
}
