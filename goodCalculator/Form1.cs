using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace goodCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.AutoSize = false;
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
        private void buttonRootNumber_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text);
            double result = Math.Sqrt(num);
            textBox.Text = result.ToString();
        }

        private void buttonNumberSquare_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text);
            double result = Math.Pow(num, 2);
            textBox.Text = result.ToString();
        }

        private void buttonThirdDegreeRoot_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text);
            double result = Math.Pow(num, 1.0 / 3.0);
            textBox.Text = result.ToString();
        }
        private void buttonCosine_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text) * Math.PI / 180;
            double result = Math.Cos(num);
            textBox.Text = result.ToString();
        }

        private void buttonSine_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text) * Math.PI / 180;
            double result = Math.Sin(num);
            textBox.Text = result.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            const int minFontSize = 5;
            const int maxFontSize = 20;
            const int maxCharsForMinFont = 30;
            const int normalFontThreshold = 10;


            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            int textLength = textBox.Text.Length;
            FontStyle fontStyle = FontStyle.Bold;

            if (textLength <= normalFontThreshold)
            {
                textBox.Font = new Font(fontFamily, maxFontSize, fontStyle);
            }
            else if (textLength > normalFontThreshold && textLength < maxCharsForMinFont)
            {
                float range = maxCharsForMinFont - normalFontThreshold;
                float progress = (textLength - normalFontThreshold) / range;

                float fontSize = maxFontSize - (maxFontSize - minFontSize) * progress;
                fontSize = Math.Max(fontSize, minFontSize);

                textBox.Font = new Font(fontFamily, fontSize, fontStyle);
            }
            else
            {
                textBox.Font = new Font(fontFamily, minFontSize, fontStyle);
            }
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

                double result = 0;

                switch(char.Parse(stroke[1]))
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case ':':
                        result = num1 / num2;
                        break;
                }

                textBox.Text = result.ToString();

                if (textBox.Text.Length >= 6)
                {
                    int temp = (int)result;
                    string hex = temp.ToString("X");
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