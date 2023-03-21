
namespace derstekrar
{
    partial class FrmOperatorler
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
            this.LblBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKontrol
            // 
            this.BtnKontrol.BackColor = System.Drawing.Color.Gray;
            this.BtnKontrol.FlatAppearance.BorderSize = 9;
            this.BtnKontrol.Location = new System.Drawing.Point(212, 151);
            this.BtnKontrol.Name = "BtnKontrol";
            this.BtnKontrol.Size = new System.Drawing.Size(75, 23);
            this.BtnKontrol.TabIndex = 0;
            this.BtnKontrol.Text = "Kontrol";
            this.BtnKontrol.UseVisualStyleBackColor = false;
            this.BtnKontrol.Click += new System.EventHandler(this.BtnKontrol_Click);
            // 
            // LblBilgi
            // 
            this.LblBilgi.AutoSize = true;
            this.LblBilgi.Location = new System.Drawing.Point(209, 106);
            this.LblBilgi.Name = "LblBilgi";
            this.LblBilgi.Size = new System.Drawing.Size(35, 13);
            this.LblBilgi.TabIndex = 1;
            this.LblBilgi.Text = "label1";
            // 
            // FrmOperatorler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBilgi);
            this.Controls.Add(this.BtnKontrol);
            this.Name = "FrmOperatorler";
            this.Text = "Operatörler Forumu";
            this.Load += new System.EventHandler(this.FrmOperatorler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKontrol;
        private System.Windows.Forms.Label LblBilgi;
    }
}