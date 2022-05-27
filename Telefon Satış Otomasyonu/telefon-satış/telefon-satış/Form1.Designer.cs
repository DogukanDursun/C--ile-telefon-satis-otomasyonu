
namespace telefon_satış
{
    partial class kullanıcıgiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcıgiris));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtkullanıcı = new MetroFramework.Controls.MetroTextBox();
            this.txtsifre = new MetroFramework.Controls.MetroTextBox();
            this.butongiris = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.butoncıkıs = new System.Windows.Forms.Button();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(112, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Şifre:";
            // 
            // txtkullanıcı
            // 
            this.txtkullanıcı.Location = new System.Drawing.Point(156, 121);
            this.txtkullanıcı.Name = "txtkullanıcı";
            this.txtkullanıcı.Size = new System.Drawing.Size(101, 23);
            this.txtkullanıcı.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(156, 169);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(101, 23);
            this.txtsifre.TabIndex = 3;
            // 
            // butongiris
            // 
            this.butongiris.Location = new System.Drawing.Point(156, 219);
            this.butongiris.Name = "butongiris";
            this.butongiris.Size = new System.Drawing.Size(101, 32);
            this.butongiris.TabIndex = 4;
            this.butongiris.Text = "Giriş Yap";
            this.butongiris.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(263, 228);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(101, 23);
            this.metroLink1.TabIndex = 6;
            this.metroLink1.Text = "Yönetici Girişi";
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(156, 198);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(84, 15);
            this.metroCheckBox1.TabIndex = 7;
            this.metroCheckBox1.Text = "Beni Hatırla";
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // butoncıkıs
            // 
            this.butoncıkıs.Image = ((System.Drawing.Image)(resources.GetObject("butoncıkıs.Image")));
            this.butoncıkıs.Location = new System.Drawing.Point(362, 345);
            this.butoncıkıs.Name = "butoncıkıs";
            this.butoncıkıs.Size = new System.Drawing.Size(146, 105);
            this.butoncıkıs.TabIndex = 8;
            this.butoncıkıs.UseVisualStyleBackColor = true;
            this.butoncıkıs.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(49, 228);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(101, 23);
            this.metroLink2.TabIndex = 10;
            this.metroLink2.Text = "Kaydol";
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // kullanıcıgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.butoncıkıs);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.butongiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanıcı);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "kullanıcıgiris";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtkullanıcı;
        private MetroFramework.Controls.MetroTextBox txtsifre;
        private MetroFramework.Controls.MetroButton butongiris;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.Button butoncıkıs;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}

