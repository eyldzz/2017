using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_3_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Calisanlar
        {
            public int mesaiucreti = 0;

        }
        class Mudur : Calisanlar
        {
            public int odenecekucret(int a, int b)
            {
                mesaiucreti = a * b;
                return mesaiucreti;
            }
        }

        class Usta : Calisanlar
        {
            public int odenecekucret(int a, int b)
            {
                mesaiucreti = a * b;
                return mesaiucreti;
            }
        }

        class Cirak : Calisanlar
        {
            public int odenecekucret(int a,int b)
            {
                mesaiucreti = a * b;
                return mesaiucreti;
            }
        }
        Mudur mudur = new Mudur();
        Usta usta = new Usta();
        Cirak cirak = new Cirak();


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int zaman = int.Parse(textBox1.Text), a=0;
            if (radioButton1.Checked && radioButton4.Checked)
                a = cirak.odenecekucret(8,int.Parse(textBox1.Text));
            else if (radioButton1.Checked && radioButton5.Checked)
                a = cirak.odenecekucret(7, int.Parse(textBox1.Text));
            else if (radioButton2.Checked && radioButton4.Checked)
                a = usta.odenecekucret(10, int.Parse(textBox1.Text));
            else if (radioButton2.Checked && radioButton5.Checked)
                a = usta.odenecekucret(9, int.Parse(textBox1.Text));
            else if (radioButton3.Checked && radioButton4.Checked)
                a = mudur.odenecekucret(12, int.Parse(textBox1.Text));
            else if (radioButton3.Checked && radioButton5.Checked)
                a = mudur.odenecekucret(11, int.Parse(textBox1.Text));
            textBox2.Text = a.ToString();
            
        }
    }
}
