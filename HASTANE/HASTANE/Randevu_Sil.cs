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
   
    public partial class Randevu_Sil : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtgelecekrandevular = new DataTable();
        int selected_randevu;
        public Randevu_Sil()
        {
            InitializeComponent();
        }

        private void cmbox_gelecekrandevu_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_randevu = Convert.ToInt32(dtgelecekrandevular.Rows[cmbox_gelecekrandevu.SelectedIndex]["randevu_id"]);
        }

        private void Randevu_Sil_Load(object sender, EventArgs e)
        {
            try
            {
                cmbox_gelecekrandevu.Items.Clear();
                string query = "SELECT doktor_id,randevu_tarih,randevu_saat,randevu_id FROM randevu WHERE randevu_tarih IN (SELECT gun_id FROM gunler WHERE gun_tarih > '" + DateTime.Now.Date + "')";
                objDbAccess.readDatathroughAdapter(query, dtgelecekrandevular);
                string query1; string query2; string query3; string query4; string query5;
                DataTable hastane_ad = new DataTable(); DataTable doktor_ad = new DataTable(); DataTable brans_ad = new DataTable(); ; DataTable gun_tarih = new DataTable(); DataTable saat_val = new DataTable();
                for (int i = 0; i < dtgelecekrandevular.Rows.Count; i++)
                {
                    query1 = "SELECT doktor_ad,hastane_id,brans_id FROM doktor WHERE doktor_id = '" + dtgelecekrandevular.Rows[i]["doktor_id"] + "'";
                    objDbAccess.readDatathroughAdapter(query1, doktor_ad);
                    query2 = "SELECT hastane_ad FROM hastane WHERE hastane_id = '" + doktor_ad.Rows[i]["hastane_id"] + "'";
                    objDbAccess.readDatathroughAdapter(query2, hastane_ad);
                    query3 = "SELECT brans_ad FROM brans WHERE brans_id = '" + doktor_ad.Rows[i]["brans_id"] + "' ";
                    objDbAccess.readDatathroughAdapter(query3, brans_ad);
                    query4 = "SELECT gun_tarih FROM gunler WHERE gun_id = '" + dtgelecekrandevular.Rows[i]["randevu_tarih"] + "'";
                    objDbAccess.readDatathroughAdapter(query4, gun_tarih);
                    query5 = "SELECT saat_val FROM saatler WHERE saat_id = '" + dtgelecekrandevular.Rows[i]["randevu_saat"] + "'";
                    objDbAccess.readDatathroughAdapter(query5, saat_val);
                    cmbox_gelecekrandevu.Items.Add("Randevu Hastane: '" + hastane_ad.Rows[i]["hastane_ad"] + "'  Randevu Branş: '" + brans_ad.Rows[i]["brans_ad"] + "'   Randevu Doktor: '" + doktor_ad.Rows[i]["doktor_ad"] + "'  Randevu Tarih: '" + gun_tarih.Rows[i]["gun_tarih"] + " " + saat_val.Rows[i]["saat_val"] + "'");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            Hasta_AnaSayfa form = new Hasta_AnaSayfa();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "UPDATE gunler SET gun_status=0 WHERE gun_id = '" + dtgelecekrandevular.Rows[cmbox_gelecekrandevu.SelectedIndex]["randevu_tarih"] + "'";
                string query2 = "UPDATE saatler SET saat_status=0 WHERE saat_id = '" + dtgelecekrandevular.Rows[cmbox_gelecekrandevu.SelectedIndex]["randevu_saat"] + "'";
                string query3 = "DELETE randevu WHERE randevu_id = '" + selected_randevu + "'";
                objDbAccess.readDatathroughReader(query1);
                objDbAccess.closeConn();
                objDbAccess.readDatathroughReader(query2);
                objDbAccess.closeConn();
                objDbAccess.readDatathroughReader(query3);
                objDbAccess.closeConn();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
