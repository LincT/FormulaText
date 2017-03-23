using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringToFormula();
        }

        private void stringToFormula()
        {
            string result = textBox1.Text;
            List<decimal> digits = new List<decimal> { };
            string expression = textBox1.Text;
            //string expression = "2*3";
            if (textBox1.Text != "")
            {
                try
                {
                    if (expression.Contains('+'))
                    {
                        char operand = '+';
                        decimal input1;
                        decimal input2;
                        if (decimal.TryParse(expression.Split(operand)[0], out input1) &&
                            decimal.TryParse(expression.Split(operand)[1], out input2) &&
                            expression.Split(operand).Count() == 2)
                        {
                            result = Convert.ToString(input1 + input2);
                        }
                        else
                        {
                            MessageBox.Show("Only valid expressions with 1 operand are allowed");
                        }

                    }
                    else if (expression.Contains('-'))
                    {
                        char operand = '-';
                        decimal input1;
                        decimal input2;
                        if (decimal.TryParse(expression.Split(operand)[0], out input1) &&
                            decimal.TryParse(expression.Split(operand)[1], out input2) &&
                            expression.Split(operand).Count() == 2)
                        {
                            result = Convert.ToString(input1 - input2);
                        }
                        else
                        {
                            MessageBox.Show("Only valid expressions with 1 operand are allowed");
                        }

                    }
                    else if (expression.Contains('/'))
                    {
                        char operand = '/';
                        decimal input1;
                        decimal input2;
                        if (decimal.TryParse(expression.Split(operand)[0], out input1) &&
                            decimal.TryParse(expression.Split(operand)[1], out input2) &&
                            expression.Split(operand).Count() == 2)
                        {
                            result = Convert.ToString(input1 / input2);
                        }
                        else
                        {
                            MessageBox.Show("Only valid expressions with 1 operand are allowed");
                        }

                    }
                    else if (expression.Contains('*'))
                    {
                        char operand = '*';
                        decimal input1;
                        decimal input2;
                        if (decimal.TryParse(expression.Split(operand)[0], out input1) &&
                            decimal.TryParse(expression.Split(operand)[1], out input2) &&
                            expression.Split(operand).Count() == 2)
                        {
                            result = Convert.ToString(input1 * input2);
                        }
                        else
                        {
                            MessageBox.Show("Only valid expressions with 1 operand are allowed");
                        }

                    }
                }
                catch (ArithmeticException ex)
                {
                    //Umm, add handling?
                    //this also catches the x/0 error
                    textBox1.Clear();
                    result = 0m.ToString();
                    MessageBox.Show(ex.Message + "\n\nMath doesn't work that way!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nPlease report error to developers","Unknown Error");
                    throw;
                }

                textBox1.Text = result;
                textBox1.SelectionStart = textBox1.TextLength;
            }
            else
            {
                textBox1.Text = 0m.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = 0m.ToString();
        }
    }
}
