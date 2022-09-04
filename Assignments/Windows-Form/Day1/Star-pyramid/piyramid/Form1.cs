using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piyramid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 1; i <=5; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    s.Append(" ");
                }
                for (int k = 1; k <=i; k++)
                {
                    s.Append("*");
                }
                for (int l = 2; l <=i ; l++)
                {
                    s.Append("*");
                }
                s.AppendLine();
            }
            label2.Text = s.ToString();

        }
    }
}
