using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox.nesnekullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int tutar = 0;
            if (checkBox_cay.Checked)
            {
                tutar += 2;
            }
            if (checkBox_kahve.Checked)
            {
                tutar += 4;
            }
            if (checkBox_hamburger.Checked)
            {
                tutar += 10;
            }
            if (checkBox_pizza.Checked)
            {
                tutar += 25;
            }

            lbl_tutar.Text = tutar.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}