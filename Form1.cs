using System;
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
        private enum enOperation
        {
            Add, Subtract, Multiply, Divide
        }
        private enOperation _Operation;
        public Form1()
        {
            InitializeComponent();
            _originalFont = textBox1.Font;
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
                textBox1.Text += btn.Text;
            }

        }

        private void Operations_Click(object sender, EventArgs e)
        {
            ctrlRoundedButton btn = (ctrlRoundedButton)sender;

            if (!_hasResult)
            {
                _firstNumber = double.Parse(textBox1.Text);
                _result = _firstNumber;
                _hasResult = true;
            }
            else if (!_isNewEntry)
            {

                btnEqual.PerformClick();
                _firstNumber = _result;
            }
            else _firstNumber = _result;

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
            }

            textBox2.Text = _firstNumber + " " + btn.Text + " ";
            //textBox2.Text = $"{_firstNumber} {btn.Tag} ";
            _isNewEntry = true;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (_isError) btnC.PerformClick();
            _secondNumber = double.Parse(textBox1.Text);
            switch (_Operation)
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
                        _isError = true;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 20, textBox1.Font.Style);
                        textBox1.Text = "Cannot divide by zero";
                        return;
                    }
                    _result = _firstNumber / _secondNumber;
                    break;
                default:
                    break;
            }
            textBox1.Text = _result.ToString();
            textBox2.Text += _secondNumber.ToString();
            _isNewEntry = true;
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



        // How to Move a Borderless Form in C# WinForms
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = e.Location;
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

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (_isError) btnC.PerformClick();
            if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
          //  if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == string.Empty) textBox1.Text = "0";


        }

        private void btnCE_Click(object sender, EventArgs e)
        {
        //    textBox1.Clear();
        if(_isError)
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

        }

    }
}
