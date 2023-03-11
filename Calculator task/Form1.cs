using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_task
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || (operation_pressed))
            {
                Result.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }
        private void CEbtn_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(Result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }
        enum Operators
        {
            Plus,
            Minus,
            Division,
            Multiplication
        }
        private void equalbtn_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            if (operation == "+")
            {
                Result.Text = (value + double.Parse(Result.Text)).ToString();
            }
            else if (operation == "-")
            {
                Result.Text = (value - double.Parse(Result.Text)).ToString();
            }
            else if (operation == "x")
            {
                Result.Text = (value * double.Parse(Result.Text)).ToString();
            }
            else if (operation == "/")
            {
                Result.Text = (value / double.Parse(Result.Text)).ToString();
            }
        }
        private void Cbtn_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            value = 0;
        }
    }
}
