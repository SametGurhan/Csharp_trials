using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group.box.nesnekullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt eklendi:)");
            /*txt_isim.Text = string.Empty;    
            txt_soyisim.Text = string.Empty;    
            txt_mail.Text = string.Empty;    
            txt_tel.Text = string.Empty;
            txt_hobi.Text = string.Empty;
            önerilmeyen temizleme yoludur___
            */
            for(int i=0 ; i<groupBox1.Controls.Count;i++)
            {
                if(groupBox1.Controls[i]is TextBox)
                { groupBox1.Controls[i].Text = string.Empty;  }

            }


        }
    }
}
