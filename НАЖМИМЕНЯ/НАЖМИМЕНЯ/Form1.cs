using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НАЖМИМЕНЯ
{
    public partial class Form1 : Form
    {
        public int t;
        public Form1()
        {
            InitializeComponent();
            button1.Text = "НАЖМИ МЕНЯ!!!!";
            t = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t++;
            button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
            if (t == 2)
            {
                Close();
            }
        }
    }
}
