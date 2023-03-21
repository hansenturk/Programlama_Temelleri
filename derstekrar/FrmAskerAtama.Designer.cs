
namespace derstekrar
{
    partial class FrmAskerAtama
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
            this.AskerAdları = new System.Windows.Forms.ListBox();
            this.Birlikler = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.BtnAskerEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AskerAdları
            // 
            this.AskerAdları.FormattingEnabled = true;
            this.AskerAdları.Location = new System.Drawing.Point(53, 46);
            this.AskerAdları.Name = "AskerAdları";
            this.AskerAdları.Size = new System.Drawing.Size(176, 199);
            this.AskerAdları.TabIndex = 0;
            // 
            // Birlikler
            // 
            this.Birlikler.FormattingEnabled = true;
            this.Birlikler.Location = new System.Drawing.Point(250, 46);
            this.Birlikler.Name = "Birlikler";
            this.Birlikler.Size = new System.Drawing.Size(159, 21);
            this.Birlikler.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(471, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(190, 186);
            this.treeView1.TabIndex = 2;
            // 
            // BtnAskerEkle
            // 
            this.BtnAskerEkle.Location = new System.Drawing.Point(274, 150);
            this.BtnAskerEkle.Name = "BtnAskerEkle";
            this.BtnAskerEkle.Size = new System.Drawing.Size(102, 26);
            this.BtnAskerEkle.TabIndex = 3;
            this.BtnAskerEkle.Text = "Asker Ekle";
            this.BtnAskerEkle.UseVisualStyleBackColor = true;
            this.BtnAskerEkle.Click += new System.EventHandler(this.BtnAskerEkle_Click);
            // 
            // FrmAskerAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAskerEkle);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Birlikler);
            this.Controls.Add(this.AskerAdları);
            this.Name = "FrmAskerAtama";
            this.Text = "FrmAskerAtama";
            this.Load += new System.EventHandler(this.FrmAskerAtama_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AskerAdları;
        private System.Windows.Forms.ComboBox Birlikler;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button BtnAskerEkle;
    }
}