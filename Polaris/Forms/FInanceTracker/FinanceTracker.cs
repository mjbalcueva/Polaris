using System.Windows.Forms;

namespace Polaris.Forms.FinanceTracker
{
    public partial class FinanceTracker : Form
    {
        public FinanceTracker()
        {
            InitializeComponent();
        }

        private void tableBody_Resize(object sender, System.EventArgs e)
        {
            // resize usercontrol child
            foreach (Control c in tableBody.Controls)
            {
                c.Width = tableBody.Width;
            }
        }
    }
}