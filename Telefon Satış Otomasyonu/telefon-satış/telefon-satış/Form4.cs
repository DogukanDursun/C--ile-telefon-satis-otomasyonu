using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon_satış
{
    public partial class yonetıcı : MetroFramework.Forms.MetroForm
    {
        public yonetıcı()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void telefonekle_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void telefonsil_Click(object sender, EventArgs e)
        {
            telefonsil telsil = new telefonsil();
            telsil.Show();
            this.Hide();
        }

        private void kullanıcısil_Click(object sender, EventArgs e)
        {
            kullanıcısil ksil = new kullanıcısil();
            ksil.Show();
            this.Hide();
        }

        private void sipariş_Click(object sender, EventArgs e)
        {
            sipariş Sipariş = new sipariş();
            Sipariş.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıgiris form1 = new kullanıcıgiris();
            form1.Show();
            this.Hide();
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
                Application.Exit();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            Güncelle güncelle = new Güncelle();
            güncelle.Show();
            this.Hide();
        }
    }
}
