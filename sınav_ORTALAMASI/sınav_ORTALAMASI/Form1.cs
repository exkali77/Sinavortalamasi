using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_ORTALAMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = Convert.ToString(textBox1.Text);
            int  toplam,s1 = Convert.ToInt32(textBox5.Text), s2 = Convert.ToInt32(textBox4.Text), s3 = Convert.ToInt32(textBox3.Text), s4 = Convert.ToInt32(textBox2.Text);
            if (textBox5.Text!="" && textBox4.Text!="" && textBox3.Text != "" && textBox2.Text != "" &&textBox1.Text!="" && comboBox1.Text!="" &&comboBox2.Text!="")
            {
              
             toplam = (s1 + s2 + s3 + s4) / 4;
                listBox1.Items.Add("AdıSoyadı :" + adsoyad + "   Sınıfı :" + comboBox2.Text + comboBox1.Text + "  sınav1 :" + s1 + "   sınav2 :" + s2 + "  sınav3 :" + s3 + "  sınav4 :" + s4 + "  Ortalaması :" + toplam);

            }
            else if (textBox5.Text ==""  && textBox4.Text == "" && textBox3.Text == "" && textBox2.Text == "" && textBox1.Text == "" && comboBox1.Text == "" && comboBox2.Text == "")
            {

                MessageBox.Show("Boş Alan Bırak Mayın");
            
            }
        }

        
    }
}
