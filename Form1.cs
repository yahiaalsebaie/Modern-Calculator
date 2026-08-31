using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Modern_Calculator
{
    public partial class Form1 : Form
    {
        private Point _mouseLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // How to Make Button Rounded?
        /* private void MakeButtonRounded(Button btn, int radius)
         {
             GraphicsPath path = new GraphicsPath();

             path.AddArc(0, 0, radius, radius, 180, 90);
             path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
             path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
             path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);

             path.CloseFigure();

             btn.Region = new Region(path);

         }

         private void Form1_Load(object sender, EventArgs e)
         {
             //foreach (Control control in Controls)
             //{
             //    if (control is Button button)
             //    {
             //        MakeButtonRounded(button, 150);
             //    }
             //}

             MakeButtonRounded(button1, 200);
             MakeButtonRounded(button2, 30);
         }*/


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
                    Location.X + (e.X - _mouseLocation.X),
                    Location.Y + e.Y - _mouseLocation.Y);
            }
        }
        // Remove Form Border & Create Your Own Title Bar | C# WinForms
        //---------------------------------------------------------------
      
    }
}
