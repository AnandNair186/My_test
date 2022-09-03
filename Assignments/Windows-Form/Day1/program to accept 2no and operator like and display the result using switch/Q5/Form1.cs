using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =  Convert.ToInt32(textBox1.Text);
            int b =  Convert.ToInt32(textBox2.Text);
            char c = Convert.ToChar(textBox3.Text);
            
            

            switch (c)
            {
                case ('+'):
                    label4.Text ="Addition " +(a + b);
                    break;
                case ('-'):
                    label4.Text = "Substraction " + (a - b);
                    break;
                case ('*'):
                    label4.Text = "Multiplication " + (a * b);
                    break;

                    default:
                    break;




            }
        }
    }
}
