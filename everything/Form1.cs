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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _02_Input_Output input_output = new _02_Input_Output();
            input_output.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _01_Hello_world hello_world = new _01_Hello_world();
            hello_world.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _03_Addcs add = new _03_Addcs();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _04_cylinder cylinder = new _04_cylinder();
            cylinder.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            _05_bignum bignum = new _05_bignum();
            bignum.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            _06_electricity_Bill bill = new _06_electricity_Bill();
            bill.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            _07_electricity_bill_02 bill2 = new _07_electricity_bill_02();
            bill2.Show();
        }
    }
}
