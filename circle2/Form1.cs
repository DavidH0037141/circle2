using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox1.Text);

            double c = 2.0 * Math.PI * radius;
            double a = Math.PI * radius * radius;

            label1.Text = "c =" + a;
            label2.Text = "a =" + c;
        }
    }
}
