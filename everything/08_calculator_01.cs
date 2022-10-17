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
    public partial class _08_calculator_01 : Form
    {
        public _08_calculator_01()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
    
        }

        private void mult_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
        }
    }
}
