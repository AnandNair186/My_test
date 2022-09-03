using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s= new StringBuilder();
            for (int i = 1; i <=3; i++)
            {
                
                for (int j = 1; j <=3; j++)
                {
                    s.Append(i+" ");
                }
                s.AppendLine();


                for (int k = 1; k <=3; k++)
                {
                    s.Append(" ");
                }
                s.AppendLine();
            }
            label2.Text = s.ToString();
        }
    }
}
