using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int num=Convert.ToInt32(textBox1.Text);
            int res = 0;
            int count=0;
            while (count<10)
            {
                res=num*count;
                count++;
                sb.Append(num + "X" + count + "=" + (num * count)+"\n");
            }
            label2.Text = sb.ToString();

        }
    }
}
