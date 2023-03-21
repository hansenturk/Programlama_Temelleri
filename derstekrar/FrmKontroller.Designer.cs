
namespace derstekrar
{
    partial class FrmKontroller
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
            this.BtnGizle = new System.Windows.Forms.Button();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.BtnArkayaGonder = new System.Windows.Forms.Button();
            this.BtnOneGonder = new System.Windows.Forms.Button();
            this.BtnEsc = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGizle
            // 
            this.BtnGizle.Location = new System.Drawing.Point(134, 180);
            this.BtnGizle.Name = "BtnGizle";
            this.BtnGizle.Size = new System.Drawing.Size(75, 23);
            this.BtnGizle.TabIndex = 0;
            this.BtnGizle.Text = "Gizle";
            this.BtnGizle.UseVisualStyleBackColor = true;
            this.BtnGizle.Click += new System.EventHandler(this.BtnGizle_Click);
            // 
            // BtnGoster
            // 
            this.BtnGoster.Location = new System.Drawing.Point(26, 180);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(75, 23);
            this.BtnGoster.TabIndex = 1;
            this.BtnGoster.Text = "Göster";
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // BtnArkayaGonder
            // 
            this.BtnArkayaGonder.Location = new System.Drawing.Point(268, 180);
            this.BtnArkayaGonder.Name = "BtnArkayaGonder";
            this.BtnArkayaGonder.Size = new System.Drawing.Size(111, 23);
            this.BtnArkayaGonder.TabIndex = 2;
            this.BtnArkayaGonder.Text = "Arkaya Gönder";
            this.BtnArkayaGonder.UseVisualStyleBackColor = true;
            this.BtnArkayaGonder.Click += new System.EventHandler(this.BtnArkayaGonder_Click);
            // 
            // BtnOneGonder
            // 
            this.BtnOneGonder.Location = new System.Drawing.Point(425, 180);
            this.BtnOneGonder.Name = "BtnOneGonder";
            this.BtnOneGonder.Size = new System.Drawing.Size(111, 23);
            this.BtnOneGonder.TabIndex = 3;
            this.BtnOneGonder.Text = "Öne Gönder";
            this.BtnOneGonder.UseVisualStyleBackColor = true;
            this.BtnOneGonder.Click += new System.EventHandler(this.BtnOneGonder_Click);
            // 
            // BtnEsc
            // 
            this.BtnEsc.Location = new System.Drawing.Point(134, 41);
            this.BtnEsc.Name = "BtnEsc";
            this.BtnEsc.Size = new System.Drawing.Size(75, 23);
            this.BtnEsc.TabIndex = 4;
            this.BtnEsc.Text = "Esc";
            this.BtnEsc.UseVisualStyleBackColor = true;
            this.BtnEsc.Click += new System.EventHandler(this.BtnEsc_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(26, 41);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 5;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // FrmKontroller
            // 
            this.AcceptButton = this.BtnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.BtnEsc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.BtnEsc);
            this.Controls.Add(this.BtnOneGonder);
            this.Controls.Add(this.BtnArkayaGonder);
            this.Controls.Add(this.BtnGoster);
            this.Controls.Add(this.BtnGizle);
            this.Name = "FrmKontroller";
            this.Text = "Kontroller Formu";
            this.Load += new System.EventHandler(this.FrmKontroller_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGizle;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Button BtnArkayaGonder;
        private System.Windows.Forms.Button BtnOneGonder;
        private System.Windows.Forms.Button BtnEsc;
        private System.Windows.Forms.Button BtnEnter;
    }
}