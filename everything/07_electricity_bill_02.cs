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
    public partial class _07_electricity_bill_02 : Form
    {
        public _07_electricity_bill_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int used_units, result;
            used_units = Int32.Parse(textBox1.Text);
            if (used_units <= 30)
            {
                textBox2.Text = (used_units * 10).ToString();
            }
            else if (used_units <= 60)
            {
                textBox2.Text = (30 * 10 + (used_units - 30) * 15).ToString();
            }

            else if (used_units <= 90)
            {
                result = 30 * 10 + 30 * 15 + (used_units - 60) * 20;
                textBox2.Text = result.ToString();
            }
            else
            {
                result = 30 * 10 + 30 * 15 + 30 * 20 + (used_units - 90) * 30;
                textBox2.Text = result.ToString();
            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
