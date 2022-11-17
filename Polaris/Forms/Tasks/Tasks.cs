using FontAwesome.Sharp;
using System;
using System.Windows.Forms;

namespace Polaris.Forms.Tasks
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            // change self iconchar to CheckSquare
            checkBox.IconChar = checkBox.IconChar == IconChar.Square ? IconChar.CheckSquare : IconChar.Square;
        }
    }
}