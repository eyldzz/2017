using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace siniflar_2_uygulama
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
               if(hiz <200)
                hiz += 10;
            }
            public void yavasla()
            {
                if (hiz != 0)
                 hiz -= 10;
            }
            public void vitesartir()
            {
                if (vites != 6)
                    vites += 1;
            }
            public void vitesdusur()
            {
                if (vites != 0)
                    vites -= 1;
            } 
            public void bilgiler(int x)
            {
                MessageBox.Show(x + ". Arabanın Hızı: " + hiz + "\n" + x+".Arabanın Vitesi: " + vites);
            }
        }

        Araba volvo = new Araba();
        Araba opel = new Araba();


        private void button1_Click(object sender, EventArgs e)
        {
            volvo.hizlan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            volvo.yavasla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            volvo.vitesartir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            volvo.vitesdusur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            volvo.bilgiler(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            opel.hizlan();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            opel.yavasla();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opel.vitesartir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            opel.vitesdusur();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            opel.bilgiler(2);
        }
    }
}
