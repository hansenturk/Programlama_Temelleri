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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView DersBilgisi = new TreeView();
            TreeNode AltKonu = new TreeNode("Diğer Kontroller");
            TreeNode Odev = new TreeNode("Ödevler");
            TreeNode Sınav = new TreeNode("Sınavlar");
            TreeNode SınavDeneme = new TreeNode("Sınav Hazırlık");
            DersBilgisi.Width = 400;
            DersBilgisi.Height = 500;
            DersBilgisi.BackColor = Color.Gray;
            TreeNode Konular1 = new TreeNode("Görsel Programlama 1 Konular ");
            TreeNode Konular2 = new TreeNode("Görsel Programlama 2 Konular ");
            Konular1.Nodes.Add("Degiskenler", "Değişkenler");
            Konular1.Nodes.Add("Operatorler", "Operatöler");
            Konular1.Nodes.Add("KontrolYapilari", "Kontrol Yapıları");
            Konular1.Nodes.Add("Donguler", "Döngüler");
            Konular1.Nodes.Add("Diziler", "Diziler");
            Konular1.Nodes.Add("Kolleksiyonlar", "Kolleksiyonlar");
            Konular1.Nodes.Add("HataKontrolu", "Hata Kontrolü");
            Konular1.Nodes.Add("FormKontrolleri", "Form Kontrolleri");
            AltKonu.Nodes.Add("LabelKontrolu","Label Kontrolü");
            AltKonu.Nodes.Add("LinkLabel", "link Label");
            AltKonu.Nodes.Add("TextBox", "Text Box Kontrolü");
            AltKonu.Nodes.Add("Button", "Buton Kontrolü");
            AltKonu.Nodes.Add("ComboBox", "Combo Box Kontrolü");
            AltKonu.Nodes.Add("ListBox", "List Box Kontrolü");
            AltKonu.Nodes.Add("TreeView", "Tree View");
            AltKonu.Nodes.Add("RadioButton", "Radio Buton Köntrolü");
            AltKonu.Nodes.Add("GroupBox", "Group Box Köntrolü");
            AltKonu.Nodes.Add("Timer", "Timer Köntrolü");
            Odev.Nodes.Add("SifreTahmin", "Şifre Tahmin");
            Odev.Nodes.Add("AskerAtama", "Asker Atama Otomasyonu");
            Sınav.Nodes.Add("Vize", "Vize");
            Sınav.Nodes.Add("Final", "Final");
            SınavDeneme.Nodes.Add("Deneme1", "Deneme 1");
            SınavDeneme.Nodes.Add("Deneme2", "Deneme 2");
            SınavDeneme.Nodes.Add("Deneme3", "Deneme 3");
            Konular1.Nodes.Add(AltKonu);
            Konular1.Nodes.Add(Odev);
            Konular1.Nodes.Add(Sınav);
            Konular1.Nodes.Add(SınavDeneme);
            DersBilgisi.Nodes.Add(Konular1);
            DersBilgisi.Nodes.Add(Konular2);
            DersBilgisi.ExpandAll();
            DersBilgisi.NodeMouseClick += DersBilgisi_NodeMouseClick;
            Controls.Add(DersBilgisi);
        }

        private void DersBilgisi_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Degiskenler":
                    FrmDegiskenler DegiskenFormu = new FrmDegiskenler();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    DegiskenFormu.ShowDialog();
                    break;

                case "Operatorler":
                    FrmOperatorler OperatorFormu = new FrmOperatorler();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    OperatorFormu.ShowDialog();
                    break;
                case "KontrolYapilari":
                    FrmKontrolYapilari KontrolFormu = new FrmKontrolYapilari();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    KontrolFormu.ShowDialog();
                    break;
                case "Donguler":
                    FrmDonguler DongulerFormu = new FrmDonguler();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    DongulerFormu.ShowDialog();
                    break;
                case "Diziler":
                    FrmDiziler DizilerFormu = new FrmDiziler();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    DizilerFormu.ShowDialog();
                    break;
                case "Kolleksiyonlar":
                    FrmKolleksiyonlar KolleksiyonlarFormu = new FrmKolleksiyonlar();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    KolleksiyonlarFormu.ShowDialog();
                    break;
                case "HataKontrolu":
                    FrmHataKontrolu HataKontroluFormu = new FrmHataKontrolu();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    HataKontroluFormu.ShowDialog();
                    break;
                case "FormKontrolleri":
                    FrmKontroller KontrollerFormu = new FrmKontroller();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    KontrollerFormu.ShowDialog();
                    break;
                case "LabelKontrolu":
                    FrmLabel LabelFormu = new FrmLabel();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    LabelFormu.ShowDialog();
                    break;
                case "LinkLabel":
                    FrmLinkLabel LinkLabelFormu = new FrmLinkLabel();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    LinkLabelFormu.ShowDialog();
                    break;
                case "TextBox":
                    FrmTextBox TextBoxFormu = new FrmTextBox();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    TextBoxFormu.ShowDialog();
                    break;
                case "Button":
                    FrmButton ButtonFormu = new FrmButton();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    ButtonFormu.ShowDialog();
                    break;
                case "ComboBox":
                    FrmComboBox ComboBoxFormu = new FrmComboBox();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    ComboBoxFormu.ShowDialog();
                    break;
                case "ListBox":
                    FrmListBox ListboxFormu = new FrmListBox();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    ListboxFormu.ShowDialog();
                    break;
                case "TreeView":
                    FrmTreeView TreeViewFormu = new FrmTreeView();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    TreeViewFormu.ShowDialog();
                    break;
                case "RadioButton":
                    FrmRadioButton RadioButtonFormu = new FrmRadioButton();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    RadioButtonFormu.ShowDialog();
                    break;
                    case "GroupBox":
                    FrmGroupBox GroupBoxFormu = new FrmGroupBox();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    GroupBoxFormu.ShowDialog();
                    break;
                case "Timer":
                    FrmTimer TimerFormu = new FrmTimer();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    TimerFormu.ShowDialog();
                    break;
                case "SifreTahmin":
                    FrmSifretahmin SifreTahminFormu = new FrmSifretahmin();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    SifreTahminFormu.ShowDialog();
                    break;
                case "AskerAtama":
                    FrmAskerAtama AskerAtamaFormu = new FrmAskerAtama();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    AskerAtamaFormu.ShowDialog();
                    break;
                case "Vize":
                    FrmVize VizeFormu = new FrmVize();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    VizeFormu.ShowDialog();
                    break;
                case "Deneme1":
                    FrmSınavDeneme1 SınavDeneme1Formu = new FrmSınavDeneme1();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    SınavDeneme1Formu.ShowDialog();
                    break;
                case "Deneme2":
                    FrmSınavDeneme2 SınavDeneme2Formu = new FrmSınavDeneme2();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    SınavDeneme2Formu.ShowDialog();
                    break;
                case "Deneme3":
                    FrmSınavDeneme3 SınavDeneme3Formu = new FrmSınavDeneme3();
                    //DegiskenlerFormu.Show(); //Form açılır fakat ana form hala tıklanabilir olur
                    SınavDeneme3Formu.ShowDialog();
                    break;


            }
        }
    }
}
