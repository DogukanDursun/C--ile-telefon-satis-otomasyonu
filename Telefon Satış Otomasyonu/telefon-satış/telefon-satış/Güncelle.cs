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
    public partial class Güncelle : MetroFramework.Forms.MetroForm
    {
        public Güncelle()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");
        string imagepath;
        private void Güncelle_Load(object sender, EventArgs e)
        {
            Markagetir();

        }
        void Markagetir()
        {
            SqlCommand komut = new SqlCommand();
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
        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }
        void ilcegetir()
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
        private void markacb_SelectedIndexChanged(object sender, EventArgs e)
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

        private void guncellebuton_Click(object sender, EventArgs e)
        {

            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            bag.Open();
            string kayit = "update telefon set Marka=@Marka,Model=@Model,Depolama=@depolama,Ram=@ram,Batarya=@batarya,Ekran=@ekran,Kamera=@kamera,Fiyat=@fiyat where IMEI=@IMEI";
             SqlCommand komut = new SqlCommand(kayit, bag);
         

            komut.Parameters.AddWithValue("@Marka", markacb.Text);
            komut.Parameters.AddWithValue("@Model", modelcb.Text);
            komut.Parameters.AddWithValue("@depolama", txtdepolama.Text);
            komut.Parameters.AddWithValue("@ram", txtram.Text);
            komut.Parameters.AddWithValue("@batarya", txtbatarya.Text);
            komut.Parameters.AddWithValue("@ekran", txtekran.Text);
            komut.Parameters.AddWithValue("@kamera", txtkamera.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@IMEI", txtfiyat.Text);
            komut.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
        
            komut.ExecuteNonQuery();
        
            bag.Close();
            MessageBox.Show("Telefon Bilgileri Güncellendi.");




        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
           
        }

     
        private void geri_Click(object sender, EventArgs e)
        {
            yonetıcı yonetıcı = new yonetıcı();
            yonetıcı.Show();
            this.Hide();
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {

            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            bag.Open();
            string kayit = "SELECT * from telefon where IMEI=@IMEI";
         
            SqlCommand komut = new SqlCommand(kayit, bag);
            komut.Parameters.AddWithValue("@IMEI", txtimei.Text);
  
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                markacb.Text = dr["Marka"].ToString();
                modelcb.Text = dr["Model"].ToString();
                txtdepolama.Text = dr["Depolama"].ToString();
                txtram.Text = dr["Ram"].ToString();
                txtbatarya.Text = dr["Batarya"].ToString();
                txtekran.Text = dr["Ekran"].ToString();
                txtkamera.Text = dr["Kamera"].ToString();
                txtfiyat.Text = dr["Fiyat"].ToString();

                MessageBox.Show("Telefon bilgileri güncellendi.");

            }
            else
                MessageBox.Show("Telefon Bilgileri Bulunamadı.");
            bag.Close();
        }

        private void btnresimsec_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }
    }
    }
    

