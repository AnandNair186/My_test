using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    count++;
                }

            }
            if (count==2)
            {
                label2.Text = "Prime Number";
            }
            else
            {
                label2.Text = "Not a Prime Number";
            }
        }
    }
}
