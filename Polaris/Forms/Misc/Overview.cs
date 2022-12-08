using System.Windows.Forms;

namespace Polaris.Forms.Misc
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void HiddenScroll()
        {
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
            flowLayoutPanel1.VerticalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Overview_Load(object sender, System.EventArgs e)
        {
            HiddenScroll();
        }
    }
}