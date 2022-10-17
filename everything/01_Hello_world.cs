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
    public partial class _01_Hello_world : Form
    {
        public _01_Hello_world()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World !!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
