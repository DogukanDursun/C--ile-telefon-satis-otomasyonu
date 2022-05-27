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

namespace telefon_satış
{
    public partial class telefonsil : MetroFramework.Forms.MetroForm
    {
        public telefonsil()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");
   
        SqlDataAdapter da;
        DataSet ds;
      

        private void telefonsil_Load(object sender, EventArgs e)
        {
            griddoldur();
            dataGridView1.DataSource = yenile();
        }
        DataTable yenile()
        {
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter ("Select *From telefon", bag);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            bag.Close();
            return tablo;
        }
       void griddoldur()
        {
      
            da = new SqlDataAdapter("Select *From telefon", bag);
            ds = new DataSet();
            bag.Open();
            da.Fill(ds, "telefon");
            dataGridView1.DataSource = ds.Tables["telefon"];
            bag.Close();
        }
       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                bag.Open();
                SqlCommand komut = new SqlCommand("delete from telefon where id='"+dataGridView1.SelectedRows[i].Cells["id"].Value.ToString()+"'", bag);
                komut.ExecuteNonQuery();
                bag.Close(); 
            }
            MessageBox.Show("Silme işleminiz başarıyla gerçekleşti");
            dataGridView1.DataSource = yenile();
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetıcı form4 = new yonetıcı();
            form4.Show();
            this.Hide();
        }
    }
    }

