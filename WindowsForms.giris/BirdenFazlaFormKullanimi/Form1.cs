using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaFormKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string KullanıcıAdi, Sifre = "";
            KullanıcıAdi = ad_txt.Text;
            Sifre = sfr_text.Text;
            if(KullanıcıAdi== "Samet" && Sifre=="123")
            {
                //Farklı bir forma yönlendirecek.
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.lbl2.Text = KullanıcıAdi.ToUpper();
                anasayfa.Show();
                //this.Hide(); (sadece saklar)
            }
            else 
            {
                MessageBox.Show("Hatalı giriş yaptınız", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
