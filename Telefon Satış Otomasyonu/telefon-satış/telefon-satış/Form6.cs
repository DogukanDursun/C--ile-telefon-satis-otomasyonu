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
    public partial class kaydol : MetroFramework.Forms.MetroForm
    {
        public kaydol()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");

            bag.Open();

            SqlCommand komut = new SqlCommand("insert into müsteri ([kullanıcı_adı],[sifre],[adı],[soyadı],[telno],[email]) values (@kullanıcı_adı,@sifre, @adı, @soyadı,@telno,@email)", bag);
            komut.Parameters.AddWithValue("@kullanıcı_adı", txtkullanıcı.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@adı", txtad.Text);
            komut.Parameters.AddWithValue("@soyadı", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telno", txttel.Text);
            komut.Parameters.AddWithValue("@email", txteposta.Text);

            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kaydınız başarıyla tamamlanmıştır");
            txtkullanıcı.Clear();
            txtad.Clear();
            txteposta.Clear();
            txtad.Clear();
            txttel.Clear();
            txtsifre.Clear();
            txtsoyad.Clear();
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıgiris form1 = new kullanıcıgiris();
            form1.Show();
            this.Hide();
        }
    }
}
