using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siniflar_1_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class araba
        {
            int hiz = 0, vites = 0;
            public void hizlan(int a)
            {
                hiz += a;
            }
            public void yavasla(int b)
            {
                hiz -= b;
            }
            public void vitesartir(int c)
            {
                vites += c;
            }
            public void vitesdusur(int d)
            {
                vites -= d;
            }
            public void bilgiler()
            {
                MessageBox.Show("Arabanın Hızı: " + hiz + "\nArabanın Vitesi: " + vites);
            }
        
        }

        araba mercedes = new araba();
        araba bmw = new araba();

        private void button1_Click(object sender, EventArgs e)
        {
            mercedes.hizlan(int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mercedes.yavasla(int.Parse(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mercedes.vitesartir(int.Parse(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mercedes.vitesdusur(int.Parse(textBox2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mercedes.bilgiler();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmw.hizlan(int.Parse(textBox1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bmw.yavasla(int.Parse(textBox1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bmw.vitesartir(int.Parse(textBox2.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bmw.vitesdusur(int.Parse(textBox2.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bmw.bilgiler();
        }
    }
}
