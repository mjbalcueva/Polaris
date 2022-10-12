using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polaris.Tasks
{
    public partial class New_Tasks : Form
    {
        public New_Tasks()
        {
            InitializeComponent();
        }

        private static void AddBorderUp(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }

        private void newTasksPanel_Paint(object sender, PaintEventArgs e)
        {
            AddBorderDown(e);
        }

        private void newTasksBtns_Paint(object sender, PaintEventArgs e)
        {
            AddBorderUp(e);
        }
        private static void AddBorderDown(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid);
        }
    }
}
