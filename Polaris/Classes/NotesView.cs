using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Classes
{
    public partial class NotesView : Form
    {
        public NotesView()
        {
            InitializeComponent();
        }

        #region CustomStyles

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            AddBorder(e);
        }

        private static void AddBorder(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }

        #endregion CustomStyles
    }
}