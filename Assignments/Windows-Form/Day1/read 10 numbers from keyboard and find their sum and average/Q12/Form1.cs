using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, total;
            float avg;
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox2.Text);
            c=Convert.ToInt32(textBox3.Text);
            d=Convert.ToInt32(textBox4.Text);
            f=Convert.ToInt32(textBox5.Text);

            total = a + b + c + d + f;
            label11.Text = "Total =" + total;

            avg = total / 5;
            label12.Text = "Average =" + avg;

        }
    }
}
