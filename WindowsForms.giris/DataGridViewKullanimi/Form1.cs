using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_göster_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Samet", "Gürhan", 1);
            dataGridView1.Rows.Add("Bilal", "Akıncı", 2);
            dataGridView1.Rows.Add("Enes", "Sert", 3);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string isim = textBox2.Text;
            string soyisim = textBox3.Text;
            dataGridView1.Rows.Add( isim, soyisim,id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           string id= dataGridView1.CurrentRow.Cells[0].Value.ToString();
           string isim= dataGridView1.CurrentRow.Cells[1].Value.ToString();
           string soyisim= dataGridView1.CurrentRow.Cells[2].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = isim;
            textBox3.Text = soyisim;


        
        }
    }
}
