using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace siniflar_3_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Araba
        {
            int hiz = 0, vites = 0;

            public void hizlan()
            {
                if (hiz <200)
                    hiz += 10;
                if (hiz >= 0 && hiz < 20)
                    vites = 1;
                else if (hiz >= 20 && hiz < 50)
                    vites = 2;
                else if (hiz >= 50 && hiz < 80)
                    vites = 3;
                else if (hiz >= 80 && hiz < 130)
                    vites = 4;
                else if (hiz >= 130 && hiz < 200)
                    vites = 5;


            }
            public void yavasla()
            {
                if (hiz!=0)
                    hiz -= 10;
                if (hiz >= 0 && hiz < 20)
                    vites = 1;
                else if (hiz >= 20 && hiz < 50)
                    vites = 2;
                else if (hiz >= 50 && hiz < 80)
                    vites = 3;
                else if (hiz >= 80 && hiz < 130)
                    vites = 4;
                else if (hiz >= 130 && hiz < 200)
                    vites = 5;

            }
       
            public int bilgi1()
            {
                return hiz;
            }
            public int bilgi2()
            {
                return vites; 
            }

        }

        Araba volvo = new Araba();
        Araba opel = new Araba();
        Araba ferrari = new Araba();


        private void hizlan1_Click(object sender, EventArgs e)
        {
            volvo.hizlan();
        }

        private void yavaşla1_Click(object sender, EventArgs e)
        {
            volvo.yavasla();
        }

        private void bilgiler1_Click(object sender, EventArgs e)
        {
            int a = volvo.bilgi1();
            int b = volvo.bilgi2();
            textBox1.Text = "Arabanın Hızı: " + a.ToString() + "Arabanın Vitesi: " + b.ToString();
        }

        private void bilgiler2_Click(object sender, EventArgs e)
        {
            int a = opel.bilgi1();
            int b = opel.bilgi2();
            textBox2.Text = "Arabanın Hızı: " + a.ToString() + "Arabanın Vitesi: " + b.ToString();
        }

        private void bilgiler3_Click(object sender, EventArgs e)
        {
            int a = ferrari.bilgi1();
            int b = ferrari.bilgi2();
            textBox3.Text = "Arabanın Hızı: " + a.ToString() + "Arabanın Vitesi: " + b.ToString();
        }

        private void Hızlan2_Click(object sender, EventArgs e)
        {
            opel.hizlan();
        }

        private void yavaşla2_Click(object sender, EventArgs e)
        {
            opel.yavasla();
        }

        private void hizlan3_Click(object sender, EventArgs e)
        {
            ferrari.hizlan();
        }

        private void yavaşla3_Click(object sender, EventArgs e)
        {
            ferrari.yavasla();
        }
    }
}
