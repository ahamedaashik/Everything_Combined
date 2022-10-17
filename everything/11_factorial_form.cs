using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace everything
{
    public partial class _11_factorial_form : Form
    {
        public _11_factorial_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, fact;
            num = Int32.Parse(textBox1.Text);
            fact = 1;
            for (int i = 2; i <= num; i++)
            {
                fact = fact * i;
            }
            label1.Text = "The factorial on " + num + " is " + fact;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
