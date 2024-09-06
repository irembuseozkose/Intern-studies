namespace HASTANE
{
    partial class Hasta_AnaSayfa
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
            this.btn_randevuOlustur = new System.Windows.Forms.Button();
            this.btn_randevuSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_randevuOlustur
            // 
            this.btn_randevuOlustur.Location = new System.Drawing.Point(287, 159);
            this.btn_randevuOlustur.Name = "btn_randevuOlustur";
            this.btn_randevuOlustur.Size = new System.Drawing.Size(206, 23);
            this.btn_randevuOlustur.TabIndex = 0;
            this.btn_randevuOlustur.Text = "RANDEVU OLUŞTUR";
            this.btn_randevuOlustur.UseVisualStyleBackColor = true;
            this.btn_randevuOlustur.Click += new System.EventHandler(this.btn_randevuOlustur_Click);
            // 
            // btn_randevuSil
            // 
            this.btn_randevuSil.Location = new System.Drawing.Point(287, 205);
            this.btn_randevuSil.Name = "btn_randevuSil";
            this.btn_randevuSil.Size = new System.Drawing.Size(206, 23);
            this.btn_randevuSil.TabIndex = 1;
            this.btn_randevuSil.Text = "RANDEVU SİL";
            this.btn_randevuSil.UseVisualStyleBackColor = true;
            this.btn_randevuSil.Click += new System.EventHandler(this.btn_randevuSil_Click);
            // 
            // Hasta_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_randevuSil);
            this.Controls.Add(this.btn_randevuOlustur);
            this.Name = "Hasta_AnaSayfa";
            this.Text = "Hasta_AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_randevuOlustur;
        private System.Windows.Forms.Button btn_randevuSil;
    }
}