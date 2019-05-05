using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class fmInput : Form
    {
        public fmInput()
        {
            InitializeComponent();
        }
        private double input;
        public double getInput()
        {
            return input;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                input = double.Parse(textBox1.Text);
            }
            else
            {
                input = 0;
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
