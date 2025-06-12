namespace Kütüphane_Takip_Sistemi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOduncAl = new System.Windows.Forms.Button();
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.İade = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOduncler = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGecikenler = new System.Windows.Forms.DataGridView();
            this.btnGecikenleriListele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.İade.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(246, 34);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 3;
            this.txtISBN.Text = "txtISBN";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(246, 70);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 4;
            this.txtAd.Text = "txtAd";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(246, 102);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 22);
            this.txtYazar.TabIndex = 5;
            this.txtYazar.Text = "txtYazar";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(63, 152);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(125, 45);
            this.btnKitapEkle.TabIndex = 6;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(221, 152);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(115, 45);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.BackgroundColor = System.Drawing.Color.Chocolate;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvKitaplar.Location = new System.Drawing.Point(440, 23);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(143, 217);
            this.dgvKitaplar.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 217);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "eklelist";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tomato;
            this.groupBox2.Controls.Add(this.dtpIadeTarihi);
            this.groupBox2.Controls.Add(this.btnOduncAl);
            this.groupBox2.Controls.Add(this.cmbKitaplar);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 178);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "odunc";
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Location = new System.Drawing.Point(106, 128);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpIadeTarihi.TabIndex = 2;
            // 
            // btnOduncAl
            // 
            this.btnOduncAl.Location = new System.Drawing.Point(80, 80);
            this.btnOduncAl.Name = "btnOduncAl";
            this.btnOduncAl.Size = new System.Drawing.Size(75, 23);
            this.btnOduncAl.TabIndex = 1;
            this.btnOduncAl.Text = "btnOduncAl";
            this.btnOduncAl.UseVisualStyleBackColor = true;
            this.btnOduncAl.Click += new System.EventHandler(this.btnOduncAl_Click);
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(225, 80);
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(121, 24);
            this.cmbKitaplar.TabIndex = 0;
            // 
            // İade
            // 
            this.İade.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.İade.Controls.Add(this.button1);
            this.İade.Controls.Add(this.cmbOduncler);
            this.İade.Location = new System.Drawing.Point(755, 304);
            this.İade.Name = "İade";
            this.İade.Size = new System.Drawing.Size(297, 178);
            this.İade.TabIndex = 11;
            this.İade.TabStop = false;
            this.İade.Text = "iade";
            this.İade.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "iadeEt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOduncler
            // 
            this.cmbOduncler.FormattingEnabled = true;
            this.cmbOduncler.Location = new System.Drawing.Point(149, 48);
            this.cmbOduncler.Name = "cmbOduncler";
            this.cmbOduncler.Size = new System.Drawing.Size(121, 24);
            this.cmbOduncler.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.btnGecikenleriListele);
            this.groupBox3.Controls.Add(this.dgvGecikenler);
            this.groupBox3.Location = new System.Drawing.Point(767, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 186);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "gecikme";
            // 
            // dgvGecikenler
            // 
            this.dgvGecikenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikenler.Location = new System.Drawing.Point(137, 11);
            this.dgvGecikenler.Name = "dgvGecikenler";
            this.dgvGecikenler.RowHeadersWidth = 51;
            this.dgvGecikenler.RowTemplate.Height = 24;
            this.dgvGecikenler.Size = new System.Drawing.Size(148, 150);
            this.dgvGecikenler.TabIndex = 0;
            // 
            // btnGecikenleriListele
            // 
            this.btnGecikenleriListele.Location = new System.Drawing.Point(6, 29);
            this.btnGecikenleriListele.Name = "btnGecikenleriListele";
            this.btnGecikenleriListele.Size = new System.Drawing.Size(125, 72);
            this.btnGecikenleriListele.TabIndex = 1;
            this.btnGecikenleriListele.Text = "btnGecikenleriListele";
            this.btnGecikenleriListele.UseVisualStyleBackColor = true;
            this.btnGecikenleriListele.Click += new System.EventHandler(this.btnGecikenleriListele_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Takip_Sistemi.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1079, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(580, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ali Nebi ER - İkra Şahin Kütüphane Takip Sistemi Nesne Tabanlı Programlama Dersi " +
    "İkinci Ödevi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.İade);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.İade.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpIadeTarihi;
        private System.Windows.Forms.Button btnOduncAl;
        private System.Windows.Forms.ComboBox cmbKitaplar;
        private System.Windows.Forms.GroupBox İade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbOduncler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGecikenleriListele;
        private System.Windows.Forms.DataGridView dgvGecikenler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

