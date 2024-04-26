using Kütüphane_otomasyon_acces_bagıntılı.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_otomasyon_acces_bagıntılı
{
    public partial class Admin_Sayfası : Form
    {
        //veritaban linki:  "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\samet\\Desktop\\Databases\\Kullanıcılar.mdb"
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private BindingSource bindingSource;

        public Admin_Sayfası()
        {
            InitializeComponent();

            //verit. baglantısı.
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\samet\\Desktop\\Databases\\Kullanıcılar.mdb";
            connection = new OleDbConnection(connectionString);

            // Veritabanından verileri çekmek için OleDbDataAdapter kullanın
            dataAdapter = new OleDbDataAdapter("SELECT * FROM bilgiler", connection);
            dataTable = new DataTable();

            // Verileri DataTable'a doldurun
            dataAdapter.Fill(dataTable);

            //Bileşen BindingSource , denetimleri temel alınan bir veri kaynağına bağlama işlemini basitleştirmek için tasarlanmıştır.
            // Bileşen, BindingSource diğer denetimlerin bağlanması için hem kanal hem de veri kaynağı işlevi görür
            // BindingSource ile DataTable'ı bağlayın
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            // DataGridView ile BindingSource'ı bağlayın
            dataGridView1.DataSource = bindingSource;


        }

        private void Admin_Sayfası_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kullanıcılarDataSet.Bilgiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // kısaca  VerileriGöster();

            dataTable.Clear();
            dataAdapter.Fill(dataTable);
        }
        public void kutularıdoldur()
        {
            // cell click eventi;



            if (dataGridView1.CurrentRow.Cells[0] != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {

                MessageBox.Show("Hata");
            }

        }
        private void verilerigöster()
        {
            dataTable.Clear();
            dataAdapter.Fill(dataTable);
        }
        private void Kutularitemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();


        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kutularıdoldur();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği değerleri alın
                string Id = textBox1.Text;
                string isim = textBox2.Text;
                string soyisim = textBox3.Text;
                string olusturmaTarihi = DateTime.Now.ToString("yyyy-MM-dd"); // Access için uygun tarih biçimi yyyy-MM-dd HH:mm:ss
                string kullaniciAdi = textBox5.Text;
                string sifre = textBox6.Text;
                string yetki = textBox7.Text;

                // Veritabanına yeni kayıt ekleme SQL veya acces uyumlu  komutu
                string insertQuery = $"INSERT INTO bilgiler (Id,İsim, Soyisim, OluşturmaTarihi, KullanıcıAdı, Şifre, Yetki) " +
                                     $"VALUES ('{Id}','{isim}', '{soyisim}', '{olusturmaTarihi}', '{kullaniciAdi}', '{sifre}', '{yetki}')";

                // SQL veya acces komutunu çalıştırın
                connection.Open();
                OleDbCommand command = new OleDbCommand(insertQuery, connection);
                command.ExecuteNonQuery();

                // DataGridView'a yeni kayıt eklemek için DataTable'ı güncelleyin
                DataRow newRow = dataTable.NewRow();


                newRow["Id"] = Id;
                newRow["İsim"] = isim;
                newRow["Soyisim"] = soyisim;
                newRow["OluşturmaTarihi"] = olusturmaTarihi;
                newRow["KullanıcıAdı"] = kullaniciAdi;
                newRow["Şifre"] = sifre;
                newRow["Yetki"] = yetki;
                dataTable.Rows.Add(newRow);


                MessageBox.Show("Yeni kayıt eklendi.");

                // TextBox'ları temizle
                Kutularitemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            //textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, textBox5.Text, textBox6.Text, textBox7.Text




        }
        OleDbCommand komut = new OleDbCommand();
        

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                komut.Connection = connection;
                //DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                //(Id,İsim, Soyisim, OluşturmaTarihi, KullanıcıAdı, Şifre, Yetki)
                komut.CommandText = "update bilgiler set İsim='" + textBox2.Text + "',Soyisim='" + textBox3.Text + "',OluşturmaTarihi='" + maskedTextBox1.Text+ "',KullanıcıAdı='"+textBox5.Text + "',Şifre='"+textBox6.Text+ "',Yetki='" + textBox7.Text +"'where Id='"+ textBox1.Text+ "'";
                komut.ExecuteNonQuery();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

                kutularıdoldur();
                verilerigöster();

                MessageBox.Show("Kayıt başarıyla güncellendi.");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                komut.Connection = connection;
                //DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                komut.CommandText = "delete from bilgiler where Id='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                kutularıdoldur();
                verilerigöster();
                Kutularitemizle();

                MessageBox.Show("Kayıt başarıyla silindi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata:"+ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_verileritemizle_Click(object sender, EventArgs e)
        {
            Kutularitemizle();
        }
    }
}
