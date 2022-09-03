using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int fact = 1;
            while (a!=0)
            {
                fact=fact*a;
                a--;
            }
            label2.Text="Factorial ="+fact;
        }
    }
}
