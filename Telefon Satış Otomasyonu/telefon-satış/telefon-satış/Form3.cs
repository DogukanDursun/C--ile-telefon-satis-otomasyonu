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
    public partial class yönetici : MetroFramework.Forms.MetroForm
    {
        public yönetici()
        {
            InitializeComponent();
            Init_Data();
        }
      
        private void Form3_Load(object sender, EventArgs e)
        {
            txtsifre.PasswordChar = '*';
        }
          private void Init_Data()
        {
            if (Properties.Settings.Default.Username1 != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtkullanıcı.Text = Properties.Settings.Default.Username1;
                    txtsifre.Text = Properties.Settings.Default.sifre;
                    metroCheckBox1.Checked = true;
                }
                else
                {
                    txtkullanıcı.Text = Properties.Settings.Default.Username1;
                    txtsifre.Text = Properties.Settings.Default.sifre;
                }
            }
        }
        private void Save_Data()
        {
            if (metroCheckBox1.Checked)
            {
                Properties.Settings.Default.Username1 = txtkullanıcı.Text.Trim();
                Properties.Settings.Default.sifre = txtsifre.Text.Trim();
                Properties.Settings.Default.Remember1 = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username1 = "";
                Properties.Settings.Default.sifre = "";
                Properties.Settings.Default.Remember1 = false;
                Properties.Settings.Default.Save();
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Save_Data();
            SqlConnection bag = new SqlConnection("server=DOĞUKAN\\SQLEXPRESS;initial catalog = telefonsatış; integrated security=true");


            SqlCommand cmd;
            SqlDataReader dr;
            string sorgu = "SELECT * FROM yönetici where kullanıcıadı=@kullanıcı AND sifre=@sifre";

            cmd = new SqlCommand(sorgu, bag);
            cmd.Parameters.AddWithValue("@kullanıcı", txtkullanıcı.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            if (txtkullanıcı.Text == ""&& txtsifre.Text=="")
            {

                MessageBox.Show("Kullanıcı adı ve şifre alanları boş geçilemez");

                return;

            }
            bag.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                yonetıcı form4= new yonetıcı();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            bag.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            kullanıcıgiris kullanıcıgiris = new kullanıcıgiris();
            kullanıcıgiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }
    }
}
