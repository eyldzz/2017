using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kapsulleme_3_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Calisan
        {
            double cocuksayisi, maas , parcayardimi;

            public double MAAS
            {
                get { return maas; }
                set
                {
                    if (value < 0)
                        maas = value * -1;
                    else
                    maas = value;
                    
                }
            }

            public double COCUKYARDIMI
            {
                get { return cocuksayisi; }
                set
                {
                    if (value < 0)
                        cocuksayisi =value * -1;
                    else
                    cocuksayisi = value;
                }
            }

            public double PARCAYARDIMI
            {
                get { return parcayardimi; }
                set
                {
                    if (value < 0)
                       parcayardimi =value * -1;
                    else
                     parcayardimi = value;
                }
            }
            public double cocukyardimihesapla(double a,double b)
            {
                if (a == 1)
                    cocuksayisi = b * 0.02;
                else if (a == 2 || a == 3)
                    cocuksayisi = b * 0.04;
                else if (a > 3)
                    cocuksayisi = b * 0.10;
                return cocuksayisi;
            }
            public double parcayardimihesapla(double a)
            {
                if (a > 0 && a <= 99)
                    parcayardimi = 50;
                else if (a >= 100 && a <= 499)
                    parcayardimi = 150;
                else if (a >= 500)
                    parcayardimi = 250;
                return parcayardimi;
            }

            public double toplammaas(double a, double b, double c)
            {
                maas = a + b + c;
                return maas;
            }
        }

        Calisan personel = new Calisan();


        private void btnCocukYardimUcreti_Click(object sender, EventArgs e)
        {
            personel.COCUKYARDIMI = double.Parse(textBox2.Text);
            textBox4.Text = personel.cocukyardimihesapla(personel.COCUKYARDIMI, double.Parse(textBox1.Text)).ToString();
        }

        private void btnParcaUcreti_Click(object sender, EventArgs e)
        {
            personel.PARCAYARDIMI = double.Parse(textBox3.Text);
            textBox5.Text = personel.parcayardimihesapla(personel.PARCAYARDIMI).ToString();
        }

        private void btnMaasGoster_Click(object sender, EventArgs e)
        {
            personel.MAAS = double.Parse(textBox1.Text);
            textBox6.Text = personel.toplammaas(personel.COCUKYARDIMI, personel.PARCAYARDIMI, personel.MAAS).ToString();

        }




    }
}
