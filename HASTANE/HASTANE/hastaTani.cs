

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HASTANE
{
    public partial class hastaTani : Form

    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dthastaliklar = new DataTable();
        DataTable dthastaliklarid = new DataTable();
        DataTable dttanilar = new DataTable();
        DataTable dttanilarid = new DataTable();
        DataTable dtrandevuluHasta = new DataTable();
        DataTable dtrandevuluHastaid = new DataTable();
        DateTime bugun = DateTime.Now;
        public int randevuluHastaId;
        int hastalik_index;
        
        public hastaTani()
        {
            InitializeComponent();
        }

        private void hastaliklar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_hastaliklar.SelectedIndex >= 0)
            {
                DataRow selectedRow = dthastaliklar.Rows[cmb_hastaliklar.SelectedIndex];
                hastalik_index = Convert.ToInt32(selectedRow["hastalik_id"]);
            }
        }

        private void hastaTani_Load(object sender, EventArgs e)
        {
           
            try
            {
                //initial bilgiler
                dtrandevuluHasta.Clear();
                dtrandevuluHastaid.Clear();
                dttanilar.Clear();
                Tanilar.Items.Clear();
                lbl_tckimlik.Text = "";
                lbl_isim.Text = "";
                lbl_cins.Text = "";
                lbl_yas.Text = "";
                //hastalik adları
                string query = "SELECT hastalik_ad,hastalik_id FROM hastalik";
                
                objDbAccess.readDatathroughAdapter(query, dthastaliklar);
                for (int i = 0; i < dthastaliklar.Rows.Count; i++)
                {
                    cmb_hastaliklar.Items.Add(dthastaliklar.Rows[i]["hastalik_ad"]);
                }
                objDbAccess.closeConn();
                
                // o anki saatte randevusu olan hasta
                TimeSpan currentTime = bugun.TimeOfDay;
                TimeSpan startTime = new TimeSpan(currentTime.Hours, (currentTime.Minutes / 30) * 30, 0);
                TimeSpan endTime = startTime.Add(TimeSpan.FromMinutes(29.999));
                DateTime bugunTarih = bugun.Date;
                string query2 = "SELECT hasta_id FROM randevu WHERE randevu_saat= (SELECT saat_id FROM saatler WHERE gun_id = (SELECT gun_id FROM gunler WHERE gun_tarih= '" + bugunTarih+ "' AND doktor_id='"+giris.kullanicidoc_id+"' ) AND saat_val BETWEEN '" + startTime+"' AND '"+endTime+"') ";
                
                objDbAccess.readDatathroughAdapter(query2, dtrandevuluHastaid);
                if (dtrandevuluHastaid.Rows.Count!=0)
                {
                    //hasta idsini al
                    
                    randevuluHastaId = Convert.ToInt32(dtrandevuluHastaid.Rows[0]["hasta_id"]);
                    objDbAccess.closeConn();
                    //hasta bilgileri al
                    
                    string query3 = "SELECT tckimlik,hasta_ad,hasta_cins,hasta_dg FROM hasta WHERE hasta_id= '"+randevuluHastaId+"' ";
                    objDbAccess.readDatathroughAdapter(query3, dtrandevuluHasta);
                    lbl_tckimlik.Text = dtrandevuluHasta.Rows[0]["tckimlik"].ToString();
                    lbl_isim.Text = dtrandevuluHasta.Rows[0]["hasta_ad"].ToString();
                    lbl_cins.Text = dtrandevuluHasta.Rows[0]["hasta_cins"].ToString();
                    lbl_yas.Text = dtrandevuluHasta.Rows[0]["hasta_dg"].ToString();
                    lbl_tckimlik.Text = dtrandevuluHasta.Rows[0]["tckimlik"].ToString();
                    // hasta önceki tanıları al
                    string query6 = "SELECT hastalik_id FROM hastalik_kaydi WHERE hasta_id= '" + randevuluHastaId + "'";
                    objDbAccess.readDatathroughAdapter(query6, dttanilarid);
                   
                    if (dttanilarid.Rows.Count!=0)
                    {
                        for (int i = 0; i < dttanilarid.Rows.Count; i++)
                        {
                            dttanilar.Clear();
                            query2 = "SELECT hastalik_ad FROM hastalik WHERE hastalik_id= '" + Convert.ToInt32(dttanilarid.Rows[i]["hastalik_id"]) + "'";
                            objDbAccess.readDatathroughAdapter(query2, dttanilar);
                            if (dttanilar.Rows.Count > 0)
                            {
                                Tanilar.Items.Add(dttanilar.Rows[0]["hastalik_ad"]);
                            }
                            objDbAccess.closeConn();
                        }
                    }
                    else
                    {
                        Tanilar.Items.Add("Hastanın daha önceden aldığı tanı yok.");
                    }

                }
                else
                {
                    MessageBox.Show("Randevulu hasta yüklenemedi");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oldu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_tanikoy_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            for(int i = 0; i< dttanilar.Rows.Count;i++)
            {
                if (hastalik_index ==Convert.ToInt32( dttanilar.Rows[i]["hastalik_id"]))
                {
                    kontrol = false;
                    break;
                }

            }
            if(randevuluHastaId>=1 && kontrol)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert into hastalik_kaydi(hasta_id,hastalik_id,doktor_id) values(@hasta_id,@hastalik_id,@doktor_id)");
                    cmd.Parameters.AddWithValue("@hasta_id", randevuluHastaId);
                    cmd.Parameters.AddWithValue("@hastalik_id", hastalik_index);
                    cmd.Parameters.AddWithValue("@doktor_id", giris.kullanicidoc_id);
                    int row = objDbAccess.executeQuery(cmd);
                    if (row != 0)
                    {
                        MessageBox.Show("Tanı Kaydı Oluşturuldu");
                    }
                    else
                    {
                        MessageBox.Show("Tanı Kaydı Oluşturulamadı. Tekrar Deneyiniz!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler yüklenirken hata oldu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu hastaya bu tanı daha önceden konulmuş.");
            }
        }

        private void list_hasta_tanilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
