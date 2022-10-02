using System;
using System.Windows.Forms;

namespace Polaris
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
            SidePanel.Visible = false;
        }

        private void TogglePanelBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = !SidePanel.Visible;
        }
    }
}