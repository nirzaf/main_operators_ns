using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace main_operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 fn;
            Int32 sn;
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out fn);
            Int32.TryParse(this.textBox2.Text, out sn);
            r = fn + sn;
            this.textBox3.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 fn;
            Int32 sn;
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out fn);
            Int32.TryParse(this.textBox2.Text, out sn);
            r = fn - sn;
            this.textBox3.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 fn;
            Int32 sn;
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out fn);
            Int32.TryParse(this.textBox2.Text, out sn);
            r = fn * sn;
            this.textBox3.Text = r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal fn;
            decimal sn;
            decimal r;
            decimal.TryParse(this.textBox1.Text, out fn);
            decimal.TryParse(this.textBox2.Text, out sn);
            r = fn / sn;
            this.textBox3.Text = r.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int32 fn;
            Int32 sn;
            //----------------------------
            Int32.TryParse(this.textBox5.Text, out fn);
            Int32.TryParse(this.textBox4.Text, out sn);
            //---------------------------
            if (fn>sn)
            {
                MessageBox.Show("first num is greater than second number!");
            }
            if (fn<sn)
            {
                MessageBox.Show("first num is less than second number!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Int32 fn;
            Int32 sn;
            //----------------------------
            Int32.TryParse(this.textBox5.Text, out fn);
            Int32.TryParse(this.textBox4.Text, out sn);
            //---------------------------
            if (fn == sn)
            {
                MessageBox.Show("First num is equal with second number!");
            }
            if (fn != sn)
            {
                MessageBox.Show("First num is not equal with second number!");
            }
        }
    }
}
