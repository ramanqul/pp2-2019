using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorWF
{

    delegate string OperationDelegate(string v1, string v2);

    public enum Operation
    {
        ADD, SUB, MULT, DIV
    }

    public partial class Form1 : Form
    {

        private Operation operation;
        private string val1;
        private string val2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Calc_Click(object sender, EventArgs e)
        {

            val1 = label1.Text;
            label1.Text = "";

            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                operation = Operation.ADD;
            }
            //else if (...) //add more operation
            //{
            //
            //}


        }


        private void Button_Equal_Click(object sender, EventArgs e)
        {

            //initialize delegate and call calculate function


        }
    
        private string calculate(OperationDelegate callback)
        {
            return callback.Invoke(val1, val2);
        }


        private void Button_Digits_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.Text[0] >= '0' && btn.Text[0] <= '9')
            {
                if (label1.Text == "0")
                {
                    label1.Text = "";
                }

                label1.Text = label1.Text + btn.Text;
            }


        }

    }
}
