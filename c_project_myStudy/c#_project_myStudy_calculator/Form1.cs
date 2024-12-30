using System;
using System.Windows.Forms;

namespace c__project_myStudy_calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBoxResult.Text);
            isOperationPerformed = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operationPerformed)
                {
                    case "+":
                        textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "-":
                        textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "*":
                        textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "/":
                        if (Double.Parse(textBoxResult.Text) == 0)
                        {
                            MessageBox.Show("0으로 나눌 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                        }
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(textBoxResult.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            operationPerformed = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Math.Sqrt(Double.Parse(textBoxResult.Text)).ToString();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Math.Pow(Double.Parse(textBoxResult.Text), 2).ToString();
        }
    }
}
