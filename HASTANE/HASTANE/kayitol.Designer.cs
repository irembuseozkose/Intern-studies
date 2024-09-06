namespace HASTANE
{
    partial class kayitol
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
            this.kyt_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_tc = new System.Windows.Forms.TextBox();
            this.txtbox_isimsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cins_cmbox = new System.Windows.Forms.ComboBox();
            this.dogumgunu = new System.Windows.Forms.DateTimePicker();
            this.txtbox_sifre_hasta = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kyt_btn
            // 
            this.kyt_btn.Location = new System.Drawing.Point(426, 241);
            this.kyt_btn.Name = "kyt_btn";
            this.kyt_btn.Size = new System.Drawing.Size(75, 23);
            this.kyt_btn.TabIndex = 0;
            this.kyt_btn.Text = "Kayıt Ol";
            this.kyt_btn.UseVisualStyleBackColor = true;
            this.kyt_btn.Click += new System.EventHandler(this.kyt_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc Kimlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim Soyisim";
            // 
            // txtbox_tc
            // 
            this.txtbox_tc.Location = new System.Drawing.Point(301, 56);
            this.txtbox_tc.MaxLength = 11;
            this.txtbox_tc.Name = "txtbox_tc";
            this.txtbox_tc.Size = new System.Drawing.Size(172, 20);
            this.txtbox_tc.TabIndex = 3;
            // 
            // txtbox_isimsoyisim
            // 
            this.txtbox_isimsoyisim.Location = new System.Drawing.Point(301, 96);
            this.txtbox_isimsoyisim.MaxLength = 70;
            this.txtbox_isimsoyisim.Name = "txtbox_isimsoyisim";
            this.txtbox_isimsoyisim.Size = new System.Drawing.Size(172, 20);
            this.txtbox_isimsoyisim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doğum tarihi";
            // 
            // cins_cmbox
            // 
            this.cins_cmbox.FormattingEnabled = true;
            this.cins_cmbox.Location = new System.Drawing.Point(301, 179);
            this.cins_cmbox.Name = "cins_cmbox";
            this.cins_cmbox.Size = new System.Drawing.Size(34, 21);
            this.cins_cmbox.TabIndex = 8;
            // 
            // dogumgunu
            // 
            this.dogumgunu.Location = new System.Drawing.Point(301, 139);
            this.dogumgunu.Name = "dogumgunu";
            this.dogumgunu.Size = new System.Drawing.Size(200, 20);
            this.dogumgunu.TabIndex = 9;
            // 
            // txtbox_sifre_hasta
            // 
            this.txtbox_sifre_hasta.Location = new System.Drawing.Point(301, 215);
            this.txtbox_sifre_hasta.MaxLength = 10;
            this.txtbox_sifre_hasta.Name = "txtbox_sifre_hasta";
            this.txtbox_sifre_hasta.Size = new System.Drawing.Size(172, 20);
            this.txtbox_sifre_hasta.TabIndex = 11;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(220, 218);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(28, 13);
            this.sifre.TabIndex = 10;
            this.sifre.Text = "Şifre";
            this.sifre.Click += new System.EventHandler(this.Şifre_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Location = new System.Drawing.Point(223, 240);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnanasayfa.TabIndex = 12;
            this.btnanasayfa.Text = "AnaSayfa";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.txtbox_sifre_hasta);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.dogumgunu);
            this.Controls.Add(this.cins_cmbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_isimsoyisim);
            this.Controls.Add(this.txtbox_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kyt_btn);
            this.Name = "kayitol";
            this.Text = "kayitol";
            this.Load += new System.EventHandler(this.kayitol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kyt_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_tc;
        private System.Windows.Forms.TextBox txtbox_isimsoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cins_cmbox;
        private System.Windows.Forms.DateTimePicker dogumgunu;
        private System.Windows.Forms.TextBox txtbox_sifre_hasta;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Button btnanasayfa;
    }
}