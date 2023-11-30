using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace siniflar_4_uygulama 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Musteri
        {
            int borc = 0;
            public void borcartir(string x)
            {
                if (x == "Gömlek")
                    borc += 25;
                else if (x == "Kravat")
                    borc += 15;
                else if (x == "Pantolon")
                    borc += 55;
                else if (x == "Ceket")
                    borc += 130;
                
            }
            public void borcazalt(int a)
            {
                borc -= a;
            }

            public void bilgiler()
            {
                MessageBox.Show("Borcunuz: " + borc);
            }

        }

        Musteri Hakan = new Musteri();
        Musteri Gonca = new Musteri();
        Musteri Seyfullah = new Musteri();


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Gömlek");
            comboBox1.Items.Add("Kravat");
            comboBox1.Items.Add("Pantolon");
            comboBox1.Items.Add("Ceket");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Hakan.borcartir(comboBox1.Text);
            else if (radioButton2.Checked)
                Gonca.borcartir(comboBox1.Text);
            else if (radioButton3.Checked)
                Seyfullah.borcartir(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Hakan.borcazalt(int.Parse(textBox1.Text));
            else if (radioButton2.Checked)
                Gonca.borcazalt(int.Parse(textBox1.Text));
            else if (radioButton3.Checked)
                Seyfullah.borcazalt(int.Parse(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Hakan.bilgiler();
            else if (radioButton2.Checked)
                Gonca.bilgiler();
            else if (radioButton3.Checked)
                Seyfullah.bilgiler();
        }
    }
}