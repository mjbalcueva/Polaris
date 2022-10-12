using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris.FTS
{
    public partial class FTSView : Form
    {
        public FTSView()
        {
            InitializeComponent();
        }

        private void newRecBtn_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new FTS.Cash_Flow());
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.Show();
        }

    }
}