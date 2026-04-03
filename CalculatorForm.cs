using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using WinFormsCalculator;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculatorController _controller = new CalculatorController();
        private readonly IInputProcessor _inputProcessor = new InputProcessor();
        private readonly DisplayFormatter _formatter = new DisplayFormatter();
        private readonly MemoryService _memoryService;

        private bool _isHistoryCollapsed = false;
        private bool _isNewInput = true;
        private double splitPercentage = 0.5;
        private int collapseSize = 600;

        public CalculatorForm()
        {
            InitializeComponent();
            _memoryService = new MemoryService(panel2);
            lblCurrentNumber.TextChanged += LblCurrentNumber_TextChanged;
        }

        private void LblCurrentNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblCurrentNumber.Text))
                {
                    CalculatorModel.CurrentValue = _formatter.ParseInput(lblCurrentNumber.Text);
                }
            }
            catch
            {
            }
        }

        private void ClearCalculator()
        {
            CalculatorModel.Reset();
            lblCurrentNumber.Text = "0";
            lblLastNumber.Text = "";
            _isNewInput = true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearCalculator();
        }

        private void btnZero_Click(object sender, EventArgs e) => ProcessNumber("0");
        private void btnOne_Click(object sender, EventArgs e) => ProcessNumber("1");
        private void btnTwo_Click(object sender, EventArgs e) => ProcessNumber("2");
        private void btnThree_Click(object sender, EventArgs e) => ProcessNumber("3");
        private void btnFour_Click(object sender, EventArgs e) => ProcessNumber("4");
        private void btnFive_Click(object sender, EventArgs e) => ProcessNumber("5");
        private void btnSix_Click(object sender, EventArgs e) => ProcessNumber("6");
        private void btnSeven_Click(object sender, EventArgs e) => ProcessNumber("7");
        private void btnEight_Click(object sender, EventArgs e) => ProcessNumber("8");
        private void btnNine_Click(object sender, EventArgs e) => ProcessNumber("9");

        private void ProcessNumber(string digit)
        {
            try
            {
                if (_isNewInput)
                {
                    lblCurrentNumber.Text = digit;
                    _isNewInput = false;
                }
                else
                {
                    lblCurrentNumber.Text = _inputProcessor.ProcessNumberInput(lblCurrentNumber.Text, digit);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnAddition_Click(object sender, EventArgs e) => ProcessOperation("+", OperationType.Addition);
        private void btnSubstraction_Click(object sender, EventArgs e) => ProcessOperation("-", OperationType.Subtraction);
        private void btnMultiplication_Click(object sender, EventArgs e) => ProcessOperation("*", OperationType.Multiplication);
        private void btnDivision_Click(object sender, EventArgs e) => ProcessOperation("/", OperationType.Division);

        private void ProcessOperation(string symbol, OperationType operationType)
        {
            try
            {
                if (CalculatorModel.CurrentOperation != OperationType.None)
                {
                    double result = _controller.Calculate(CalculatorModel.LastValue, CalculatorModel.CurrentValue, CalculatorModel.CurrentOperation);
                    HistoryItem historyItem = new HistoryItem(CalculatorModel.LastValue, CalculatorModel.CurrentOperation, CalculatorModel.CurrentValue, result);
                    historyItem.AddToHistroy(panel1);
                    CalculatorModel.LastValue = result;
                    lblCurrentNumber.Text = _formatter.FormatNumber(result);
                }
                else
                {
                    CalculatorModel.LastValue = CalculatorModel.CurrentValue;
                }

                CalculatorModel.CurrentOperation = operationType;
                lblLastNumber.Text = $"{_formatter.FormatNumber(CalculatorModel.LastValue)} {symbol}";
                _isNewInput = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (CalculatorModel.CurrentOperation == OperationType.None)
                    return;
                double result = _controller.Calculate(CalculatorModel.LastValue, CalculatorModel.CurrentValue, CalculatorModel.CurrentOperation);
                HistoryItem historyItem = new HistoryItem(CalculatorModel.LastValue, CalculatorModel.CurrentOperation, CalculatorModel.CurrentValue, result);
                historyItem.AddToHistroy(panel1);
                lblCurrentNumber.Text = _formatter.FormatNumber(result);
                lblLastNumber.Text = "";
                CalculatorModel.CurrentOperation = OperationType.None;
                CalculatorModel.CurrentValue = result;
                _isNewInput = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnPercent_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.Percent);
        private void btnSqrt_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.SquareRoot);
        private void btnSquare_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.Square);
        private void btnReverseX_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.Reciprocal);

        private void ProcessUnaryOperation(OperationType operationType)
        {
            try
            {
                double result = _controller.CalculateUnary(CalculatorModel.CurrentValue, operationType);
                lblCurrentNumber.Text = _formatter.FormatNumber(result);
                _isNewInput = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            lblCurrentNumber.Text = "0";
            _isNewInput = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isNewInput)
                {
                    lblCurrentNumber.Text = "0";
                }
                else
                {
                    lblCurrentNumber.Text = _inputProcessor.ProcessBackspace(lblCurrentNumber.Text);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            try
            {
                lblCurrentNumber.Text = _inputProcessor.ProcessChangeSign(lblCurrentNumber.Text);
                _isNewInput = false;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isNewInput)
                {
                    lblCurrentNumber.Text = "0,";
                    _isNewInput = false;
                }
                else
                {
                    lblCurrentNumber.Text = _inputProcessor.ProcessDecimalPoint(lblCurrentNumber.Text);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        private void CalculatorForm_Resize(object sender, EventArgs e)
        {
            if (this.Width < collapseSize)
            {
                _isHistoryCollapsed = true;
                splitContainer1.Panel2Collapsed = true;
                splitContainer1.SplitterDistance = (int)(this.Width * splitPercentage);
            }
            else
            {
                _isHistoryCollapsed = false;
                splitContainer1.Panel2Collapsed = false;
            }
            btnMemoryClear.Size = btnZero.Size;
            btnMemorySave.Size = btnZero.Size;
            btn_ClearHistory.Size = btnZero.Size;
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isHistoryCollapsed = false;
            splitContainer1.Panel2Collapsed = false;
        }

        private void спрятатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isHistoryCollapsed = true;
            splitContainer1.Panel2Collapsed = true;
        }

        private void btn_ClearHistory_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            _memoryService.MemorySave(CalculatorModel.CurrentValue);
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            _memoryService.MemoryClear();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
