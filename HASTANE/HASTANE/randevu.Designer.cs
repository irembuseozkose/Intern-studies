namespace HASTANE
{
    partial class randevu
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
            this.hastane_combo = new System.Windows.Forms.ComboBox();
            this.tarih_combo = new System.Windows.Forms.ComboBox();
            this.doktor_combo = new System.Windows.Forms.ComboBox();
            this.saat_combo = new System.Windows.Forms.ComboBox();
            this.brans_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_randevuonayla = new System.Windows.Forms.Button();
            this.anasayfabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hastane_combo
            // 
            this.hastane_combo.FormattingEnabled = true;
            this.hastane_combo.Location = new System.Drawing.Point(184, 27);
            this.hastane_combo.Name = "hastane_combo";
            this.hastane_combo.Size = new System.Drawing.Size(278, 21);
            this.hastane_combo.TabIndex = 0;
            this.hastane_combo.SelectedIndexChanged += new System.EventHandler(this.hastane_combo_SelectedIndexChanged);
            // 
            // tarih_combo
            // 
            this.tarih_combo.FormattingEnabled = true;
            this.tarih_combo.Location = new System.Drawing.Point(185, 176);
            this.tarih_combo.Name = "tarih_combo";
            this.tarih_combo.Size = new System.Drawing.Size(278, 21);
            this.tarih_combo.TabIndex = 1;
            this.tarih_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // doktor_combo
            // 
            this.doktor_combo.FormattingEnabled = true;
            this.doktor_combo.Location = new System.Drawing.Point(185, 122);
            this.doktor_combo.Name = "doktor_combo";
            this.doktor_combo.Size = new System.Drawing.Size(278, 21);
            this.doktor_combo.TabIndex = 2;
            this.doktor_combo.SelectedIndexChanged += new System.EventHandler(this.doktor_combo_SelectedIndexChanged);
            // 
            // saat_combo
            // 
            this.saat_combo.FormattingEnabled = true;
            this.saat_combo.Location = new System.Drawing.Point(185, 227);
            this.saat_combo.Name = "saat_combo";
            this.saat_combo.Size = new System.Drawing.Size(278, 21);
            this.saat_combo.TabIndex = 3;
            this.saat_combo.SelectedIndexChanged += new System.EventHandler(this.saat_combo_SelectedIndexChanged);
            // 
            // brans_combo
            // 
            this.brans_combo.FormattingEnabled = true;
            this.brans_combo.Location = new System.Drawing.Point(185, 70);
            this.brans_combo.Name = "brans_combo";
            this.brans_combo.Size = new System.Drawing.Size(278, 21);
            this.brans_combo.TabIndex = 4;
            this.brans_combo.SelectedIndexChanged += new System.EventHandler(this.brans_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "HASTANE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BRANŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DOKTOR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TARİH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SAAT";
            // 
            // btn_randevuonayla
            // 
            this.btn_randevuonayla.Location = new System.Drawing.Point(403, 261);
            this.btn_randevuonayla.Name = "btn_randevuonayla";
            this.btn_randevuonayla.Size = new System.Drawing.Size(59, 25);
            this.btn_randevuonayla.TabIndex = 10;
            this.btn_randevuonayla.Text = "ONAYLA";
            this.btn_randevuonayla.UseVisualStyleBackColor = true;
            this.btn_randevuonayla.Click += new System.EventHandler(this.btn_randevuonayla_Click);
            // 
            // anasayfabtn
            // 
            this.anasayfabtn.Location = new System.Drawing.Point(185, 261);
            this.anasayfabtn.Name = "anasayfabtn";
            this.anasayfabtn.Size = new System.Drawing.Size(75, 23);
            this.anasayfabtn.TabIndex = 11;
            this.anasayfabtn.Text = "Anasayfa";
            this.anasayfabtn.UseVisualStyleBackColor = true;
            this.anasayfabtn.Click += new System.EventHandler(this.anasayfabtn_Click);
            // 
            // randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anasayfabtn);
            this.Controls.Add(this.btn_randevuonayla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brans_combo);
            this.Controls.Add(this.saat_combo);
            this.Controls.Add(this.doktor_combo);
            this.Controls.Add(this.tarih_combo);
            this.Controls.Add(this.hastane_combo);
            this.Name = "randevu";
            this.Text = "randevu";
            this.Load += new System.EventHandler(this.randevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hastane_combo;
        private System.Windows.Forms.ComboBox tarih_combo;
        private System.Windows.Forms.ComboBox doktor_combo;
        private System.Windows.Forms.ComboBox saat_combo;
        private System.Windows.Forms.ComboBox brans_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_randevuonayla;
        private System.Windows.Forms.Button anasayfabtn;
    }
}