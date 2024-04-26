using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Kütüphane_otomasyon_acces_bagıntılı.Model;

namespace Kütüphane_otomasyon_acces_bagıntılı
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\samet\\Desktop\\Databases\\Kullanıcılar.mdb");

        //veritabanı üzerinden kontrol işlemi yapmak için bir sorgu sınıfı oluşturuyoruz.
        public class veritabankontrol
        {
            public bool KullaniciDogrula(string KullanıcıAdı, string Şifre)
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\samet\\Desktop\\Databases\\Kullanıcılar.mdb";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    //tablo ismi üzerinden kontrol edilcek
                    string query = "SELECT COUNT(*) FROM Bilgiler WHERE KullanıcıAdı = @KullanıcıAdı AND Şifre = @Şifre";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@KullanıcıAdı", KullanıcıAdı);
                        command.Parameters.AddWithValue("@Şifre", Şifre);
                        

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }

            }
        }





        //veritabanını bağıntılama işlemi

        OleDbCommand komut = new OleDbCommand();



        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = string.Empty;
            txt_kullaniciad.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            //
            string KullanıcıAdı = txt_kullaniciad.Text;
            string Şifre = txt_sifre.Text;
           

            var veritabaniKontrol = new veritabankontrol();
            bool kullanicidogrulandi = veritabaniKontrol.KullaniciDogrula(KullanıcıAdı, Şifre);
          
            if (kullanicidogrulandi)//kullanıcı kayıtlarda varsa
            {
                if (KullanıcıAdı=="samet" || Şifre=="1")
                {
                    Admin_Sayfası admin_Sayfası = new Admin_Sayfası();
                    admin_Sayfası.Show();
                    this.Hide();
                    
                }
                else
                {
                    Üye_Sayfası üye_Sayfası = new Üye_Sayfası();
                    üye_Sayfası.Show();
                    this.Hide();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Hatalı giriş. Kullanıcı Adı ve Şifrenizi doğru girdiğinizden emin olun. Üye değilseniz üye olmak için 'Üye ol 'butonuna basınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }


}



