using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kapsulleme_4_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Sekil
        {
            int kenar1, kenar2, kenar3;
            public int KENAR1
            {
                get { return kenar1; }
                set
                {
                    if (value < 0)
                        kenar1 = value * -1;
                    else
                        kenar1 = value;
                }
            }
            public int KENAR2
            {
                get { return kenar2; }
                set
                {
                    if (value < 0)
                        kenar2 = value * -1;
                    else
                        kenar2 = value;
                }
            }
            public int KENAR3
            {
                get { return kenar3; }
                set
                {
                    if (value < 0)
                        kenar3 = value * -1;
                    else
                        kenar3 = value;
                }
            }
            public string turunubul(int a, int b, int c)
            {           
                if (a == b && b == c)
                { return "Eşkenar"; }
                else if (a == b || b == c || a == c)
                { return "İkizKenar"; }
                else
                { return "ÇeşitKenar"; }
            }
        }

        Sekil ucgen = new Sekil();

        private void button1_Click(object sender, EventArgs e)
        {
            ucgen.KENAR1 = int.Parse(textBox1.Text);
            ucgen.KENAR2 = int.Parse(textBox2.Text);
            ucgen.KENAR3 = int.Parse(textBox3.Text);
            textBox4.Text = ucgen.turunubul(ucgen.KENAR1, ucgen.KENAR2, ucgen.KENAR3);

        }
    }
}
