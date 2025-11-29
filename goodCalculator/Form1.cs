using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goodCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region цифры
        private void buttonNumOne_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void buttonNumTwo_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void buttonNumThree_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void buttonNumFour_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void buttonNumFive_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void buttonNumSix_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void buttonNumSeven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void buttonNumEight_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void buttonNumNine_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void buttonNumZero_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }
        #endregion

        #region действия
        private void buttonDecimalSign_Click(object sender, EventArgs e)
        {
            textBox.Text += ",";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox.Text += " + ";
            calculated();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox.Text += " - ";
            calculated();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBox.Text += " * ";
            calculated();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBox.Text += " : ";
            calculated();
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBox.Text += "  ";
            calculated();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            percent();
        }

        private void buttonClearSymbol_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }
        #endregion

        #region methods
        public void calculated()
        {
            string[] stroke = textBox.Text.Split();
            if (textBox.Text.Contains(stroke[1]) && stroke.Count() > 3)
            {
                double num1 = double.Parse(stroke[0]);
                double num2 = double.Parse(stroke[2]);

                switch(char.Parse(stroke[1]))
                {
                    case '+':
                        textBox.Text = (num1 + num2).ToString();
                        break;
                    case '-':
                        textBox.Text = (num1 - num2).ToString();
                        break;
                    case '*':
                        textBox.Text = (num1 * num2).ToString();
                        break;
                    case ':':
                        textBox.Text = (num1 / num2).ToString();
                        break;
                }
            }
        }

        public void percent()
        {
            double num = double.Parse(textBox.Text);

            textBox.Text = (num / 100).ToString();
        }
        #endregion

 
    }
}