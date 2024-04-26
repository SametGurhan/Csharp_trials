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

namespace _25_sifirdan_acces_veritabani_baglama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //kod ile db baglamak
        //adres baglarken \ ları \\ seklinde kullan yoksa hata verir.
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\samet\\Desktop\\Databases\\Kişiler.mdb");

        //komut icin
        OleDbCommand komut = new OleDbCommand();
        //silme icin komut temeli atalım

        private void verilerigörüntüle()
        {
            listView1.Items.Clear();

            baglantı.Open();
            //komut verelim
            OleDbCommand komut = new OleDbCommand();
            //verilen komutu baglantı ile iliskilendirelim
            komut.Connection = baglantı;
            komut.CommandText = ("Select * From Bilgiler");
            //ExecuteReader(); veri tabanından select sort ile cekilen komutların veri akısını saglar
            OleDbDataReader oku = komut.ExecuteReader();
           
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["İl"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Bilgiler(Id,Ad,Soyad,Ücret,İl) values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+ "','"+textBox4.Text.ToString()+ "','" + textBox5.Text.ToString() +"')",baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            //anında refresh icin tekrar görüntülesin.
            verilerigörüntüle();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            // kişiler mdb belgesindeki bilgiler tablosundan silecek:
            komut.Connection = baglantı;
            komut.CommandText="DELETE FROM Bilgiler WHERE Id = '" + textBox6.Text + "'";
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();
            textBox6.Clear();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText=" update Bilgiler set Ad='" +textBox2.Text+"',Soyad='"+ textBox3.Text + "',Ücret='" +textBox4.Text+"',İl='"+textBox5.Text+ "' where Id='" +textBox1.Text+"'";
            komut.ExecuteNonQuery();
            
            baglantı.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
            verilerigörüntüle();

        } 
    }
}
