using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_satış
{
    class dogukan
    {

        SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");
        public void lblistele(ListBox lb, string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            lb.DataSource = tablo;
            lb.ValueMember = tablo.Columns[0].ColumnName;
            lb.DisplayMember = tablo.Columns[1].ColumnName;
        }
        public void kaydet(string IMEI, string Marka, string Model, string Depolama, string Ram,string Batarya,string Ekran,string Kamera, string resim)
        {
            string sql = "insert into telefon (IMEI,Marka,Model,Depolama,Ram,Batarya,Ekran,Kamera,resim) values ('" + IMEI + "','" + Marka + "','" + Model + "','" + Depolama + "','" + Ram+ "','" +Batarya + "','" +Ekran + "','" +Kamera + "','" +resim+ "')";
            SqlCommand komut = new SqlCommand(sql, bag);
            bag.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Telefon Bilgileri Kaydedildi");
            bag.Close();

        }


    }
}
