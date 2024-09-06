using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HASTANE
{
    public partial class randevu : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dthastaneler = new DataTable();
        DataTable dtbranslar = new DataTable();
        DataTable dtdoktorlar = new DataTable();
        DataTable dttarihler = new DataTable();
        DataTable dtsaatler = new DataTable();

        int secili_hastaneid;
        int secili_bransid;
        int secili_doktorid;
        int secili_gunid;
        int secili_saatid;
        public randevu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void saat_yukle()
        {
            if (secili_gunid >= 0)
            {
                string query7 = "Select saat_val,saat_id from saatler where gun_id='" + secili_gunid + "' AND saat_status = '" + 0 + "'";
                SqlCommand cmd = new SqlCommand(query7);
                objDbAccess.readDatathroughAdapter(cmd.CommandText, dtsaatler);
                for (int i = 0; i < dtsaatler.Rows.Count; i++)
                {
                    saat_combo.Items.Add(dtsaatler.Rows[i]["saat_val"]);
                }
                objDbAccess.closeConn();
                
            }
        }
        public void gun_yukle()
        {
            if (secili_doktorid >= 1)
            {
                string query2 = "Select gun_tarih,gun_id from gunler where doktor_id='" + secili_doktorid + "' AND gun_status = '" + 0 + "'";
                SqlCommand cmd = new SqlCommand(query2);
                objDbAccess.readDatathroughAdapter(cmd.CommandText, dttarihler);
                for (int i = 0; i < dttarihler.Rows.Count; i++)
                {
                    tarih_combo.Items.Add(dttarihler.Rows[i]["gun_tarih"]);
                }

                objDbAccess.closeConn();
                
            }
        }
        public void doktor_yukle()
        {
            if (secili_bransid >= 1 && secili_hastaneid >= 1)
            {
                // doktor adları
                string query3 = "Select doktor_ad,doktor_id from doktor where brans_id='" + secili_bransid + "' AND hastane_id='" + secili_hastaneid + "'";
                objDbAccess.readDatathroughAdapter(query3, dtdoktorlar);
                for (int i = 0; i < dtdoktorlar.Rows.Count; i++)
                {
                    doktor_combo.Items.Add(dtdoktorlar.Rows[i]["doktor_ad"]);
                }
                objDbAccess.closeConn();
                
            }
        }
        public void hastane_brans_yukle()
        {
            try
            {
                // hastane adları
                string query = "Select hastane_ad,hastane_id from hastane";
                objDbAccess.readDatathroughAdapter(query, dthastaneler);
                if (dthastaneler.Rows.Count > 0)
                {
                    for (int i = 0; i < dthastaneler.Rows.Count; i++)
                    {
                        hastane_combo.Items.Add(dthastaneler.Rows[i]["hastane_ad"]);
                    }
                }
                else
                {
                    MessageBox.Show("veri tablosu boş.");
                }
                objDbAccess.closeConn();
                // brans adları
                string query1 = "Select brans_ad,brans_id from brans";
                objDbAccess.readDatathroughAdapter(query1, dtbranslar);
                for (int i = 0; i < dtbranslar.Rows.Count; i++)
                {
                    brans_combo.Items.Add(dtbranslar.Rows[i]["brans_ad"]);
                }
                objDbAccess.closeConn();
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oldu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void randevu_Load(object sender, EventArgs e)
        {
            //initualizing
            doktor_combo.Items.Clear();
            dtdoktorlar.Clear();
            
            tarih_combo.Items.Clear();
            dttarihler.Clear();
            
            saat_combo.Items.Clear();
            dtsaatler.Clear();
            
            hastane_brans_yukle();
        }

        private void hastane_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçili hastane değiştiğinde sıfırla
            doktor_combo.Items.Clear();
            dtdoktorlar.Clear();
           
            tarih_combo.Items.Clear();
            dttarihler.Clear();
            
            saat_combo.Items.Clear();
            dtsaatler.Clear();
            
            saat_combo.Text = "";
            tarih_combo.Text = "";
            doktor_combo.Text = "";

            // seçili hastane değiştiğinde seçili hastanenin idsini sakla
            if (hastane_combo.SelectedIndex >= 0)
            {
                DataRow selectedRow = dthastaneler.Rows[hastane_combo.SelectedIndex];
                secili_hastaneid = Convert.ToInt32(selectedRow["hastane_id"]);
            }
            // seçimler yapıldıktan sonra tekrardan hastane değiştiğinde doktor ekle
            doktor_yukle();

        }

        private void brans_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçili brans değiştiğinde sıfırla
            doktor_combo.Items.Clear();
            dtdoktorlar.Clear();
          
            tarih_combo.Items.Clear();
            dttarihler.Clear();
           
            saat_combo.Items.Clear();
            dtsaatler.Clear();
           
            saat_combo.Text = "";
            tarih_combo.Text = "";
            doktor_combo.Text = "";
            // seçili brans değiştiğinde seçili bransının idsini sakla

            if (brans_combo.SelectedIndex >= 0)
            {
                DataRow selectedRow = dtbranslar.Rows[brans_combo.SelectedIndex];
                secili_bransid = Convert.ToInt32(selectedRow["brans_id"]);
            }

            doktor_yukle();
            
        }

        private void doktor_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            // seçili doktor değişince sıfırla
            tarih_combo.Items.Clear();
            dttarihler.Clear();
          
            saat_combo.Items.Clear();
            dtsaatler.Clear();
           
            saat_combo.Text = "";
            tarih_combo.Text = "";
            // seçili doktor id
            if (doktor_combo.SelectedIndex >= 0)
            {
                DataRow selectedRow = dtdoktorlar.Rows[doktor_combo.SelectedIndex];
                secili_doktorid = Convert.ToInt32(selectedRow["doktor_id"]);
            }

            // Doktorun uygun günleri
            gun_yukle();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçili saat değişince sıfırla
            saat_combo.Items.Clear();
            dtsaatler.Clear();
           
            saat_combo.Text = "";
            // seçili gün sakla
            if (tarih_combo.SelectedIndex >= 0)
            {
                DataRow selectedRow = dttarihler.Rows[tarih_combo.SelectedIndex];
                secili_gunid = Convert.ToInt32(selectedRow["gun_id"]);
            }

            // seçili günde bulunan musait saatleri göster
            saat_yukle();
        }

        private void saat_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // saat id al
            if (saat_combo.SelectedIndex >= 0)
            {
                DataRow selectedRow = dtsaatler.Rows[saat_combo.SelectedIndex];
                secili_saatid = Convert.ToInt32(selectedRow["saat_id"]);

            }
        }

        private void btn_randevuonayla_Click(object sender, EventArgs e)
        {
            // 15 gün içerisinde randevu aldıysa randevu verme
            bool kontrol= true;
            string query10 = "SELECT randevu_id FROM randevu where hasta_id = '" + giris.kullanicipat_id + "' AND randevu_tarih IN (SELECT gun_id FROM gunler WHERE gun_tarih > '"+DateTime.Now.AddDays(-15).Date+"') AND doktor_id IN (SELECT doktor_id FROM doktor WHERE brans_id = '"+secili_bransid+"')";
            DataTable dt = new DataTable();
            objDbAccess.readDatathroughAdapter(query10, dt);
            if(dt.Rows.Count>0)
            {
                kontrol = false;
            }
            try
            {
               
                // butona basıldığında hastaid doktorid saatid ve gunid'yi veri tabanına kaydet
                if (secili_bransid >= 1 && secili_doktorid >= 1 && secili_gunid >= 1 && secili_hastaneid >= 1 && secili_saatid >= 1 && kontrol)
                {

                    SqlCommand cmd = new SqlCommand("Insert into randevu(hasta_id,doktor_id,randevu_saat,randevu_tarih) values(@hasta_id,@doktor_id,@randevu_saat,@randevu_tarih)");

                    cmd.Parameters.AddWithValue("@randevu_saat", secili_saatid);
                    cmd.Parameters.AddWithValue("@randevu_tarih", secili_gunid);
                    cmd.Parameters.AddWithValue("@hasta_id", giris.kullanicipat_id);
                    cmd.Parameters.AddWithValue("@doktor_id", secili_doktorid);
                    int row = objDbAccess.executeQuery(cmd);

                    if (row != 1)
                    {
                        MessageBox.Show("Randevu oluşturulamadı.");
                    }
                    else
                    {

                        // randevu seçilen saatin statusunu 1 yap
                        SqlCommand cmd1 = new SqlCommand("UPDATE saatler SET saat_status = 1 WHERE saat_id = '" + secili_saatid + "'");
                        objDbAccess.executeQuery(cmd1);
                        // eğer bir gunun tum saatlerinin statusu 1 ise o günün statusunu 1 yap
                        SqlCommand cmd2 = new SqlCommand("UPDATE gunler SET gun_status = 1 WHERE gun_id IN (SELECT gun_id FROM saatler GROUP BY gun_id HAVING COUNT(*) = COUNT(CASE WHEN saat_status = 1 THEN 1 END))");
                        objDbAccess.executeQuery(cmd2);
                        MessageBox.Show("Randevu Oluşturuldu.");
                        objDbAccess.closeConn();
                        saat_combo.Items.Clear();
                        tarih_combo.Items.Clear();
                        doktor_combo.Items.Clear();
                        gun_yukle();
                        saat_yukle();
                        doktor_yukle();

                    }
                }
                else
                {
                    MessageBox.Show("15 Gün içerisinde bu branş için randevunuz bulunmaktadır. Tekrar randevu almanız için randevu tarihinizden 15 gün geçmesi gerekmektedir.");
                }

            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            Hasta_AnaSayfa form = new Hasta_AnaSayfa();
            form.Show();
            this.Hide();
        }
    }
}
