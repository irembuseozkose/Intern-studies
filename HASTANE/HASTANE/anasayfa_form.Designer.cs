namespace HASTANE
{
    partial class anasayfa_form
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_hastakyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(224, 94);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(161, 30);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "GIRIS";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_hastakyt
            // 
            this.btn_hastakyt.Location = new System.Drawing.Point(224, 142);
            this.btn_hastakyt.Name = "btn_hastakyt";
            this.btn_hastakyt.Size = new System.Drawing.Size(161, 30);
            this.btn_hastakyt.TabIndex = 1;
            this.btn_hastakyt.Text = "HASTA KAYIT";
            this.btn_hastakyt.UseVisualStyleBackColor = true;
            this.btn_hastakyt.Click += new System.EventHandler(this.btn_hastakyt_Click);
            // 
            // anasayfa_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hastakyt);
            this.Controls.Add(this.btn_giris);
            this.Name = "anasayfa_form";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_hastakyt;
    }
}

