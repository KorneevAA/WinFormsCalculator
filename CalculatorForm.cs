using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private string currentOperation;
        private StringBuilder currentNumber;
        private double memory = 0;

        public CalculatorForm()
        {
            InitializeComponent();
            currentOperation = "";
            currentNumber = new StringBuilder("0");
            lblCurrentNumber.Text = currentNumber.ToString();
            lblMemoryNumber.Text = memory.ToString();
        }

        private void SetCurrentNumber(string number)
        {
            currentNumber.Clear();
            currentNumber.Append(number);
            lblCurrentNumber.Text = currentNumber.ToString();
        }

        private string MakeOperation(string a, string b, string operation)
        {
            switch (operation)
            {
                case "*":
                    return Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
                case "+":
                    return Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
                case "-":
                    return Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b));
                case "/":
                    if (b == "0")
                        return "Ошибка";
                    return Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b));
                default:
                    return "Ошибка";
            }
        }

        private void SetOperation(string operation)
        {
            string tempText = currentNumber.ToString();

            if (currentOperation == "")
            {
                lblLastNumber.Text = tempText;
                currentOperation = operation;
                SetCurrentNumber("0");
            }
            else
            {
                lblLastNumber.Text = MakeOperation(lblLastNumber.Text, tempText, currentOperation);
                SetCurrentNumber("0");
                currentOperation = operation;
            }
        }

        private void AddNumber(string number)
        {
            if (currentNumber.Length == 1 && currentNumber[0] == '0')
            {
                currentNumber.Clear();
                currentNumber.Append(number);
            }
            else if (currentNumber.ToString() == "Ошибка")
            {
                currentNumber.Clear();
                currentNumber.Append(number);
            }
            else
            {
                currentNumber.Append(number);
            }
            lblCurrentNumber.Text = currentNumber.ToString();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            SetCurrentNumber("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetCurrentNumber("0");
            lblLastNumber.Text = "";
            currentOperation = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (currentNumber.Length > 1 && !(currentNumber.Length == 2 && currentNumber[0] == '-'))
            {
                currentNumber.Remove(currentNumber.Length - 1, 1);
            }
            else
            {
                currentNumber.Clear();
                currentNumber.Append("0");
            }
            lblCurrentNumber.Text = currentNumber.ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void btnSeven_Click(object sender, EventArgs e) => AddNumber("7");
        private void btnEight_Click(object sender, EventArgs e) => AddNumber("8");
        private void btnNine_Click(object sender, EventArgs e) => AddNumber("9");
        private void btnDivision_Click(object sender, EventArgs e) => SetOperation("/");
        private void btnFour_Click(object sender, EventArgs e) => AddNumber("4");
        private void btnFive_Click(object sender, EventArgs e) => AddNumber("5");
        private void btnSix_Click(object sender, EventArgs e) => AddNumber("6");
        private void btnAddition_Click(object sender, EventArgs e) => SetOperation("+");
        private void btnOne_Click(object sender, EventArgs e) => AddNumber("1");
        private void btnTwo_Click(object sender, EventArgs e) => AddNumber("2");
        private void btnThree_Click(object sender, EventArgs e) => AddNumber("3");
        private void btnSubstraction_Click(object sender, EventArgs e) => SetOperation("-");
        private void btnZero_Click(object sender, EventArgs e) => AddNumber("0");
        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            string text = currentNumber.ToString();
            if (text != "0" && text != "Ошибка" && text != "")
            {
                if (currentNumber[0] == '-')
                    currentNumber.Remove(0, 1);
                else
                    currentNumber.Insert(0, "-");

                lblCurrentNumber.Text = currentNumber.ToString();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            string tempText = currentNumber.ToString();

            if (!tempText.Contains(",") && tempText != "Ошибка")
            {
                currentNumber.Append(",");
                lblCurrentNumber.Text = currentNumber.ToString();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (currentOperation != "")
            {
                string result = MakeOperation(lblLastNumber.Text, currentNumber.ToString(), currentOperation);
                SetCurrentNumber(result);
                lblLastNumber.Text = "";
                currentOperation = "";
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(currentNumber.ToString());
            SetCurrentNumber(Convert.ToString(val / 100));
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(currentNumber.ToString());
            SetCurrentNumber(Convert.ToString(Math.Sqrt(val)));
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(currentNumber.ToString());
            SetCurrentNumber(Convert.ToString(Math.Pow(val, 2)));
        }

        private void btnReverseX_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(currentNumber.ToString());
            SetCurrentNumber(Convert.ToString(1 / val));
        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            if (lblCurrentNumber.Text == "Ошибка") return;

            memory += Convert.ToDouble(lblCurrentNumber.Text);
            lblMemoryNumber.Text = memory.ToString();
        }

        private void btnMemoryMinus_Click(object sender, EventArgs e)
        {
            if (lblCurrentNumber.Text == "Ошибка") return;

            memory -= Convert.ToDouble(lblCurrentNumber.Text);
            lblMemoryNumber.Text = memory.ToString();
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            if (lblCurrentNumber.Text == "Ошибка") return;

            memory = Convert.ToDouble(lblCurrentNumber.Text);
            lblMemoryNumber.Text = memory.ToString();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            lblMemoryNumber.Text = memory.ToString();
        }
    }
}