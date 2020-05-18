using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кнопки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Top + button1.Size.Height + 16 < button2.Top)
            {
                button1.Top += 16;
                button2.Top -= 16;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Top > 0)
            {
                button1.Top -= 16;
            }
            if (ActiveForm.Size.Height - button2.Top - button2.Size.Height - 3 * 16 > 0)
            {
                button2.Top += 16;
            }
        }
    }
}
