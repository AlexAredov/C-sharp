using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УГАДАЙ
{
    public partial class Form1 : Form
    {
        public int i;
        public int j;
        public int n;
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            button2.Hide();
            button3.Hide();
            label6.Hide();
            i = 10;
            j = 0;
            n = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            Random r = new Random();
            n = r.Next(0, 10);
            label3.Text = Convert.ToString(n);
            label7.Text = Convert.ToString(i);
            if (Convert.ToInt32(textBox1.Text) == n)
            {
                j++;
                label5.Text = "Угадали!!!";
            }
            else
            {
                label5.Text = "Не угадали :)";
            }
            if (i == 0)
            {
                panel1.Show();
                button2.Show();
                button3.Show();
                label6.Show();
                label4.Text = $"Ваше везение: {j * 10}%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "10";
            textBox1.Text = "";
            label5.Text = "";
            panel1.Hide();
            button2.Hide();
            button3.Hide();
            label6.Hide();
            i = 10;
            j = 0;
            n = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
