using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1,"Samet", "Gürhan", DateTime.Now, "samet", "1", "admin"));
            kisilerim.Add(new Kisi(2,"Yakup","Reçber",DateTime.Now,"yakup","2","uye"));
            kisilerim.Add(new Kisi(3,"Bilal","çamur",DateTime.Now,"bilal","3","uye"));
            kisilerim.Add(new Kisi(4,"Yasin","Yazıcı",DateTime.Now,"yasin","4","uye"));

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text= string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_grs_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;

            foreach(Kisi kisi in kisilerim)
            {
                if(kullaniciAdi.ToLower()==kisi.getKullaniciAdi() && sifre.ToLower()==kisi.getSifre && kisi.getYetki=="admin")
                {
                    //admin sayfasına yönlendir 
                    AdminSayfasi adminSayfasi = new AdminSayfasi();
                    adminSayfasi.Show();
                    this.Hide();

                }
                else if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre && kisi.getYetki == "uye")
                {
                    UyeSayfası uyeSayfası = new UyeSayfası();
                    uyeSayfası.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                        
            }



        }
    }
}
