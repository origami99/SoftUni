using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class Sumator : Form
    {
        public Sumator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = double.Parse(this.textBox1.Text);
            var num2 = double.Parse(this.textBox2.Text);
            var sum = num1 + num2;
            textBoxSum.Text = sum.ToString();

            var num3 = double.Parse(this.textBox3.Text);
            var num4 = double.Parse(this.textBox4.Text);
            var diff = num1 - num2;
            textBox5.Text = diff.ToString();

            var num5 = double.Parse(this.textBox6.Text);
            var num6 = double.Parse(this.textBox7.Text);
            var multip = num1 * num2;
            textBox8.Text = multip.ToString();

            var num7 = double.Parse(this.textBox9.Text);
            var num8 = double.Parse(this.textBox10.Text);
            var devide = num1 / num2;
            textBox11.Text = devide.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
