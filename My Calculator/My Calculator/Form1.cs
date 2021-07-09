using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operatation_used = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "9";
        }

        private void decim_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Output.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Output.Text);
            operatation_used = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Output.Text);
            operatation_used = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Output.Text);
            operatation_used = true;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Output.Text);
            operatation_used = true;
        }

        private void equals_Click_1(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Output.Text = (value + Double.Parse(Output.Text)).ToString();
                    break;
                case "-":
                    Output.Text = (value - Double.Parse(Output.Text)).ToString();
                    break;
                case "÷":
                    Output.Text = (value / Double.Parse(Output.Text)).ToString();
                    break;
                case "x":
                    Output.Text = (value * Double.Parse(Output.Text)).ToString();
                    break;
                default:
                    break;
            }
            operatation_used = false;
        }
    }
}
