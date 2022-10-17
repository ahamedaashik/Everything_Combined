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
    public partial class _10_grade : Form
    {
        public _10_grade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int marks = Int32.Parse(textBox1.Text);
            if (marks >= 75)
            {
                label2.Text = "Grade A ";
            }
            else if (marks >= 65)
            {
                label2.Text = "Grade B ";
            }
            else if (marks >= 55)
            {
                label2.Text = "Grade c ";
            }
            else if (marks >= 35)
            {
                label2.Text = "Grade S ";
            }
            else
            {
                label2.Text = "FAIL";
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
