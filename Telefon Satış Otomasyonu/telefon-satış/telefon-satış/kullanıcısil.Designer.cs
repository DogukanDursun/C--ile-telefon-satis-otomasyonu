
namespace telefon_satış
{
    partial class kullanıcısil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcısil));
            this.butoncıkıs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butoncıkıs
            // 
            this.butoncıkıs.Image = ((System.Drawing.Image)(resources.GetObject("butoncıkıs.Image")));
            this.butoncıkıs.Location = new System.Drawing.Point(644, 335);
            this.butoncıkıs.Name = "butoncıkıs";
            this.butoncıkıs.Size = new System.Drawing.Size(146, 105);
            this.butoncıkıs.TabIndex = 37;
            this.butoncıkıs.UseVisualStyleBackColor = true;
            this.butoncıkıs.Click += new System.EventHandler(this.butoncıkıs_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(5, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 106);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 241);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 59);
            this.metroButton1.TabIndex = 35;
            this.metroButton1.Text = "Sil";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 172);
            this.dataGridView1.TabIndex = 34;
            // 
            // kullanıcısil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butoncıkıs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullanıcısil";
            this.Text = "Kullanıcı Sil";
            this.Load += new System.EventHandler(this.kullanıcısil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butoncıkıs;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}