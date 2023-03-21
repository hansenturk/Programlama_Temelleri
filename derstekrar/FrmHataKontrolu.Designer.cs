
namespace derstekrar
{
    partial class FrmHataKontrolu
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
            this.SuspendLayout();
            // 
            // BtnKontrol
            // 
            this.BtnKontrol.Location = new System.Drawing.Point(326, 192);
            this.BtnKontrol.Name = "BtnKontrol";
            this.BtnKontrol.Size = new System.Drawing.Size(75, 23);
            this.BtnKontrol.TabIndex = 0;
            this.BtnKontrol.Text = "Kontrol";
            this.BtnKontrol.UseVisualStyleBackColor = true;
            this.BtnKontrol.Click += new System.EventHandler(this.BtnKontrol_Click);
            // 
            // FrmHataKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnKontrol);
            this.Name = "FrmHataKontrolu";
            this.Text = "Hata Kontrol Formu";
            this.Load += new System.EventHandler(this.FrmHataKontrolu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKontrol;
    }
}