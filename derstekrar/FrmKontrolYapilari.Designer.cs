
namespace derstekrar
{
    partial class FrmKontrolYapilari
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
            this.BtnKontrol = new System.Windows.Forms.Button();
            this.TxtBilgi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnKontrol
            // 
            this.BtnKontrol.Location = new System.Drawing.Point(200, 199);
            this.BtnKontrol.Name = "BtnKontrol";
            this.BtnKontrol.Size = new System.Drawing.Size(161, 27);
            this.BtnKontrol.TabIndex = 0;
            this.BtnKontrol.Text = "Kontrol";
            this.BtnKontrol.UseVisualStyleBackColor = true;
            this.BtnKontrol.Click += new System.EventHandler(this.BtnKontrol_Click);
            // 
            // TxtBilgi
            // 
            this.TxtBilgi.Location = new System.Drawing.Point(151, 149);
            this.TxtBilgi.Name = "TxtBilgi";
            this.TxtBilgi.Size = new System.Drawing.Size(260, 20);
            this.TxtBilgi.TabIndex = 1;
            // 
            // FrmKontrolYapilari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBilgi);
            this.Controls.Add(this.BtnKontrol);
            this.Name = "FrmKontrolYapilari";
            this.Text = "Kontrol Yapıları Formu";
            this.Load += new System.EventHandler(this.FrmKontrolYapilari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKontrol;
        private System.Windows.Forms.TextBox TxtBilgi;
    }
}