using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE
{
    public partial class anasayfa_form : Form
    {
        DBAccess objDbAccess = new DBAccess();
       DateTime bugun = DateTime.Now;
        public anasayfa_form()
        {
            InitializeComponent();
         
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            giris form = new giris();
            form.Show();
            this.Hide();
        }

        private void anasayfa_form_Load(object sender, EventArgs e)
        {
            string query1 = "UPDATE saatler SET saat_status= 1  WHERE gun_id IN (SELECT gun_id FROM gunler WHERE  gun_tarih < '"+bugun.Date+"')";
            string query2 = "UPDATE saatler SET saat_status=1 WHERE gun_id IN (SELECT gun_id FROM gunler WHERE  gun_tarih = '" + bugun.Date + "') AND saat_val < '" + bugun.TimeOfDay + "'";
            string query3 = "UPDATE gunler SET gun_status= 1 WHERE gun_id IN (SELECT gun_id FROM gunler WHERE  gun_tarih < '" + bugun.Date + "')";
            // çalışıp çalışmadığını bilmiyorum
            string query4 = "    DECLARE @most_recent_date DATE;\r\n    DECLARE @new_date DATE;\r\n    DECLARE @doktor_id INT;\r\n\tDECLARE @least_recent_date DATE;\r\n\tDECLARE @today DATE = CAST(GETDATE() AS DATE);\r\n\r\n    \r\n    DECLARE doktor_cursor CURSOR FOR\r\n    SELECT DISTINCT doktor_id\r\n    FROM gunler;\r\n\r\n    OPEN doktor_cursor;\r\n\r\n    FETCH NEXT FROM doktor_cursor INTO @doktor_id;\r\n\r\n    WHILE @@FETCH_STATUS = 0\r\n    BEGIN\r\n        SELECT @least_recent_date = MIN(gun_tarih)\r\n\t\tFROM gunler\r\n        WHERE doktor_id = @doktor_id;\r\n        SELECT @most_recent_date = MAX(gun_tarih)\r\n        FROM gunler\r\n        WHERE doktor_id = @doktor_id;\r\n\r\n        \r\n        IF @most_recent_date= @today\r\n        BEGIN\r\n            \r\n            DECLARE @i INT = 0;\r\n\t\tWHILE @i < 15\r\n\t\tBEGIN\r\n\t\t\tDECLARE @gun_tarih DATE = DATEADD(DAY, @i, @today);\r\n\t\t\tINSERT INTO gunler (gun_tarih, gun_status, doktor_id)\r\n\t\t\tVALUES (@gun_tarih, 0, @doktor_id);\r\n\t\t\tSET @i = @i + 1;\r\n\t\tEND\r\n\r\n        FETCH NEXT FROM doktor_cursor INTO @doktor_id;\r\n    END\r\n\r\n    CLOSE doktor_cursor;\r\n    DEALLOCATE doktor_cursor;";
            SqlCommand cmd1 = new SqlCommand(query1);
            objDbAccess.executeQuery(cmd1 );
            objDbAccess.closeConn();
            SqlCommand cmd2 = new SqlCommand(query2);
            objDbAccess.executeQuery(cmd2 );
            objDbAccess.closeConn();
            SqlCommand cmd3 = new SqlCommand(query3);
            objDbAccess.executeQuery(cmd3 );
            objDbAccess.closeConn();
            SqlCommand cmd4 = new SqlCommand(query4);
        }

        private void btn_hastakyt_Click(object sender, EventArgs e)
        {
            kayitol form1 = new kayitol();
            form1.Show();
            this.Hide();
        }
    }
}
