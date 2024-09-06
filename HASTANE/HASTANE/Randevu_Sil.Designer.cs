namespace HASTANE
{
    partial class Randevu_Sil
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
            this.cmbox_gelecekrandevu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbox_gelecekrandevu
            // 
            this.cmbox_gelecekrandevu.FormattingEnabled = true;
            this.cmbox_gelecekrandevu.Location = new System.Drawing.Point(195, 139);
            this.cmbox_gelecekrandevu.Name = "cmbox_gelecekrandevu";
            this.cmbox_gelecekrandevu.Size = new System.Drawing.Size(379, 21);
            this.cmbox_gelecekrandevu.TabIndex = 0;
            this.cmbox_gelecekrandevu.SelectedIndexChanged += new System.EventHandler(this.cmbox_gelecekrandevu_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Randevuyu silmek için seçiniz:";
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Location = new System.Drawing.Point(195, 191);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnanasayfa.TabIndex = 3;
            this.btnanasayfa.Text = "ANASAYFA";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // Randevu_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbox_gelecekrandevu);
            this.Name = "Randevu_Sil";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Randevu_Sil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbox_gelecekrandevu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnanasayfa;
    }
}