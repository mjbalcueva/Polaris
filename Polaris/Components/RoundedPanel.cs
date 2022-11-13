using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Polaris.Components
{
    internal class RoundedPanel : Panel
    {
        // Fields

        private int borderRadius = 15;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.MediumPurple;

        // Constructor

        public RoundedPanel()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(100, 100);
        }

        // Properties

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                Invalidate();
            }
        }

        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                Invalidate();
            }
        }

        // Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Overriden Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, gradientTopColor, gradientBottomColor, gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            // Border Radius
            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(rectangleF, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                Region = new Region(rectangleF);
            }
        }
    }
}