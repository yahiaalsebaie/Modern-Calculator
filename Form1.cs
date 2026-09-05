using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Modern_Calculator
{
    public partial class Form1 : Form
    {
        private Point _mouseLocation;

        private double _result = 0, _firstNumber = 0, _secondNumber = 0;
        private bool _isNewEntry = false;
        private bool _hasResult = false;
        private bool _isError = false;
        private Font _originalFont;
        private List<string> _calculationHistory = new List<string>();
        private enum enOperation
        {
            Add, Subtract, Multiply, Divide, Percentage, Reciprocal, SquareRoot, PowerOf2, Plus_Minus
        }
        private enOperation _Operation;
        private enOperation _PendingOperation;
        public Form1()
        {
            InitializeComponent();
            _originalFont = textBox1.Font;

        }

        private void AddToHistory(string calculation)
        {
            _calculationHistory.Add(calculation);
            UpdateHistoryDisplay();
        }

        private void UpdateHistoryDisplay()
        {
            rtbHistory.Clear();
            if (_calculationHistory.Count == 0)
            {
                rtbHistory.Text = "There's no history yet.";
            }
            else
            {
                for (int i = _calculationHistory.Count - 1; i >= 0; i--)
                {
                    rtbHistory.AppendText(_calculationHistory[i] + Environment.NewLine);
                }
            }
        }

        private void Num_Click(object sender, EventArgs e)
        {
            if (_isError) btnC.PerformClick();

            if (textBox1.Text == "0" || _isNewEntry) textBox1.Text = string.Empty;

            _isNewEntry = false;

            ctrlRoundedButton btn = (ctrlRoundedButton)sender;

            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text += btn.Text;
            }
            else
            {
                string rawText = (textBox1.Text + btn.Text).Replace(",", "");
                if (double.TryParse(rawText, out double parsedValue))
                {
                    if (textBox1.Text.Contains("."))
                        textBox1.Text += btn.Text;
                    else textBox1.Text = FormattedNumber(parsedValue);
                }
            }

        }

        private void PerformOperationSymbols(ctrlRoundedButton btn)
        {

            switch (btn.Tag.ToString())
            {
                case "+":
                    _Operation = enOperation.Add; break;
                case "-":
                    _Operation = enOperation.Subtract; break;
                case "*":
                    _Operation = enOperation.Multiply; break;
                case "/":
                    _Operation = enOperation.Divide; break;
                case "%":
                    _Operation = enOperation.Percentage; break;
                case "⅟x":
                    _Operation = enOperation.Reciprocal; break;
                case "²√x":
                    _Operation = enOperation.SquareRoot; break;
                case "x²":
                    _Operation = enOperation.PowerOf2; break;
                case "±":
                    _Operation = enOperation.Plus_Minus; break;

            }
        }
        private void Operations_Click(object sender, EventArgs e)
        {
            ctrlRoundedButton btn = (ctrlRoundedButton)sender;

            if (_isError)
            {
                btnC.PerformClick();
                return;
            }

            PerformOperationSymbols(btn);
            _PendingOperation = _Operation;
            //   UnaryOperations(btnOp);


            if (!_hasResult)
            {
                _firstNumber = double.Parse(textBox1.Text);
                _result = _firstNumber;
                _hasResult = true;
            }
            else if (!_isNewEntry)
            {
                btnEqual.PerformClick();
                if (_isError) return;
                _firstNumber = _result;
            }
            else _firstNumber = _result;

            if (_Operation == enOperation.Add || _Operation == enOperation.Subtract || _Operation == enOperation.Divide || _Operation == enOperation.Multiply)
                _PendingOperation = _Operation;


            textBox2.Text = FormattedNumber(_firstNumber) + " " + btn.Text + " ";
            //textBox2.Text = $"{_firstNumber} {btnOp.Tag} ";
            _isNewEntry = true;

        }

        private string GetOperationSymbol(enOperation operation)
        {
            switch (operation)
            {
                case enOperation.Add:
                    return "+";

                case enOperation.Subtract:
                    return "-";

                case enOperation.Multiply:
                    return "×";

                case enOperation.Divide:
                    return "÷";

                default:
                    return "";
            }
        }
        private void SetErrorState(string message)
        {
            _isError = true;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 20, textBox1.Font.Style);
            textBox1.Text = message;
        }
        private void UnaryOperations_Click(object sender, EventArgs e)
        {

            if (_isError) return;
            ctrlRoundedButton btn = (ctrlRoundedButton)sender;
            PerformOperationSymbols(btn);

            double val = double.Parse(textBox1.Text);

            if (btn.Tag.ToString() == "%")
            {
                if (_hasResult)
                    _secondNumber = (_firstNumber * val) / 100.0;
                else
                    _secondNumber = val / 100.0;

                textBox1.Text = _secondNumber.ToString();

                // Update textBox2

                if (_hasResult)
                {
                    textBox2.Text = $"{_firstNumber} {GetOperationSymbol(_PendingOperation)} {_secondNumber}";
                }
                else
                {
                    textBox2.Text = _secondNumber.ToString();
                }

                _isNewEntry = true;
                return;
            }

            string formattedExpression = "";
            switch (_Operation)
            {
                /*  case enOperation.Percentage:
                      double PercentageVal = double.Parse(textBox1.Text);
                      _secondNumber = (_firstNumber * (PercentageVal) / 100.0);
                      _result = _secondNumber;
                      textBox1.Text = _result.ToString();
                      textBox2.Text = _firstNumber + GetOperationSymbol(_PendingOperation) + " " + _result;
                      _isNewEntry = true;
                      break;*/
                case enOperation.Reciprocal:
                    if (val == 0)
                    {
                        SetErrorState("Cannot divide by zero");
                        return;
                    }
                    _result = 1.0 / val;
                    //textBox1.Text = _result.ToString();
                    formattedExpression = "⅟(" + val + ")";
                    //_isNewEntry = true;
                    break;
                case enOperation.SquareRoot:
                    if (val < 0)
                    {
                        SetErrorState("Invalid input");
                        return;
                    }
                    _result = Math.Sqrt(val);
                    //textBox1.Text = _result.ToString();
                    formattedExpression = "²√(" + val + ")";
                    //_isNewEntry = true;
                    break;

                case enOperation.PowerOf2:
                    _result = val * val;
                    //textBox1.Text = _result.ToString();
                    formattedExpression = "(" + val + ")²";
                    //_isNewEntry = true;
                    break;

                case enOperation.Plus_Minus:
                    _result = -val;
                    //textBox1.Text = _result.ToString();
                    formattedExpression = "±(" + val + ")";

                    //_isNewEntry = true;
                    break;
            }
            textBox1.Text = FormattedNumber(_result);

            // Update textBox2
            if (_hasResult)
            {
                textBox2.Text = $"{_firstNumber} {GetOperationSymbol(_PendingOperation)} {_secondNumber}";
            }
            else textBox2.Text = formattedExpression;

            _secondNumber = _result;
            _isNewEntry = true;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (_isError)
            {
                btnC.PerformClick();
                return;
            }
            if (!_isNewEntry)
                _secondNumber = double.Parse(textBox1.Text);

            //   enOperation operationToExecute = _Operation == _PendingOperation ? _PendingOperation : _Operation;
            enOperation operationToExecute = _PendingOperation;


            switch (operationToExecute)
            {
                case enOperation.Add:
                    _result = _firstNumber + _secondNumber;
                    break;
                case enOperation.Subtract:
                    _result = _firstNumber - _secondNumber;
                    break;
                case enOperation.Multiply:
                    _result = _firstNumber * _secondNumber;
                    break;
                case enOperation.Divide:
                    if (_secondNumber == 0)
                    {
                        //MessageBox.Show("Cannot Divide by Zero."); 
                        SetErrorState("Cannot divide by zero");
                        return;
                    }
                    _result = _firstNumber / _secondNumber;
                    break;

                default:
                    break;
            }

            textBox1.Text = FormattedNumber(_result);
            //      textBox2.Text += _secondNumber.ToString();
            textBox2.Text = $"{FormattedNumber(_firstNumber)} {GetOperationSymbol(operationToExecute)} {FormattedNumber(_secondNumber)} =";

            // Add to history
            string historyEntry = $"{FormattedNumber(_firstNumber)} {GetOperationSymbol(operationToExecute)} {FormattedNumber(_secondNumber)} = {FormattedNumber(_result)}";
            AddToHistory(historyEntry);

            _isNewEntry = true;
            _hasResult = false;
            /*textBox1.Text = _result.ToString();

            string opSymbol = (_Operation == enOperation.Add) ? "+" :
                             (_Operation == enOperation.Subtract) ? "-" :
                             (_Operation == enOperation.Multiply) ? "×" : "÷";

            textBox2.Text = $"{_firstNumber} {opSymbol} {_secondNumber} =";

            _isNewEntry = true;*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = string.Empty;

            _result = 0;
            _firstNumber = 0; _secondNumber = 0;
            _isNewEntry = false; _hasResult = false; _isError = false;
            if (_originalFont != null) textBox1.Font = _originalFont;

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (_isError)
            {
                btnC.PerformClick();
                return;
            }
            if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            //  if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == string.Empty) textBox1.Text = "0";


        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //    textBox1.Clear();
            if (_isError)
            {
                btnC.PerformClick();
                return;
            }
            textBox1.Text = "0";
        }

        // Remove Form Border & Create Your Own Title Bar | C# WinForms
        //---------------------------------------------------------------

        // How to Make Button Rounded?
        private void MakeButtonRounded(Button btn, int radius)
        {
            radius = Math.Min(radius, Math.Min(btn.Width, btn.Height));


            GraphicsPath path = new GraphicsPath();
            // Top-left
            path.AddArc(0, 0, radius, radius, 180, 90);
            // Top-right
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            // Bottom-right
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            // Bottom-left
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
            /*

                              270°
                               ↑
                               |
                               |
                               |
            180°  ←────────────●────────────→  0°
                               |
                               |
                               |
                               ↓
                              90°



            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*            foreach (Control control in Controls)
                        {
                            if (control is Button button)
                            {
                                MakeButtonRounded(button, 130);
                            }
                        }
            */
            btnClearHistory.Parent = pnlHistory;
            pnlHistory.Visible = false;
            pnlHistory.Height = 0;
            pnlHistory.BringToFront();
            btnClearHistory.BringToFront();

            pnlHistory.Parent = this;
            // Initialize history display
            UpdateHistoryDisplay();

            this.KeyPreview = true;
            // this.KeyDown += Form1_KeyDown; //Duplicated numbers!
            textBox1.ReadOnly = true;
            textBox1.TabStop = false;
        }

        // How to Move a Borderless Form in C# WinForms
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = e.Location;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

            if (pnlHistory.Height == 0)
            {
                pnlHistory.Visible = true;
                pnlHistory.Height = 400;
                pnlHistory.BringToFront();
            }
            else
            {
                pnlHistory.Visible = false;
                pnlHistory.Height = 0;
            }

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !e.Shift) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                string numberPressed = e.KeyCode.ToString().Replace("D", "").Replace("NumPad", "");
                ClickButtonByText(numberPressed);
                e.SuppressKeyPress = true;
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Oemplus when e.Shift:
                    ClickButtonByTag("+");
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Subtract:
                case Keys.OemMinus when !e.Shift:
                    ClickButtonByTag("-");
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Multiply:
                case Keys.D8 when e.Shift:
                    ClickButtonByTag("*");
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Divide:
                case Keys.OemQuestion when !e.Shift:
                    ClickButtonByTag("/");
                    e.SuppressKeyPress = true;
                    break;

                case Keys.D5 when e.Shift:
                    ClickButtonByTag("%");
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Decimal:
                case Keys.OemPeriod:
                    ClickButtonByText(".");
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    btnEqual.PerformClick();
                    break;


                case Keys.Back:
                    btnBackSpace.PerformClick();
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Escape:
                    btnC.PerformClick();
                    e.SuppressKeyPress = true;
                    break;

                case Keys.Delete:
                    btnCE.PerformClick();
                    e.SuppressKeyPress = true;
                    break;
            }

        }
        private void ClickButtonByText(string text)
        {


            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ctrlRoundedButton btn && btn.Text == text)
                {
                    btn.PerformClick();
                    break;
                }
            }
        }
        private void ClickButtonByTag(string tag)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ctrlRoundedButton btn && btn.Tag != null && btn.Tag.ToString() == tag)
                {
                    btn.PerformClick();
                    break;
                }
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtbHistory.Clear();
            rtbHistory.Text = "There's no history.";
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(
                    // Old Form X + (Current Mouse X - Initial Mouse X)
                    Location.X + e.X - _mouseLocation.X,
                    Location.Y + e.Y - _mouseLocation.Y);
            }
        }

        private string FormattedNumber(double number)
        {
            return number.ToString("#,##0.#######################");
        }
    }
}
