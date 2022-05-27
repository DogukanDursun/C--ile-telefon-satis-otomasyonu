
namespace telefon_satış
{
    partial class sipariş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sipariş));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butoncıkıs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // butoncıkıs
            // 
            this.butoncıkıs.Image = ((System.Drawing.Image)(resources.GetObject("butoncıkıs.Image")));
            this.butoncıkıs.Location = new System.Drawing.Point(853, 338);
            this.butoncıkıs.Name = "butoncıkıs";
            this.butoncıkıs.Size = new System.Drawing.Size(146, 105);
            this.butoncıkıs.TabIndex = 39;
            this.butoncıkıs.UseVisualStyleBackColor = true;
            this.butoncıkıs.Click += new System.EventHandler(this.butoncıkıs_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(17, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 106);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.butoncıkıs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sipariş";
            this.Text = "sipariş";
            this.Load += new System.EventHandler(this.sipariş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butoncıkıs;
        private System.Windows.Forms.Button button1;
    }
}