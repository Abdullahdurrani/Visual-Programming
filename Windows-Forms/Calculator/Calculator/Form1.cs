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
    public partial class Form1 : Form
    {
        int Operand1;
        int Operand2;
        char Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(textBox.Text != null)
            {
                textBox.Text += "0";
            }
            else
            {
                textBox.Text = "0";
            }
            
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null)
            {
                textBox.Text += "1";
            }
            else
            {
                textBox.Text = "1";
            }

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "2";
            }
            else
            {
                textBox.Text = "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "3";
            }
            else
            {
                textBox.Text = "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "4";
            }
            else
            {
                textBox.Text = "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "5";
            }
            else
            {
                textBox.Text = "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "6";
            }
            else
            {
                textBox.Text = "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "7";
            }
            else
            {
                textBox.Text = "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text += "8";
            }
            else
            {
                textBox.Text = "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {if (textBox.Text != "")
            {
                textBox.Text += "9";
            }
            else
            {
                textBox.Text = "9";
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Operand1 = int.Parse(textBox.Text);
            Operator = '/';
            textBox.Text = "";
            label.Text = Operator + " " + Operand1.ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            Operand1 = int.Parse(textBox.Text);
            Operator = '*';
            textBox.Text = "";
            label.Text = Operator + " " + Operand1.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Operand1 = int.Parse(textBox.Text);
            Operator = '+';
            textBox.Text = "";
            label.Text = Operator + " " + Operand1.ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            Operand1 = int.Parse(textBox.Text);
            Operator = '-';
            textBox.Text = "";
            label.Text = Operator + " " + Operand1.ToString();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Operand2 = int.Parse(textBox.Text);
            int ans = 0;
            switch (Operator)
            {
                case '/':
                    ans = Operand1 / Operand2;
                    break;
                case '*':
                    ans = Operand1 * Operand2;
                    break;
                case '+':
                    ans = Operand1 + Operand2;
                    break;
                case '-':
                    ans = Operand1 - Operand2;
                    break;
            }
            textBox.Text = ans.ToString();
            label.Text = "= " + Operand2.ToString() + " " + Operator + " " + Operand1.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Operator = '0';
            Operand1 = 0;
            Operand2 = 0;
            textBox.Text = "";
            label.Text = "";
        }
    }
}
