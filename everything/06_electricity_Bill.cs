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
    public partial class _06_electricity_Bill : Form
    {
        public _06_electricity_Bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int used_units;
            used_units = Int32.Parse(textBox1.Text);
            if (used_units < 30)
            {
                textBox2.Text = (used_units * 10).ToString();
            }
            else if (used_units < 60)
            {
                textBox2.Text = (used_units * 15).ToString();
            }

            else if (used_units < 90)
            {
                textBox2.Text = (used_units * 20).ToString();
            }
            else
            {
                textBox2.Text = (used_units * 30).ToString();
            }
      
        }
    }
}
