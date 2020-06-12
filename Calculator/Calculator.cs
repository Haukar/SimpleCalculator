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
    public partial class Calculator : Form
    {

        double numberS = 0;
        bool usedDot = false;
        bool usedOperator = false;
        bool clear = false;
        string operatorU;

        public Calculator()
        {
            InitializeComponent();
        }

        private void selectNumber(string number)
        {
            if(!clear) {
                if (result.Text == "0")
                {
                    result.Text = result.Text = number;
                }
                else
                {
                    result.Text = result.Text + number;
                }
            }
            else
            {
                numberS = 0;
                usedDot = false;
                usedOperator = false;
                clear = false;
                history.Text = "0";
                result.Text = result.Text = number;
            }
            
        }

        private void selectOperator(string operatorC)
        {
            if (!usedOperator) {
                numberS = double.Parse(result.Text, System.Globalization.CultureInfo.InvariantCulture);
                history.Text = result.Text + operatorC;
                result.Text = "0";
                operatorU = operatorC;
                usedOperator = true;
            } else
            {
                history.Text = numberS + operatorC;
                operatorU = operatorC;
                result.Text = "0";
            }
            
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (!clear)
            {
                result.Text = result.Text + "0";
            }
            else
            {
                numberS = 0;
                usedDot = false;
                usedOperator = false;
                clear = false;
                history.Text = "0";
                result.Text = result.Text = "0";
            }
        }

        private void number1_Click(object sender, EventArgs e)
        {
            selectNumber("1");
        }

        private void number2_Click(object sender, EventArgs e)
        {
            selectNumber("2");
        }

        private void number3_Click(object sender, EventArgs e)
        {
            selectNumber("3");
        }

        private void number4_Click(object sender, EventArgs e)
        {
            selectNumber("4");
        }

        private void number5_Click(object sender, EventArgs e)
        {
            selectNumber("5");
        }

        private void number6_Click(object sender, EventArgs e)
        {
            selectNumber("6");
        }

        private void number7_Click(object sender, EventArgs e)
        {
            selectNumber("7");
        }

        private void number8_Click(object sender, EventArgs e)
        {
            selectNumber("8");
        }

        private void number9_Click(object sender, EventArgs e)
        {
            selectNumber("9");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!usedDot)
            {
                result.Text = result.Text + ".";
                usedDot = true;
            }
        }

        private void buttonDivided_Click(object sender, EventArgs e)
        {
            selectOperator("/");
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            selectOperator("*");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            selectOperator("-");
        }

        private void butttonPlus_Click(object sender, EventArgs e)
        {
            selectOperator("+");
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            history.Text = "0";
            numberS = 0;
            usedDot = false;
            usedOperator = false;
        }

        private double calculator(double number1, double number2)
        {
            if (operatorU == "+")
            {
                return number1 + number2;
            }
            else if (operatorU == "/")
            {
                return number1 / number2;
            }
            else if (operatorU == "*")
            {
                return number1 * number2;
            }
            else
            {
                return number1 - number2;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string hText = result.Text;
            double number1 = numberS;
            double number2 = double.Parse(result.Text, System.Globalization.CultureInfo.InvariantCulture);
            history.Text = history.Text + hText + "=" + calculator(number1, number2).ToString();

            clear = true;
        }
    }
}
