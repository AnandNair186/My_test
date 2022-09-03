using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q9b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            int a = Convert.ToInt32(textBox1.Text);
            int res = 1;
            int count = 1;
            do
            {
                res = a * count;
                s.Append(a + " X " + count + " = " +res+ "\n");
                count++;
            } while (count <= 10);
            label2.Text = s.ToString();
        }
    }
}
    

