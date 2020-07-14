using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r;

            r = 0;

            Double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.label1.Text, out sn);

            if (this.operator_label.Text == "+")
            {
                r = fn + sn;
            }

            if (this.operator_label.Text == "-")
            {
                r = fn - sn;
            }

            if (this.operator_label.Text == "X")
            {
                r = fn * sn;
            }

            if (this.operator_label.Text == "%")
            {
                r = fn / sn;
            }

            this.label1.Text = r.ToString();
            this.operator_label.ResetText();
            this.first_num_label.ResetText();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";

            if (label1.Text != "")
            {
                this.first_num_label.Text = label1.Text;
            }
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";

            if (label1.Text != "")
            {
                this.first_num_label.Text = label1.Text;
            }
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "X";

            if (label1.Text != "")
            {
                this.first_num_label.Text = label1.Text;
            }
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "%";

            if(label1.Text !="")
            {
                this.first_num_label.Text = label1.Text;
            }
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.operator_label.ResetText();
            this.first_num_label.ResetText();
        }
    }
}
