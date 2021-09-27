/*
Caleb Keller
9/27/2021
Calculator
*/
//imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class formCalc : Form
    {
        String output;//the inital output of the calculator
        int opperand1;// 1st part of operation
        int opperand2;// 2nd part of operation.
        String opp;//opperator
        public formCalc()
        {
            InitializeComponent();
        }
        //add button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            opperand1 = int.Parse(output);
            opp = "+";
            output = "0";
            tbOutput.Text = output;
        }

        private void formCalc_Load(object sender, EventArgs e)
        {
            //set text
            opperand1 = 0;
            opperand2 = 0;
            opp = "";
            output = "0";
            tbOutput.Text = output;
            button0.Text = "0";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            buttonEnter.Text = "Enter";
            buttonClear.Text = "Clear";
            buttonAdd.Text = "+";
            buttonMinus.Text = "-";
            buttonTimes.Text = "*";
            buttonDivide.Text = "/";
            //set font properties
            Font font = new Font("Chiller", 26, FontStyle.Bold);
            button0.Font = font;
            button1.Font = font;
            button2.Font = font;
            button3.Font = font;
            button4.Font = font;
            button5.Font = font;
            button6.Font = font;
            button7.Font = font;
            button8.Font = font;
            button9.Font = font;
            buttonAdd.Font = font;
            buttonMinus.Font = font;
            buttonDivide.Font = font;
            buttonTimes.Font = font;
            Font font2 = new Font("Chiller", 20, FontStyle.Bold);
            buttonClear.Font = font2;
            buttonEnter.Font = font2;

        }
        //buttons 0-9, clear
        private void button0_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "0";
            }
            else
            {
                output = output + "0";
            }
            tbOutput.Text = output;
        }//0

        private void button1_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "1";
            }
            else
            {
                output = output + "1";
            }
            tbOutput.Text = output;
        }//1

        private void button2_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "2";
            }
            else
            {
                output = output + "2";
            }
            tbOutput.Text = output;
        }//2

        private void button3_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "3";
            }
            else
            {
                output = output + "3";
            }
            tbOutput.Text = output;
        }//3

        private void button4_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "4";
            }
            else
            {
                output = output + "4";
            }
            tbOutput.Text = output;
        }//4

        private void button5_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "5";
            }
            else
            {
                output = output + "5";
            }
            tbOutput.Text = output;
        }//5

        private void button6_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "6";
            }
            else
            {
                output = output + "6";
            }
            tbOutput.Text = output;
        }//6

        private void button7_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "7";
            }
            else
            {
                output = output + "7";
            }
            tbOutput.Text = output;
        }//7

        private void button8_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "8";
            }
            else
            {
                output = output + "8";
            }
            tbOutput.Text = output;
        }//8

        private void button9_Click(object sender, EventArgs e)
        {
            if (output == "0" && output != " ")
            {
                output = "9";
            }
            else
            {
                output = output + "9";
            }
            tbOutput.Text = output;
        }//9

        private void buttonClear_Click(object sender, EventArgs e)
        {
            output = "0";
            tbOutput.Text = output;
        }//clear

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }//class
}//namespace
