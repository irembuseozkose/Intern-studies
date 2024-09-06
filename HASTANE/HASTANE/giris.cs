using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE
{
    public partial class giris : Form

    {
        DBAccess objDbAccess = new DBAccess();
        public static int kullanicidoc_id;
        public static int kullanicipat_id;


        public giris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string tckimlikGiris = tckimlik_text.Text.Trim();
            string password = sifre_text.Text.Trim();

            if (string.IsNullOrEmpty(tckimlikGiris) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Alanları boş bırakmayınız.");
                return;
            }

            // Query for patient
            string patientQuery = "SELECT hasta_sifre, salt, hasta_id FROM hasta WHERE tckimlik = '" + tckimlikGiris + "'";
            DataTable dtPatUsers = new DataTable();

            objDbAccess.readDatathroughAdapter(patientQuery, dtPatUsers);


            // Query for doctor
            string doctorQuery = "SELECT doktor_sifre, doktor_id FROM doktor WHERE tckimlik ='" + tckimlikGiris + "'";
            DataTable dtDocUsers = new DataTable();


            objDbAccess.readDatathroughAdapter(doctorQuery, dtDocUsers);


            if (dtPatUsers.Rows.Count == 1)
            {
                // Patient login
                DataRow selectedRow = dtPatUsers.Rows[0];
                string storedHash = selectedRow["hasta_sifre"].ToString();
                string storedSaltBase64 = Convert.ToString(selectedRow["salt"]);
                byte[] storedSalt = Convert.FromBase64String(storedSaltBase64); // Convert Base64 string to byte array

                if (HashIslemleri.SifreKontrolEt(password, storedHash, storedSalt))
                {
                    kullanicipat_id = Convert.ToInt32(selectedRow["hasta_id"]);
                    MessageBox.Show("Başarıyla giriş yaptınız.");
                    objDbAccess.closeConn();
                    Hasta_AnaSayfa form = new Hasta_AnaSayfa();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre hatalı");
                }
            }
            else if (dtDocUsers.Rows.Count == 1)
            {
                // Doctor login
                DataRow selectedRow = dtDocUsers.Rows[0];
                string sifre = selectedRow["doktor_sifre"].ToString();


                if (sifre_text.Text.Equals(sifre))
                {
                    kullanicidoc_id = Convert.ToInt32(selectedRow["doktor_id"]);
                    MessageBox.Show("Başarıyla giriş yaptınız.");
                    objDbAccess.closeConn();
                    hastaTani form = new hastaTani();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre hatalı");
                }
            }
            else
            {
                MessageBox.Show("TC kimlik hatalı");
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }



    }
}
