using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE
{
    
    public partial class kayitol : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtkullanici_tcler = new DataTable();

        
        public kayitol()
        {
            InitializeComponent();
        }
        public bool IsNum(string str)
        {
            foreach (char chr in str)
            {
                if(!char.IsDigit(chr))
                {
                    return false;
                }
                
            }
            return true;
        }
        private void kyt_btn_Click(object sender, EventArgs e)
        {
            string hasta_isim = txtbox_isimsoyisim.Text;
            string hasta_tc = txtbox_tc.Text;
            string hasta_cins = cins_cmbox.Text;
            string userPassword = txtbox_sifre_hasta.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(hasta_isim) ||
                string.IsNullOrEmpty(hasta_tc) ||
                string.IsNullOrEmpty(hasta_cins) ||
                string.IsNullOrEmpty(userPassword) ||
                hasta_tc.Length != 11 ||
                !IsNum(hasta_tc) ||
                userPassword.Length > 10 ||
                hasta_isim.Length > 70)
            {
                MessageBox.Show("Kayıt oluşturulamadı. Bu kurallara dikkat ediniz: Hiçbir seçeneği boş bırakmayınız. TC Kimliğinizi doğru girdiğinizden emin olunuz. Şifreniz en fazla 10 haneli olabilir. İsminiz en fazla 70 haneli olabilir.");
                return;
            }

            // Check if the TC number already exists
            string query2 = "SELECT COUNT(*) FROM hasta WHERE tckimlik = @tckimlik";
            using (var cmd = new SqlCommand(query2))
            {
                cmd.Parameters.AddWithValue("@tckimlik", hasta_tc);
                int count = (int)objDBAccess.executeQuery(cmd);
                if (count > 0)
                {
                    MessageBox.Show("TC Kimlik numarası zaten kayıtlı.");
                    return;
                }
            }

            // Create salt and hash the password
            byte[] salt = HashIslemleri.CreateSalt();
            string hashedSifre = HashIslemleri.CreatePasswordHash(userPassword, salt);

            // Insert into the database
            string insertQuery = "INSERT INTO hasta (hasta_ad, tckimlik, hasta_cins, hasta_sifre, salt,hasta_dg) VALUES (@userIsim, @userTc, @usercins, @usersifre, @salt,@hasta_dg)";
            using (var insertCmd = new SqlCommand(insertQuery))
            {
                insertCmd.Parameters.AddWithValue("@userIsim", hasta_isim);
                insertCmd.Parameters.AddWithValue("@userTc", hasta_tc);
                insertCmd.Parameters.AddWithValue("@usercins", hasta_cins);
                insertCmd.Parameters.AddWithValue("@usersifre", hashedSifre);
                insertCmd.Parameters.AddWithValue("@salt", Convert.ToBase64String(salt));
                insertCmd.Parameters.AddWithValue("@hasta_dg",dogumgunu.Value);

                int rowsAffected = objDBAccess.executeQuery(insertCmd);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Hesap Oluşturuldu.");
                    this.Hide();
                    randevu form = new randevu();
                    form.Show();
                    objDBAccess.closeConn();
                }
                else
                {
                    MessageBox.Show("Hesap oluşturulamadı.");
                }
            }
        }


        private void kayitol_Load(object sender, EventArgs e)
        {
            cins_cmbox.Items.Add("K");
            cins_cmbox.Items.Add("E");
        }

        private void Şifre_Click(object sender, EventArgs e)
        {

        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            anasayfa_form form = new anasayfa_form();
            form.Show();
            this.Hide();
        }
    }
}
