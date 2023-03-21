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
    public partial class FrmAskerAtama : Form
    {
        public FrmAskerAtama()
        {
            InitializeComponent();
        }
        List<string> AskerAdListe = new List<string>() { "Ahmet Veli", "Adem Kemal", "Hakkı Tufan", "Arda Gülmez", "Ali Güneş", "Veli Halil", "Kerem Soylu" };
        List<string> AskerAdListe2 = new List<string>() { "Hasan Ali", "Ferman Güney", "Samet Güler", "Barış Keskin", "Tayfun Ay", "Eray Durmuş", "Atakan Güven" };
        List<string> AskeriBirlikListe = new List<string>() { "İstanbul Birliği", "Ankara Birliği", "İzmir Birliği", "Mersin Birliği" };
        private void FrmAskerAtama_Load(object sender, EventArgs e)
        {
            
            AskerAdListe.AddRange(AskerAdListe2);
            AskerAdları.SelectionMode = SelectionMode.MultiSimple;                          // ListBox'ta çoklu seçmeyi açar
            foreach (string isim in AskerAdListe)
            {
                AskerAdları.Items.Add(isim);
            }

            foreach (string birlik in AskeriBirlikListe)
            {
                Birlikler.Items.Add(birlik);
            }
        }

        private void BtnAskerEkle_Click(object sender, EventArgs e)
        {
            string a = Birlikler.SelectedItem.ToString();                                   // ComboBox'ta seçili olan elemanı srtinge çevirme

            if (treeView1.Nodes.ContainsKey(a)==false)                                      // Eğer daha önce böyle bir eleman eklenmedi ise 
            {
                treeView1.Nodes.Add(a, a);                                                  // Node olarak bunu ekle ve Key olarak string'i ata
            }
            int b = treeView1.Nodes.IndexOfKey(a);                                          // Eklenen Node'nin index Key'ini buluyor
            
            for (int i =AskerAdları.SelectedIndices.Count - 1; i >= 0; i--)                 
            {
                treeView1.Nodes[b].Nodes.Add(AskerAdları.SelectedItems[i].ToString());      // Bununan Key'e göre ekleme yapıyor

                AskerAdları.Items.RemoveAt(AskerAdları.SelectedIndices[i]);                 // Seçili elemanları siliyor

            }
            treeView1.ExpandAll();                                                          // Tüm Node'leri açar
        }
    }
}
