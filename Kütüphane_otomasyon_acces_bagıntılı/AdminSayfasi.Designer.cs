
namespace Kütüphane_otomasyon_acces_bagıntılı
{
    partial class Admin_Sayfası
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Sayfası));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_olTarih = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_Soyisim = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_verileritemizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oluşturmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcılarDataSet = new Kütüphane_otomasyon_acces_bagıntılı.KullanıcılarDataSet();
            this.bilgilerTableAdapter = new Kütüphane_otomasyon_acces_bagıntılı.KullanıcılarDataSetTableAdapters.BilgilerTableAdapter();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.ImageKey = "Hopstarter-Soft-Scraps-Button-Add.256.png";
            this.btn_ekle.ImageList = this.ımageList1;
            this.btn_ekle.Location = new System.Drawing.Point(6, 338);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(393, 41);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hopstarter-Soft-Scraps-Button-Add.256.png");
            this.ımageList1.Images.SetKeyName(1, "Kyo-Tux-Delikate-Close.512.png");
            this.ımageList1.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.256.png");
            this.ımageList1.Images.SetKeyName(3, "Seanau-Email-Clear.256.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üyeler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.lbl_yetki);
            this.groupBox1.Controls.Add(this.lbl_sifre);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.lbl_kullaniciAdi);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.lbl_olTarih);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.lbl_Soyisim);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_isim);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.btn_verileritemizle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 452);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜYE İŞLEMLERİ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(569, 191);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(226, 26);
            this.textBox7.TabIndex = 6;
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(455, 197);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(49, 20);
            this.lbl_yetki.TabIndex = 18;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(451, 121);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(50, 20);
            this.lbl_sifre.TabIndex = 16;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(569, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(226, 26);
            this.textBox6.TabIndex = 5;
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(451, 46);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(101, 20);
            this.lbl_kullaniciAdi.TabIndex = 14;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(184, 268);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(147, 26);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(569, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 26);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_olTarih
            // 
            this.lbl_olTarih.AutoSize = true;
            this.lbl_olTarih.Location = new System.Drawing.Point(32, 274);
            this.lbl_olTarih.Name = "lbl_olTarih";
            this.lbl_olTarih.Size = new System.Drawing.Size(128, 20);
            this.lbl_olTarih.TabIndex = 11;
            this.lbl_olTarih.Text = "Oluşturma Tarihi:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 26);
            this.textBox3.TabIndex = 2;
            // 
            // lbl_Soyisim
            // 
            this.lbl_Soyisim.AutoSize = true;
            this.lbl_Soyisim.Location = new System.Drawing.Point(32, 197);
            this.lbl_Soyisim.Name = "lbl_Soyisim";
            this.lbl_Soyisim.Size = new System.Drawing.Size(67, 20);
            this.lbl_Soyisim.TabIndex = 9;
            this.lbl_Soyisim.Text = "Soyisim:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 26);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(32, 121);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(46, 20);
            this.lbl_isim.TabIndex = 7;
            this.lbl_isim.Text = "İsim :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(32, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(31, 20);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "Id :";
            // 
            // btn_verileritemizle
            // 
            this.btn_verileritemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_verileritemizle.ImageKey = "Seanau-Email-Clear.256.png";
            this.btn_verileritemizle.ImageList = this.ımageList1;
            this.btn_verileritemizle.Location = new System.Drawing.Point(425, 405);
            this.btn_verileritemizle.Name = "btn_verileritemizle";
            this.btn_verileritemizle.Size = new System.Drawing.Size(393, 41);
            this.btn_verileritemizle.TabIndex = 10;
            this.btn_verileritemizle.Text = "Verileri Temizle";
            this.btn_verileritemizle.UseVisualStyleBackColor = true;
            this.btn_verileritemizle.Click += new System.EventHandler(this.btn_verileritemizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.ImageKey = "Kyo-Tux-Delikate-Close.512.png";
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(6, 405);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(393, 41);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.ImageKey = "Custom-Icon-Design-Pretty-Office-9-Edit-validated.256.png";
            this.btn_guncelle.ImageList = this.ımageList1;
            this.btn_guncelle.Location = new System.Drawing.Point(425, 338);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(393, 41);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(297, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ara :";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(378, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 32);
            this.textBox4.TabIndex = 1;
            // 
            // btn_yenile
            // 
            this.btn_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.Location = new System.Drawing.Point(441, 65);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 37);
            this.btn_yenile.TabIndex = 2;
            this.btn_yenile.Text = "Yenile ";
            this.btn_yenile.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.oluşturmaTarihiDataGridViewTextBoxColumn,
            this.kullanıcıAdıDataGridViewTextBoxColumn,
            this.şifreDataGridViewTextBoxColumn,
            this.yetkiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bilgilerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 247);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Width = 70;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "İsim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            // 
            // oluşturmaTarihiDataGridViewTextBoxColumn
            // 
            this.oluşturmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "OluşturmaTarihi";
            this.oluşturmaTarihiDataGridViewTextBoxColumn.HeaderText = "OluşturmaTarihi";
            this.oluşturmaTarihiDataGridViewTextBoxColumn.Name = "oluşturmaTarihiDataGridViewTextBoxColumn";
            this.oluşturmaTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kullanıcıAdıDataGridViewTextBoxColumn
            // 
            this.kullanıcıAdıDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.HeaderText = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.Name = "kullanıcıAdıDataGridViewTextBoxColumn";
            this.kullanıcıAdıDataGridViewTextBoxColumn.Width = 150;
            // 
            // şifreDataGridViewTextBoxColumn
            // 
            this.şifreDataGridViewTextBoxColumn.DataPropertyName = "Şifre";
            this.şifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.şifreDataGridViewTextBoxColumn.Name = "şifreDataGridViewTextBoxColumn";
            // 
            // yetkiDataGridViewTextBoxColumn
            // 
            this.yetkiDataGridViewTextBoxColumn.DataPropertyName = "Yetki";
            this.yetkiDataGridViewTextBoxColumn.HeaderText = "Yetki";
            this.yetkiDataGridViewTextBoxColumn.Name = "yetkiDataGridViewTextBoxColumn";
            // 
            // bilgilerBindingSource
            // 
            this.bilgilerBindingSource.DataMember = "Bilgiler";
            this.bilgilerBindingSource.DataSource = this.kullanıcılarDataSet;
            // 
            // kullanıcılarDataSet
            // 
            this.kullanıcılarDataSet.DataSetName = "KullanıcılarDataSet";
            this.kullanıcılarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgilerTableAdapter
            // 
            this.bilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_cikis.Location = new System.Drawing.Point(164, 873);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(1200, 63);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1006, 889);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 8);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Admin_Sayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1541, 939);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Sayfası";
            this.Text = "Admin_Sayfası";
            this.Load += new System.EventHandler(this.Admin_Sayfası_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_olTarih;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_Soyisim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_verileritemizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KullanıcılarDataSet kullanıcılarDataSet;
        private System.Windows.Forms.BindingSource bilgilerBindingSource;
        private KullanıcılarDataSetTableAdapters.BilgilerTableAdapter bilgilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oluşturmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button button3;
    }
}