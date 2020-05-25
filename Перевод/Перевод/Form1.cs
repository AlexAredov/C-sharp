using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПЕРЕВОД
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pr = 0;
            string s = textBox1.Text;
            bool prov = false;
            if (textBox1.Text != "")
            {
                for (int i = 0; Convert.ToInt32(s) != 0; i++)
                {
                    pr = Convert.ToInt32(s) % 10;
                    s = Convert.ToString(Convert.ToInt32(s) / 10);
                    if (pr > 1)
                    {
                        prov = true;
                    }
                }
                if (prov)
                {
                    textBox2.Text = "Error";
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        Class1 Perevod = new Class1(2, textBox1.Text);
                        textBox2.Text = Perevod.perevod();
                    }
                    if (radioButton2.Checked)
                    {
                        Class1 Perevod = new Class1(8, textBox1.Text);
                        textBox2.Text = Perevod.perevod();
                    }
                    if (radioButton3.Checked)
                    {
                        Class1 Perevod = new Class1(10, textBox1.Text);
                        textBox2.Text = Perevod.perevod();
                    }
                    if (radioButton4.Checked)
                    {
                        Class1 Perevod = new Class1(16, textBox1.Text);
                        textBox2.Text = Perevod.perevod();
                    }
                }
            }
            else
            {
                textBox2.Text = "Error";
            }
            
        }
    }
}
