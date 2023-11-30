using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_8_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Tanklar
        {
            public int hiz = 0, zirh = 0, menzil = 0, guc = 0;
            public int hizbilgisi()
            {
                return hiz;
            }
            public int gucbilgisi()
            {
                return guc;
            }
            public int zirhbilgisi()
            {
                return zirh;
            }
            public int menzilbilgisi()
            {
                return menzil;
            }
            
        }
        class Prisma : Tanklar
        {
            public void hizlan(int a)
            {
                if (hiz < 70)
                {
                    hiz += a;
                    if (hiz >= 0 && hiz < 20)
                        guc = 6;
                    else if (hiz >= 20 && hiz < 40)
                        guc = 5;
                    else if (hiz >= 40 && hiz <= 70)
                        guc = 4;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                {
                    hiz -= a;
                    if (hiz >= 0 && hiz < 20)
                        guc = 6;
                    else if (hiz >= 20 && hiz < 40)
                        guc = 5;
                    else if (hiz >= 40 && hiz <= 70)
                        guc = 4;
                } 
            }

            public void zirhArtir()
            {
                if (zirh < 5)
                {
                    if (zirh < 3)
                        zirh = 3;
                    zirh += 1;
                    if (zirh == 5)
                        menzil = 500;
                    else if (zirh == 4)
                        menzil = 600;
                    else if (zirh == 3)
                        menzil = 700;
                }
            }

            public void zirhDusur()
            {
                if (zirh > 3)
                {
                    zirh -= 1;
                    if (zirh == 5)
                        menzil = 500;
                    else if (zirh == 4)
                        menzil = 600;
                    else if (zirh == 3)
                        menzil = 700;
                }
            }
            
        }

////////////////////////////////

        class IFV : Tanklar
        {
            public void hizlan(int a)
            {
                if (hiz < 90)
                {
                    hiz += a;
                    if (hiz > 0 && hiz < 30)
                        guc = 4;
                    else if (hiz >= 30 && hiz < 60)
                        guc = 3;
                    else if (hiz >= 60 && hiz < 90)
                        guc = 2;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                {
                    hiz -= a;
                    if (hiz > 0 && hiz < 30)
                        guc = 4;
                    else if (hiz >= 30 && hiz < 60)
                        guc = 3;
                    else if (hiz >= 60 && hiz < 90)
                        guc = 2;
                }
            }

            public void zirhArtir()
            {
                if (zirh < 4)
                {
                    if (zirh < 2)
                        zirh = 2;
                    zirh += 1;
                    if (zirh == 4)
                        menzil = 600;
                    else if (zirh == 3)
                        menzil = 700;
                    else if (zirh == 2)
                        menzil = 800;
                }
            }

            public void zirhDusur()
            {
                if (zirh > 2)
                {
                    zirh -= 1;
                    if (zirh == 4)
                        menzil = 600;
                    else if (zirh == 3)
                        menzil = 700;
                    else if (zirh == 2)
                        menzil = 800;
                }
            }
        }
/// /////////////////////////////////////////////////////

        class Grizzly : Tanklar
        {
            public void hizlan(int a)
            {
                if (hiz < 100)
                {
                    hiz += a;
                    if (hiz > 0 && hiz < 50)
                        guc = 3;
                    else if (hiz >= 50 && hiz < 100)
                        guc = 2;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                {
                    hiz -= a;
                    if (hiz > 0 && hiz < 50)
                        guc = 3;
                    else if (hiz >= 50 && hiz < 100)
                        guc = 2;
                }
            }

            public void zirhArtir()
            {
                if (zirh < 2)
                {
                    if (zirh < 1)
                        zirh = 1;
                    zirh += 1;
                    if (zirh == 2)
                        menzil = 800;
                    else if (zirh == 1)
                        menzil = 900;
                }
            }

            public void zirhDusur()
            {
                if (zirh > 1)
                {
                    zirh -= 1;
                    if (zirh == 2)
                        menzil = 800;
                    else if (zirh == 1)
                        menzil = 900;
                }
            }
        }

////////////////////////////////////////////////////

        class Mirage : Tanklar
        {
            
            public void hizlan(int a)
            {
                if (hiz < 75)
                {
                    hiz += a;
                    if (hiz > 0 && hiz < 25)
                        guc = 5;
                    else if (hiz >= 25 && hiz < 50)
                        guc = 4;
                    else if (hiz >= 50 && hiz < 75)
                        guc = 3;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                {
                    hiz -= a;
                    if (hiz > 0 && hiz < 25)
                        guc = 5;
                    else if (hiz >= 25 && hiz < 50)
                        guc = 4;
                    else if (hiz >= 50 && hiz < 75)
                        guc = 3;
                }
            }

            public void zirhArtir()
            {
                if (zirh < 3)
                {
                    if (zirh < 1)
                        zirh = 1;
                    zirh += 1;
                    if (zirh == 3)
                        menzil = 550;
                    else if (zirh == 2)
                        menzil = 650;
                    else if (zirh == 1)
                        menzil = 750;
                }
            }

            public void zirhDusur()
            {
                if (zirh > 3)
                {
                    zirh -= 1;
                    if (zirh == 3)
                        menzil = 550;
                    else if (zirh == 2)
                        menzil = 650;
                    else if (zirh == 1)
                        menzil = 750;
                }
            }
        }


        Prisma Taha = new Prisma();
        Grizzly Berkay = new Grizzly();
        Grizzly Ali = new Grizzly();
        IFV Suleyman = new IFV();
        Mirage Osman = new Mirage();
        Mirage Kadir = new Mirage();

        private void btnHizlan_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                hizz = 5;
            else if (radioButton2.Checked)
                hizz = 10;
            else if (radioButton3.Checked)
                hizz = 15;

            if (radiobtnSuleyman.Checked)
            {
                Suleyman.hizlan(hizz);
            }
            else if (radiobtnTaha.Checked)
            {
                Taha.hizlan(hizz);
            }
            else if (radiobtnOsman.Checked)
            {
                Osman.hizlan(hizz);
            }
            else if (radiobtnKadir.Checked)
            {
                Kadir.hizlan(hizz);
            }
            else if (radiobtnBerkay.Checked)
            {
                Berkay.hizlan(hizz);
            }
            else if (radiobtnAli.Checked)
            {
                Ali.hizlan(hizz);
            }
           
        }
        int hizz;
        private void btnYavasla_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                hizz = 5;
            else if (radioButton2.Checked)
                hizz = 10;
            else if (radioButton3.Checked)
                hizz = 15;

            if (radiobtnSuleyman.Checked)
            {
                Suleyman.yavasla(hizz);
            }
            else if (radiobtnTaha.Checked)
            {
                Taha.yavasla(hizz);
            }
            else if (radiobtnOsman.Checked)
            {
                Osman.yavasla(hizz);
            }
            else if (radiobtnKadir.Checked)
            {
                Kadir.yavasla(hizz);
            }
            else if (radiobtnBerkay.Checked)
            {
                Berkay.yavasla(hizz);
            }
            else if (radiobtnAli.Checked)
            {
                Ali.yavasla(hizz);
            }
        }

        private void btnZirhArtir_Click(object sender, EventArgs e)
        {
            if (radiobtnSuleyman.Checked)
            {
                Suleyman.zirhArtir();
            }
            else if (radiobtnTaha.Checked)
            {
                Taha.zirhArtir();
            }
            else if (radiobtnOsman.Checked)
            {
                Osman.zirhArtir();
            }
            else if (radiobtnKadir.Checked)
            {
                Kadir.zirhArtir();
            }
            else if (radiobtnBerkay.Checked)
            {
                Berkay.zirhArtir();
            }
            else if (radiobtnAli.Checked)
            {
                Ali.zirhArtir();
            }
        }

        private void btnZirhDusur_Click(object sender, EventArgs e)
        {
            if (radiobtnSuleyman.Checked)
            {
                Suleyman.zirhDusur();
            }
            else if (radiobtnTaha.Checked)
            {
                Taha.zirhDusur();
            }
            else if (radiobtnOsman.Checked)
            {
                Osman.zirhDusur();
            }
            else if (radiobtnKadir.Checked)
            {
                Kadir.zirhDusur();
            }
            else if (radiobtnBerkay.Checked)
            {
                Berkay.zirhDusur();
            }
            else if (radiobtnAli.Checked)
            {
                Ali.zirhDusur();
            }
        }

        private void btnGucGoster_Click(object sender, EventArgs e)
        {
            int a = 1;

            if (radiobtnSuleyman.Checked)
            {
                a = Suleyman.gucbilgisi();
            }
            else if (radiobtnTaha.Checked)
            {
                a = Taha.gucbilgisi();
            }
            else if (radiobtnOsman.Checked)
            {
                a = Osman.gucbilgisi();
            }
            else if (radiobtnKadir.Checked)
            {
                a = Kadir.gucbilgisi();
            }
            else if (radiobtnBerkay.Checked)
            {
                a = Berkay.gucbilgisi();
            }
            else if (radiobtnAli.Checked)
            {
                a = Ali.gucbilgisi();
            }
            textBox1.Text = a.ToString();
        }

        private void btnHizGoster_Click(object sender, EventArgs e)
        {
            int a = 1;

            if (radiobtnSuleyman.Checked)
            {
                a = Suleyman.hizbilgisi();
            }
            else if (radiobtnTaha.Checked)
            {
                a = Taha.hizbilgisi();
            }
            else if (radiobtnOsman.Checked)
            {
                a = Osman.hizbilgisi();
            }
            else if (radiobtnKadir.Checked)
            {
                a = Kadir.hizbilgisi();
            }
            else if (radiobtnBerkay.Checked)
            {
                a = Berkay.hizbilgisi();
            }
            else if (radiobtnAli.Checked)
            {
                a = Ali.hizbilgisi();
            }
            textBox2.Text = a.ToString();
        }

        private void btnZirhGoster_Click(object sender, EventArgs e)
        {
            int a = 1;
            if (radiobtnSuleyman.Checked)
            {
                a = Suleyman.zirhbilgisi();
            }
            else if (radiobtnTaha.Checked)
            {
                a = Taha.zirhbilgisi();
            }
            else if (radiobtnOsman.Checked)
            {
                a = Osman.zirhbilgisi();
            }
            else if (radiobtnKadir.Checked)
            {
                a = Kadir.zirhbilgisi();
            }
            else if (radiobtnBerkay.Checked)
            {
                a = Berkay.zirhbilgisi();
            }
            else if (radiobtnAli.Checked)
            {
                a = Ali.zirhbilgisi();
            }
            textBox3.Text = a.ToString();
        }

        private void btnMenzil_Click(object sender, EventArgs e)
        {
            int a = 1;
            if (radiobtnSuleyman.Checked)
            {
                a = Suleyman.menzilbilgisi();
            }
            else if (radiobtnTaha.Checked)
            {
                a = Taha.menzilbilgisi();
            }
            else if (radiobtnOsman.Checked)
            {
                a = Osman.menzilbilgisi();
            }
            else if (radiobtnKadir.Checked)
            {
                a = Kadir.menzilbilgisi();
            }
            else if (radiobtnBerkay.Checked)
            {
                a = Berkay.menzilbilgisi();
            }
            else if (radiobtnAli.Checked)
            {
                a = Ali.menzilbilgisi();
            }
            textBox4.Text = a.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
