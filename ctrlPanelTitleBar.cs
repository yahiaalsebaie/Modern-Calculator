using System.Drawing;
using System.Windows.Forms;

namespace Modern_Calculator
{

    public class ctrlPanelTitleBar : Panel
    {
        private Point _mouseLocation;

        public ctrlPanelTitleBar()
        {
            this.MouseDown += ctrlPanelTitleBar_MouseDown;
            this.MouseMove += ctrlPanelTitleBar_MouseMove;
        }

        private void ctrlPanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseLocation = e.Location;
            }
        }

        private void ctrlPanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form form = this.FindForm();

                if (form != null)
                {
                    form.Location = new Point(
                        form.Location.X + (e.X - _mouseLocation.X),
                        form.Location.Y + (e.Y - _mouseLocation.Y));
                }
            }
        }
    }

}