using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_1_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Araba
        { 
            public int hiz = 0, vites =0;

            public void bilgiler()
            { 
               MessageBox.Show("Hızınız: " + hiz +"\nVitesiniz: " + vites);
            
            }
        
        }


        class Otomobil : Araba
        {
            public void hizlan()
            {
                if (hiz < 240)
                    hiz += 20;
                if (hiz >= 0 && hiz < 39)
                    vites = 1;
                else if (hiz >= 40 && hiz < 79)
                    vites = 2;
                else if (hiz >= 80 && hiz < 119)
                    vites = 3;
                else if (hiz >= 120 && hiz < 159)
                    vites = 4;
                else if (hiz >= 120 && hiz <= 240)
                    vites = 5;
            }
            public void yavasla()
            {
                if (hiz > 0)
                    hiz -= 10;
                if (hiz >= 0 && hiz < 39)
                    vites = 1;
                else if (hiz >= 40 && hiz < 79)
                    vites = 2;
                else if (hiz >= 80 && hiz < 119)
                    vites = 3;
                else if (hiz >= 120 && hiz < 159)
                    vites = 4;
                else if (hiz >= 160 && hiz <= 240)
                    vites = 5;
            }

        }

        class Otobus : Araba
        {
            public void hizlan()
            {
                if (hiz <150)
                    hiz += 10;
                if (hiz >= 0 && hiz < 29)
                    vites = 1;
                else if (hiz >= 30 && hiz < 59)
                    vites = 2;
                else if (hiz >= 60 && hiz < 89)
                    vites = 3;
                else if (hiz >= 90 && hiz < 119)
                    vites = 4;
                else if (hiz >= 120 && hiz <= 150)
                    vites = 5;
            }
            public void yavasla()
            {
                if (hiz > 0)
                    hiz -= 10;
                if (hiz >= 0 && hiz < 39)
                    vites = 1;
                else if (hiz >= 30 && hiz < 59)
                    vites = 2;
                else if (hiz >= 60 && hiz < 89)
                    vites = 3;
                else if (hiz >= 90 && hiz < 119)
                    vites = 4;
                else if (hiz >= 120 && hiz <= 150)
                    vites = 5;
            }
        
        }

        class Kamyon : Araba
        {
            public void hizlan()
            {
                if (hiz < 98)
                    hiz += 7;
                if (hiz >= 0 && hiz < 20)
                    vites = 1;
                else if (hiz >= 21 && hiz < 34)
                    vites = 2;
                else if (hiz >= 35 && hiz < 48)
                    vites = 3;
                else if (hiz >= 49 && hiz < 62)
                    vites = 4;
                else if (hiz >= 63 && hiz <= 98)
                    vites = 5;
            }
            public void yavasla()
            {
                if (hiz > 0)
                    hiz -= 10;
                if (hiz >= 0 && hiz < 20)
                    vites = 1;
                else if (hiz >= 21 && hiz < 34)
                    vites = 2;
                else if (hiz >= 35 && hiz < 48)
                    vites = 3;
                else if (hiz >= 49 && hiz < 62)
                    vites = 4;
                else if (hiz >= 63 && hiz <= 98)
                    vites = 5;
                if (hiz < 0)
                    hiz = 0;
            }
        
        }

        Otomobil ford = new Otomobil();
        Kamyon dodge = new Kamyon();
        Otobus neoplan = new Otobus();





        private void btnArabaHizlan_Click(object sender, EventArgs e)
        {
            ford.hizlan();
        }

        private void btnArabaYavasla_Click(object sender, EventArgs e)
        {
            ford.yavasla();
        }

        private void btnArabaBilgiler_Click(object sender, EventArgs e)
        {
            ford.bilgiler();
        }

        private void btnOtobusHizlan_Click(object sender, EventArgs e)
        {
            neoplan.hizlan();
        }

        private void btnOtobusYavasla_Click(object sender, EventArgs e)
        {
            neoplan.yavasla();
        }

        private void btnOtobusBilgiler_Click(object sender, EventArgs e)
        {
            neoplan.bilgiler();
        }

        private void btnKamyonHizlan_Click(object sender, EventArgs e)
        {
            dodge.hizlan();
        }

        private void btnKamyonYavasla_Click(object sender, EventArgs e)
        {
            dodge.yavasla();
        }

        private void btnKamyonBilgiler_Click(object sender, EventArgs e)
        {
            dodge.bilgiler();
        }

 
    }
}
