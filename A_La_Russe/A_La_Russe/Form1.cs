using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_La_Russe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            int prod = 0;

            while(a > 0)
            {
                if(a%2 == 1)
                {
                    prod = prod + b;
                }
                a = a / 2;
                b = b + b;
            }

            MessageBox.Show(prod.ToString());


        }

    }
}
