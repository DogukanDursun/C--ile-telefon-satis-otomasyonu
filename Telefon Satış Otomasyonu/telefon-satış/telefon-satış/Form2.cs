using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_satış
{
    public partial class Alışveriş : MetroFramework.Forms.MetroForm
    {
        public Alışveriş()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");
        dogukan dou = new dogukan();
      
      
        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from telefon",bag);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            string sql = "select * from il order by iller";
            dou.lblistele(listBox1, sql);
            bag.Close();
        }
      
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string sql = "select * from ilceler where il_id=" + listBox1.SelectedValue.ToString();
            dou.lblistele(listBox2, sql);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from telefon where Marka like'%" + txtara.Text + "%'", bag);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bag.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from telefon where id='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'",bag);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["resim"]!=null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["resim"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                    dr.Close();
                    komut.Dispose();
                    bag.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            bag.Open();
            string veri = listBox1.SelectedItem.ToString();
            string ver2 = listBox2.SelectedItem.ToString();

            SqlCommand komut = new SqlCommand("insert into sipariş ([adı],[soyadı],[Marka],[Model],[fiyat],[iller],[ilce],[adres]) values (@adı,@soyadı,@Marka, @Model, @fiyat,@iller,@ilce,@adres)", bag);

            komut.Parameters.AddWithValue("@soyadı", txtsoyad.Text);
            komut.Parameters.AddWithValue("@adı", txtad.Text);
            komut.Parameters.AddWithValue("@Marka", txtmarka.Text);
            komut.Parameters.AddWithValue("@Model", txtmodel.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@iller", listBox1.Text);
            komut.Parameters.AddWithValue("@ilce", listBox2.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Siparişiniz başarıyla oluşturuldu");
            txtsoyad.Clear();
            txtad.Clear();
            txtadres.Clear();
        
            txtmarka.Clear();
            txtmodel.Clear();
           
            txtfiyat.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıgiris kullanıcıgiris = new kullanıcıgiris();
            kullanıcıgiris.Show();
            this.Hide();
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
    

