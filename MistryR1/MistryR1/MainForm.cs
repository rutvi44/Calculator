/*
 * Name of project: InClass1_MistryR1
 * Purpose: To calculate value input by user
 *
 * Revision Histrory:
 *      Rutvi Mistry, 2023.05.16: Created
 */
namespace MistryR1
{
    public partial class MainForm : Form
    {
        private double x;
        private string pendingOperation = "";
        private bool isNewNumber = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = string.Empty;
            lblResult.Text = string.Empty;

            x = 0;
            pendingOperation = "";
            isNewNumber = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtBox.Text = string.Empty;
        }
        private void DigitButton(object sender, EventArgs e)
        {
            if (isNewNumber)
            {

                lblResult.Text = string.Empty;
                txtBox.Text = string.Empty;
                isNewNumber = false;
            }

            string digitORDecimal = ((Button)sender).Text;

            if (digitORDecimal == "." && txtBox.Text.Contains('.'))
                return;

            txtBox.Text += digitORDecimal;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            x = double.Parse(txtBox.Text);

            txtBox.Text = string.Empty;
            pendingOperation = ((Button)sender).Text;

            lblResult.Text += $"{x} {pendingOperation}";
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            double y = double.Parse(txtBox.Text);
            double answer = 0.0;

            switch (pendingOperation)
            {
                case "+":
                    answer = x + y;
                    break;
                case "-":
                    answer = x - y;
                    break;
                case "*":
                    answer = x * y;
                    break;
                case "/":
                    if (y != 0)
                        answer = x / y;
                    break;
                default:
                    answer = 0.0;
                    break;
            }

            txtBox.Text = answer.ToString();
            lblResult.Text += $"{y} = {answer}";

            x = 0.0;
            pendingOperation = "";
            isNewNumber = true;
        }
    }
}

