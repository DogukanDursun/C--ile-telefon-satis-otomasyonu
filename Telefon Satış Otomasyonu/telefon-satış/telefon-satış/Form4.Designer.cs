
namespace telefon_satış
{
    partial class yonetıcı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetıcı));
            this.telefonekle = new MetroFramework.Controls.MetroButton();
            this.sipariş = new MetroFramework.Controls.MetroButton();
            this.telefonsil = new MetroFramework.Controls.MetroButton();
            this.kullanıcısil = new MetroFramework.Controls.MetroButton();
            this.butoncıkıs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guncelle = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // telefonekle
            // 
            this.telefonekle.Location = new System.Drawing.Point(43, 88);
            this.telefonekle.Name = "telefonekle";
            this.telefonekle.Size = new System.Drawing.Size(135, 50);
            this.telefonekle.TabIndex = 0;
            this.telefonekle.Text = "Telefon Ekle";
            this.telefonekle.Click += new System.EventHandler(this.telefonekle_Click);
            // 
            // sipariş
            // 
            this.sipariş.Location = new System.Drawing.Point(43, 177);
            this.sipariş.Name = "sipariş";
            this.sipariş.Size = new System.Drawing.Size(135, 50);
            this.sipariş.TabIndex = 1;
            this.sipariş.Text = "Siparişleri Görüntüle";
            this.sipariş.Click += new System.EventHandler(this.sipariş_Click);
            // 
            // telefonsil
            // 
            this.telefonsil.Location = new System.Drawing.Point(226, 88);
            this.telefonsil.Name = "telefonsil";
            this.telefonsil.Size = new System.Drawing.Size(135, 50);
            this.telefonsil.TabIndex = 2;
            this.telefonsil.Text = "Telefon Sil";
            this.telefonsil.Click += new System.EventHandler(this.telefonsil_Click);
            // 
            // kullanıcısil
            // 
            this.kullanıcısil.Location = new System.Drawing.Point(226, 177);
            this.kullanıcısil.Name = "kullanıcısil";
            this.kullanıcısil.Size = new System.Drawing.Size(135, 50);
            this.kullanıcısil.TabIndex = 3;
            this.kullanıcısil.Text = "Kullanıcı Sil";
            this.kullanıcısil.Click += new System.EventHandler(this.kullanıcısil_Click);
            // 
            // butoncıkıs
            // 
            this.butoncıkıs.Image = ((System.Drawing.Image)(resources.GetObject("butoncıkıs.Image")));
            this.butoncıkıs.Location = new System.Drawing.Point(330, 332);
            this.butoncıkıs.Name = "butoncıkıs";
            this.butoncıkıs.Size = new System.Drawing.Size(146, 105);
            this.butoncıkıs.TabIndex = 41;
            this.butoncıkıs.UseVisualStyleBackColor = true;
            this.butoncıkıs.Click += new System.EventHandler(this.butoncıkıs_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(8, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 106);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(43, 259);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(135, 50);
            this.guncelle.TabIndex = 42;
            this.guncelle.Text = "Telefon Güncelle";
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // yonetıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.butoncıkıs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullanıcısil);
            this.Controls.Add(this.telefonsil);
            this.Controls.Add(this.sipariş);
            this.Controls.Add(this.telefonekle);
            this.Name = "yonetıcı";
            this.Text = "Yönetici Anasayfa";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton telefonekle;
        private MetroFramework.Controls.MetroButton sipariş;
        private MetroFramework.Controls.MetroButton telefonsil;
        private MetroFramework.Controls.MetroButton kullanıcısil;
        private System.Windows.Forms.Button butoncıkıs;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton guncelle;
    }
}