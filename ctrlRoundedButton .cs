using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ctrlRoundedButton : Button
{
    private int _borderRadius = 15;

    public int BorderRadius
    {
        get { return _borderRadius; }
        set
        {
            _borderRadius = value;
            UpdateRegion();
        }
    }

    public ctrlRoundedButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
    }

    protected override void OnResize(System.EventArgs e)
    {
        base.OnResize(e);
        UpdateRegion();
    }

    private void UpdateRegion()
    {
        int radius = Math.Min(_borderRadius, Math.Min(Width, Height));

        GraphicsPath path = new GraphicsPath();

        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
        path.AddArc(0, Height - radius, radius, radius, 90, 90);

        path.CloseFigure();

        Region = new Region(path);
    }
}