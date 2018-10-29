using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorTemp : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public CalculatorTemp()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || isOperationPerformed)
            {
                textBox_Result.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button) sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            currentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;

        }

        private void clear_Values(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void clearentry_Values(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;

        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
