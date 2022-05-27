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
using System.IO;

namespace telefon_satış
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");
        string imagepath;
        SqlCommand komut = new SqlCommand();
        private void Form5_Load(object sender, EventArgs e)
        {
            markagetir();
            DataTable dt = new DataTable();
            string sql = "Select Marka_adı from Marka join telefon on Marka = telefon.Marka ";
            bag.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
         
            bag.Close();

            DataSet dtst = new DataSet();

            SqlDataAdapter adtr = new SqlDataAdapter("select * From telefon", bag);

            bag.Open();

            adtr.Fill(dtst, "telefon");

            dataGridView1.DataSource = dtst.Tables["telefon"];

            adtr.Dispose();

            bag.Close();


          
        }
        void markagetir()
        {
            DataRow dr;
            bag.Open();
            komut = new SqlCommand("select * from Marka ", bag); 
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dr = tablo.NewRow();
            markacb.ValueMember = "Marka_id";
            markacb.DisplayMember = "Marka_adı";
            markacb.DataSource = tablo;
            markacb.Text = "";
            bag.Close();

        }
        void Modelgetir()
        {
            SqlCommand komut = new SqlCommand();
            DataRow dr;
            bag.Open();
            komut = new SqlCommand("select * from Model where Model_id=@model_id ", bag);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            komut.Parameters.AddWithValue("@model_id", modelcb.SelectedValue);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dr = tablo.NewRow();
            modelcb.ValueMember = "Ilce_Id";
            modelcb.DisplayMember = "Ilce_Adı";
            modelcb.DataSource = tablo;
            modelcb.Text = "";
            bag.Close();
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }
        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();


            bag.Open();
            SqlCommand komut = new SqlCommand("insert into telefon ([IMEI],[Marka],[Model],[Depolama],[Ram],[Batarya],[Ekran],[Kamera],[Fiyat],[Resim]) values (@IMEI,@Marka, @Model,@depolama,@ram,@batarya,@ekran,@kamera ,@fiyat,@resim)", bag);

            komut.Parameters.AddWithValue("@IMEI", txtimei.Text);

            komut.Parameters.AddWithValue("@Marka", markacb.Text);
            komut.Parameters.AddWithValue("@Model", modelcb.Text);
            komut.Parameters.AddWithValue("@depolama", txtdepolama.Text);
            komut.Parameters.AddWithValue("@ram", txtram.Text);
            komut.Parameters.AddWithValue("@batarya", txtbatarya.Text);
            komut.Parameters.AddWithValue("@ekran", txtekran.Text);
            komut.Parameters.AddWithValue("@kamera", txtkamera.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
         
            komut.Parameters.Add("@resim",SqlDbType.Image,resim.Length).Value=resim;
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Telefon bilgileri kaydedildi");
            txtbatarya.Clear();
            txtdepolama.Clear();
            txtekran.Clear();
            txtimei.Clear();
            txtkamera.Clear();
          
            txtram.Clear();
            txtfiyat.Clear();
            dataGridView1.DataSource = yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetıcı yonetıcı = new yonetıcı();
            yonetıcı.Show();
            this.Hide();
        }
        DataTable yenile()
        {
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *From telefon", bag);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            bag.Close();
            return tablo;
        }
        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bag.Close();
            modelcb.Items.Clear();
            bag.Open();
            SqlCommand kom2 = new SqlCommand("select Model_adı from Model where Marka_id=@Marka_id", bag);
            kom2.Parameters.AddWithValue("@Marka_id", markacb.SelectedIndex + 1);
            SqlDataReader oku = kom2.ExecuteReader();

            while (oku.Read())
            {
                modelcb.Items.Add(oku["Model_adı"]);
            }
            bag.Close();
        }

        private void modelcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
