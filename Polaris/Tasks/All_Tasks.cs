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

        private void newRecBtn_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new Tasks.New_Tasks());
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.Show();
        }
    }
}