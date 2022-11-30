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

        private void checkBox_Click(object sender, EventArgs e)
        {
            checkBox.IconChar = checkBox.IconChar == IconChar.Square ? IconChar.CheckSquare : IconChar.Square;
        }
    }
}