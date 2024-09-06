using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE
{
    public partial class Hasta_AnaSayfa : Form
    {
        public Hasta_AnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_randevuOlustur_Click(object sender, EventArgs e)
        {
            randevu form = new randevu();
            form.Show();
            this.Hide();
        }

        private void btn_randevuSil_Click(object sender, EventArgs e)
        {
            Randevu_Sil form1 = new Randevu_Sil();
            form1.Show();
            this.Hide();
        }
    }
}
