using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62.ORN.Sayisal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rstg = new Random();

            int sayi1 = rstg.Next(0, 10);
            int sayi2 = rstg.Next(0, 10);
            int sayi3 = rstg.Next(0, 10);
            int sayi4 = rstg.Next(0, 10);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();

            int g_sayi1 = Convert.ToInt32(textBox1.Text);
            int g_sayi2 = Convert.ToInt32(textBox2.Text);
            int g_sayi3 = Convert.ToInt32(textBox3.Text);
            int g_sayi4 = Convert.ToInt32(textBox4.Text);

            if (g_sayi1 == sayi1)
            {
                if (g_sayi2 == sayi2)
                {
                    if (g_sayi3 == sayi3)
                    {
                        if (g_sayi4 == sayi4)
                        {
                            label6.Text = "Tebrikler! Büyük Ödülü Kazandınız.";
                        }
                    }
                }
            }
            else
            {
                label6.Text = "Üzgünüz! Büyük Ödülü Kazanamadınız.";
            }
        }
    }
}
