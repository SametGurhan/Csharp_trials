using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.giris
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

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Perşembe");

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = textBox1.Text;
            listBox1.Items.Add(gun);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string silinecek = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(silinecek);

           // string silinecek2 = listBox1.Items[listBox1.SelectedIndex].ToString();
           //listBox1.Items.Remove(silinecek2);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listbox count değeri: " + listBox1.Items.Count.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Listbox temizlendi..."); 
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
