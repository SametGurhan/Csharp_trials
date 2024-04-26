using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Rows.Add(1,"Samet","Gürhan");
            dataGridView1.Rows.Add(2,"Enes","Hızlı");
            dataGridView1.Rows.Add(3,"Bilal","Çamur");
        
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string isim = textBox2.Text;
            string soyisim = textBox3.Text;

            dataGridView1.Rows.Add(id,isim,soyisim);

            MessageBox.Show("Kayıt eklendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soyisim = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = isim;
            textBox3.Text = soyisim;
            
        }

        private void dataGridView1_RowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            MessageBox.Show("Kayıt silindi.");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string isim = textBox2.Text;
            string soyisim = textBox3.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim);
            MessageBox.Show("Kayıt Güncellendi.");

        }
    }
}
