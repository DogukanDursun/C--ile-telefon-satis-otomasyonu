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
    public partial class sipariş : MetroFramework.Forms.MetroForm
    {
        public sipariş()
        {
     
          
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");
        SqlDataAdapter da;
   
        void griddoldur()
        {
        
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Execute Siparişpr", bag);
      
          
            da.Fill(dt);
            dataGridView1.DataSource =dt;
       
        }
  
        private void sipariş_Load(object sender, EventArgs e)
        {
            griddoldur();

            bag.Open();
            SqlCommand komut = new SqlCommand("Select sipariş");
            
          

           
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                bag.Open();
                SqlCommand komut = new SqlCommand("delete from müsteri where sipariş_id='" + dataGridView1.SelectedRows[i].Cells["sipariş_id"].Value.ToString() + "'", bag);
                komut.ExecuteNonQuery();
                bag.Close();
            }
            MessageBox.Show("Silme işleminiz başarıyla gerçekleşti");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetıcı form4 = new yonetıcı();
            form4.Show();
            this.Hide();
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

    }
}
