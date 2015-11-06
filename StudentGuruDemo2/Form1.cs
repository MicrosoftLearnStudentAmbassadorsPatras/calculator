using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentGuruDemo2
{
    public partial class Form1 : Form
    {
        string input = "";
        float result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            calculate(input);
        }

        string calculate(string input)
        {
            result = 0;
            char[] delimiters = { ' ' };
            string[] parts = input.Split(delimiters);
            switch (parts.Count())
            {
                case 3:
                    {
                        switch (parts[1])
                        {
                            case "+":
                                {
                                    result = float.Parse(parts[0]) + float.Parse(parts[2]);
                                    break;
                                }
                            case "-":
                                {
                                    result = float.Parse(parts[0]) - float.Parse(parts[2]);
                                    break;
                                }
                            case "*":
                                {
                                    result = float.Parse(parts[0]) * float.Parse(parts[2]);
                                    break;
                                }
                            case "/":
                                {
                                    if (parts[2] == "0")
                                    {
                                        label1.Text = "Invalid (division by zero)";
                                        return "0";
                                    }
                                    result = float.Parse(parts[0]) / float.Parse(parts[2]);
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (parts[0])
                        {
                            case "sqrt":
                                {
                                    result = (float)Math.Sqrt(float.Parse(parts[1]));
                                    break;
                                }
                        }
                        break;
                    }
            }
            label1.Text = "Result: " + result.ToString();
            return result.ToString();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = result.ToString();
        }

    }
}
