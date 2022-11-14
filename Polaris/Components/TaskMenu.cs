using Polaris.Forms.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class TaskMenu : UserControl
    {
        public TaskMenu()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _btnText;
        private Color _btnForeColor;
        private Color _iconColor;
        private string _badgeText;

        [Category("Task Property")]
        public string ButtonText
        {
            get { return _btnText; }
            set { _btnText = value; taskMenuItem.Text = value; }
        }

        [Category("Task Property")]
        public Color ButtonForeColor
        {
            get { return _btnForeColor; }
            set { _btnForeColor = value; taskMenuItem.ForeColor = value; }
        }

        [Category("Task Property")]
        public Color IconColor
        {
            get { return _iconColor; }
            set { _iconColor = value; taskMenuItem.IconColor = value; }
        }

        [Category("Task Property")]
        public string BadgeText
        {
            get { return _badgeText; }
            set { _badgeText = value; badge.Text = value; }
        }

        #endregion Getter, Setter & Constructor

        #region Button Click Events

        private void taskMenuItem_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;
            root.MenuLabel.Text = "Tasks";
            root.ToggleButtonFontColor(taskMenuItem);
            root.ToggleButtonIconColor(taskMenuItem);
            root.OpenChildForm(new Tasks());
        }

        #endregion Button Click Events
    }
}