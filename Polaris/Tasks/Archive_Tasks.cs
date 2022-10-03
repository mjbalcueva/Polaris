using System.Drawing;
using System.Windows.Forms;

namespace Polaris
{
    public partial class Archive_Tasks : Form
    {
        public Archive_Tasks()
        {
            InitializeComponent();
        }

        private void ViewHeader_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ViewHeader.ClientRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }
    }
}