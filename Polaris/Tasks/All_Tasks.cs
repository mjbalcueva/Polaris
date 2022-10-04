using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Tasks
{
    public partial class All_Tasks : Form
    {
        public All_Tasks()
        {
            InitializeComponent();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, MenuPanel.ClientRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }
    }
}