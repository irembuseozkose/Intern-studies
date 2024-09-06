namespace HASTANE
{
    partial class hastaTani
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
            this.cmb_hastaliklar = new System.Windows.Forms.ComboBox();
            this.btn_tanikoy = new System.Windows.Forms.Button();
            this.btn_tani_gerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tanilar = new System.Windows.Forms.ListBox();
            this.lbl_tckimlik = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_yas = new System.Windows.Forms.Label();
            this.lbl_cins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_hastaliklar
            // 
            this.cmb_hastaliklar.FormattingEnabled = true;
            this.cmb_hastaliklar.Location = new System.Drawing.Point(264, 33);
            this.cmb_hastaliklar.Name = "cmb_hastaliklar";
            this.cmb_hastaliklar.Size = new System.Drawing.Size(257, 21);
            this.cmb_hastaliklar.TabIndex = 0;
            this.cmb_hastaliklar.SelectedIndexChanged += new System.EventHandler(this.hastaliklar_SelectedIndexChanged);
            // 
            // btn_tanikoy
            // 
            this.btn_tanikoy.Location = new System.Drawing.Point(448, 72);
            this.btn_tanikoy.Name = "btn_tanikoy";
            this.btn_tanikoy.Size = new System.Drawing.Size(73, 23);
            this.btn_tanikoy.TabIndex = 1;
            this.btn_tanikoy.Text = "ONAYLA";
            this.btn_tanikoy.UseVisualStyleBackColor = true;
            this.btn_tanikoy.Click += new System.EventHandler(this.btn_tanikoy_Click);
            // 
            // btn_tani_gerial
            // 
            this.btn_tani_gerial.Location = new System.Drawing.Point(264, 72);
            this.btn_tani_gerial.Name = "btn_tani_gerial";
            this.btn_tani_gerial.Size = new System.Drawing.Size(73, 23);
            this.btn_tani_gerial.TabIndex = 2;
            this.btn_tani_gerial.Text = "GERİ AL";
            this.btn_tani_gerial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TANI KOY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC Kimlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İsim Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum günü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cinsiyet";
            // 
            // Tanilar
            // 
            this.Tanilar.FormattingEnabled = true;
            this.Tanilar.Location = new System.Drawing.Point(190, 222);
            this.Tanilar.Name = "Tanilar";
            this.Tanilar.Size = new System.Drawing.Size(331, 95);
            this.Tanilar.TabIndex = 9;
            // 
            // lbl_tckimlik
            // 
            this.lbl_tckimlik.AutoSize = true;
            this.lbl_tckimlik.Location = new System.Drawing.Point(244, 112);
            this.lbl_tckimlik.Name = "lbl_tckimlik";
            this.lbl_tckimlik.Size = new System.Drawing.Size(0, 13);
            this.lbl_tckimlik.TabIndex = 10;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(256, 142);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(0, 13);
            this.lbl_isim.TabIndex = 11;
            // 
            // lbl_yas
            // 
            this.lbl_yas.AutoSize = true;
            this.lbl_yas.Location = new System.Drawing.Point(221, 172);
            this.lbl_yas.Name = "lbl_yas";
            this.lbl_yas.Size = new System.Drawing.Size(0, 13);
            this.lbl_yas.TabIndex = 13;
            // 
            // lbl_cins
            // 
            this.lbl_cins.AutoSize = true;
            this.lbl_cins.Location = new System.Drawing.Point(236, 197);
            this.lbl_cins.Name = "lbl_cins";
            this.lbl_cins.Size = new System.Drawing.Size(0, 13);
            this.lbl_cins.TabIndex = 14;
            // 
            // hastaTani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cins);
            this.Controls.Add(this.lbl_yas);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_tckimlik);
            this.Controls.Add(this.Tanilar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tani_gerial);
            this.Controls.Add(this.btn_tanikoy);
            this.Controls.Add(this.cmb_hastaliklar);
            this.Name = "hastaTani";
            this.Text = "hastaTani";
            this.Load += new System.EventHandler(this.hastaTani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_hastaliklar;
        private System.Windows.Forms.Button btn_tanikoy;
        private System.Windows.Forms.Button btn_tani_gerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Tanilar;
        private System.Windows.Forms.Label lbl_tckimlik;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_yas;
        private System.Windows.Forms.Label lbl_cins;
    }
}