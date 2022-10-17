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
    public partial class _05_bignum : Form
    {
        public _05_bignum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            if (num1 > num2)
            {
                textBox3.Text = ("First number is big" + num1);
            }
            else if (num1 == num2)
            {
                textBox3.Text = ("Both Numbers are equal " + num1);
            }
            else
            {
                textBox3.Text = ("Number 2 is big : " + num2);
            }
            
        }
    }
}
