using System;
using System.Windows.Forms;
using WinFormsCalculator;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculatorModel _model = new CalculatorModel();
        private readonly CalculatorController _controller = new CalculatorController();
        private readonly IInputProcessor _inputProcessor = new InputProcessor();
        private readonly IMemoryService _memoryService = new MemoryService();
        private readonly DisplayFormatter _formatter = new DisplayFormatter();
        private bool _isNewInput = true;

        public CalculatorForm()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblMemoryNumber.Text = _formatter.FormatNumber(_memoryService.Memory);
        }

        private void ClearCalculator()
        {
            _model.Reset();
            _memoryService.MemoryClear();
            lblCurrentNumber.Text = "0";
            lblLastNumber.Text = "";
            _isNewInput = true;
            UpdateDisplay();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearCalculator();
        }

        // Цифры
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

        // Операции
        private void btnAddition_Click(object sender, EventArgs e) => ProcessOperation("+", OperationType.Addition);
        private void btnSubstraction_Click(object sender, EventArgs e) => ProcessOperation("-", OperationType.Subtraction);
        private void btnMultiplication_Click(object sender, EventArgs e) => ProcessOperation("*", OperationType.Multiplication);
        private void btnDivision_Click(object sender, EventArgs e) => ProcessOperation("/", OperationType.Division);

        private void ProcessOperation(string symbol, OperationType operationType)
        {
            try
            {
                _model.CurrentValue = _formatter.ParseInput(lblCurrentNumber.Text);

                if (_model.CurrentOperation != OperationType.None)
                {
                    double result = _controller.Calculate(_model.LastValue, _model.CurrentValue, _model.CurrentOperation);
                    _model.LastValue = result;
                    lblCurrentNumber.Text = _formatter.FormatNumber(result);
                }
                else
                {
                    _model.LastValue = _model.CurrentValue;
                }

                _model.CurrentOperation = operationType;
                lblLastNumber.Text = $"{_formatter.FormatNumber(_model.LastValue)} {symbol}";
                _isNewInput = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Равно
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (_model.CurrentOperation == OperationType.None)
                    return;

                _model.CurrentValue = _formatter.ParseInput(lblCurrentNumber.Text);
                double result = _controller.Calculate(_model.LastValue, _model.CurrentValue, _model.CurrentOperation);

                lblCurrentNumber.Text = _formatter.FormatNumber(result);
                lblLastNumber.Text = "";
                _model.CurrentOperation = OperationType.None;
                _model.CurrentValue = result;
                _isNewInput = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Специальные функции
        private void btnPercent_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.Percent);
        private void btnSqrt_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.SquareRoot);
        private void btnSquare_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.Square);
        private void btnReverseX_Click(object sender, EventArgs e) => ProcessUnaryOperation(OperationType.Reciprocal);

        private void ProcessUnaryOperation(OperationType operationType)
        {
            try
            {
                _model.CurrentValue = _formatter.ParseInput(lblCurrentNumber.Text);
                double result = _controller.CalculateUnary(_model.CurrentValue, operationType);

                lblCurrentNumber.Text = _formatter.FormatNumber(result);
                _model.CurrentValue = result;
                _isNewInput = true;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        // Очистка
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            lblCurrentNumber.Text = "0";
            _model.CurrentValue = 0;
            _isNewInput = true;
        }

        // Backspace
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

        // Смена знака
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

        // Десятичная точка
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

        // Память
        private void btnMemoryPlus_Click(object sender, EventArgs e) => ProcessMemory(m => _memoryService.MemoryAdd(m));
        private void btnMemoryMinus_Click(object sender, EventArgs e) => ProcessMemory(m => _memoryService.MemorySubtract(m));
        private void btnMemorySave_Click(object sender, EventArgs e) => ProcessMemory(m => _memoryService.MemorySave(m));
        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            try
            {
                _memoryService.MemoryClear();
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ProcessMemory(Action<double> memoryAction)
        {
            try
            {
                double currentValue = _formatter.ParseInput(lblCurrentNumber.Text);
                memoryAction(currentValue);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
