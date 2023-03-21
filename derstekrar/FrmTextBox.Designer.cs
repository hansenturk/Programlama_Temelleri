
namespace derstekrar
{
    partial class FrmTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMetotUygulama = new System.Windows.Forms.TextBox();
            this.BtnKes = new System.Windows.Forms.Button();
            this.BtnKopyala = new System.Windows.Forms.Button();
            this.BtnYapistir = new System.Windows.Forms.Button();
            this.BtnGeriAl = new System.Windows.Forms.Button();
            this.BtnAltCizgi = new System.Windows.Forms.Button();
            this.BtnKalın = new System.Windows.Forms.Button();
            this.BtnItalik = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(107, 20);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAd.Size = new System.Drawing.Size(232, 20);
            this.TxtAd.TabIndex = 0;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soy Adınız:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(107, 44);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSoyad.Size = new System.Drawing.Size(232, 20);
            this.TxtSoyad.TabIndex = 2;
            this.TxtSoyad.MouseEnter += new System.EventHandler(this.TxtSoyad_MouseEnter);
            this.TxtSoyad.MouseLeave += new System.EventHandler(this.TxtSoyad_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresiniz:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(107, 68);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtAdres.Size = new System.Drawing.Size(232, 105);
            this.TxtAdres.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifreniz:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(108, 179);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSifre.Size = new System.Drawing.Size(232, 20);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.Enter += new System.EventHandler(this.TxtSifre_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Satır Bilgi Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtMetotUygulama
            // 
            this.TxtMetotUygulama.Location = new System.Drawing.Point(33, 423);
            this.TxtMetotUygulama.Multiline = true;
            this.TxtMetotUygulama.Name = "TxtMetotUygulama";
            this.TxtMetotUygulama.Size = new System.Drawing.Size(359, 169);
            this.TxtMetotUygulama.TabIndex = 9;
            this.TxtMetotUygulama.TextChanged += new System.EventHandler(this.TxtMetotUygulama_TextChanged);
            // 
            // BtnKes
            // 
            this.BtnKes.Location = new System.Drawing.Point(33, 616);
            this.BtnKes.Name = "BtnKes";
            this.BtnKes.Size = new System.Drawing.Size(75, 23);
            this.BtnKes.TabIndex = 10;
            this.BtnKes.Text = "Kes";
            this.BtnKes.UseVisualStyleBackColor = true;
            this.BtnKes.Click += new System.EventHandler(this.BtnKes_Click);
            // 
            // BtnKopyala
            // 
            this.BtnKopyala.Location = new System.Drawing.Point(131, 616);
            this.BtnKopyala.Name = "BtnKopyala";
            this.BtnKopyala.Size = new System.Drawing.Size(75, 23);
            this.BtnKopyala.TabIndex = 11;
            this.BtnKopyala.Text = "Kopyala";
            this.BtnKopyala.UseVisualStyleBackColor = true;
            this.BtnKopyala.Click += new System.EventHandler(this.BtnKopyala_Click);
            // 
            // BtnYapistir
            // 
            this.BtnYapistir.Location = new System.Drawing.Point(228, 616);
            this.BtnYapistir.Name = "BtnYapistir";
            this.BtnYapistir.Size = new System.Drawing.Size(75, 23);
            this.BtnYapistir.TabIndex = 12;
            this.BtnYapistir.Text = "Yapaıştır";
            this.BtnYapistir.UseVisualStyleBackColor = true;
            this.BtnYapistir.Click += new System.EventHandler(this.BtnYapistir_Click);
            // 
            // BtnGeriAl
            // 
            this.BtnGeriAl.Location = new System.Drawing.Point(317, 616);
            this.BtnGeriAl.Name = "BtnGeriAl";
            this.BtnGeriAl.Size = new System.Drawing.Size(75, 23);
            this.BtnGeriAl.TabIndex = 13;
            this.BtnGeriAl.Text = "Geri Al";
            this.BtnGeriAl.UseVisualStyleBackColor = true;
            this.BtnGeriAl.Click += new System.EventHandler(this.BtnGeriAl_Click);
            // 
            // BtnAltCizgi
            // 
            this.BtnAltCizgi.Location = new System.Drawing.Point(417, 435);
            this.BtnAltCizgi.Name = "BtnAltCizgi";
            this.BtnAltCizgi.Size = new System.Drawing.Size(75, 23);
            this.BtnAltCizgi.TabIndex = 14;
            this.BtnAltCizgi.Text = "Altı Çizgili";
            this.BtnAltCizgi.UseVisualStyleBackColor = true;
            this.BtnAltCizgi.Click += new System.EventHandler(this.BtnAltCizgi_Click);
            // 
            // BtnKalın
            // 
            this.BtnKalın.Location = new System.Drawing.Point(417, 494);
            this.BtnKalın.Name = "BtnKalın";
            this.BtnKalın.Size = new System.Drawing.Size(75, 23);
            this.BtnKalın.TabIndex = 15;
            this.BtnKalın.Text = "Kalın";
            this.BtnKalın.UseVisualStyleBackColor = true;
            this.BtnKalın.Click += new System.EventHandler(this.BtnKalın_Click);
            // 
            // BtnItalik
            // 
            this.BtnItalik.Location = new System.Drawing.Point(417, 553);
            this.BtnItalik.Name = "BtnItalik";
            this.BtnItalik.Size = new System.Drawing.Size(75, 23);
            this.BtnItalik.TabIndex = 16;
            this.BtnItalik.Text = "İtalik";
            this.BtnItalik.UseVisualStyleBackColor = true;
            this.BtnItalik.Click += new System.EventHandler(this.BtnItalik_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(125, 665);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(166, 29);
            this.BtnEkle.TabIndex = 17;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 779);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnItalik);
            this.Controls.Add(this.BtnKalın);
            this.Controls.Add(this.BtnAltCizgi);
            this.Controls.Add(this.BtnGeriAl);
            this.Controls.Add(this.BtnYapistir);
            this.Controls.Add(this.BtnKopyala);
            this.Controls.Add(this.BtnKes);
            this.Controls.Add(this.TxtMetotUygulama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAd);
            this.Name = "FrmTextBox";
            this.Text = "Text Box Formu";
            this.Load += new System.EventHandler(this.FrmTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMetotUygulama;
        private System.Windows.Forms.Button BtnKes;
        private System.Windows.Forms.Button BtnKopyala;
        private System.Windows.Forms.Button BtnYapistir;
        private System.Windows.Forms.Button BtnGeriAl;
        private System.Windows.Forms.Button BtnAltCizgi;
        private System.Windows.Forms.Button BtnKalın;
        private System.Windows.Forms.Button BtnItalik;
        private System.Windows.Forms.Button BtnEkle;
    }
}