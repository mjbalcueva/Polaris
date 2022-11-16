using FontAwesome.Sharp;
using Polaris.Forms.Extra;
using Polaris.Forms.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class SidebarMenu : UserControl
    {
        public SidebarMenu()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _btnText;
        private Color _btnForeColor;
        private IconChar _iconChar;
        private Color _iconColor;
        private Color _badgeIconColor;

        [Category("Task Property")]
        public string ButtonText
        {
            get { return _btnText; }
            set { _btnText = value; sidebarMenuItem.Text = value; }
        }

        [Category("Task Property")]
        public Color ButtonForeColor
        {
            get { return _btnForeColor; }
            set { _btnForeColor = value; sidebarMenuItem.ForeColor = value; }
        }

        [Category("Task Property")]
        public Color IconColor
        {
            get { return _iconColor; }
            set { _iconColor = value; sidebarMenuItem.IconColor = value; }
        }

        [Category("Task Property")]
        public IconChar IconChar
        {
            get { return _iconChar; }
            set { _iconChar = value; sidebarMenuItem.IconChar = value; }
        }

        [Category("Task Property")]
        public Color BadgeIconColor
        {
            get { return _badgeIconColor; }
            set { _badgeIconColor = value; badge.IconColor = value; }
        }

        #endregion Getter, Setter & Constructor

        #region Button Click Events

        private void sidebarMenuItem_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;

            if (ButtonText == "  Tasks")
            {
                root.MenuLabel.Text = "Tasks";
                root.OpenChildForm(new Tasks());
            }
            else if (ButtonText == "  Subjects")
            {
                if (sidebarMenuItem.IconChar == IconChar.ChevronUp)
                {
                    sidebarMenuItem.IconChar = IconChar.ChevronDown;
                    root.subjectsFLP.Visible = true;
                }
                else
                {
                    sidebarMenuItem.IconChar = IconChar.ChevronUp;
                    root.subjectsFLP.Visible = false;
                }
            }
            else if (ButtonText == "  Finance Tracker")
            {
                root.MenuLabel.Text = "Extra";
                root.OpenChildForm(new FinanceTracker());
            }
        }

        private void badge_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;

            if (ButtonText == "  Tasks")
            {
                root.MenuLabel.Text = "Tasks Badge Clicked";
            }
            else if (ButtonText == "  Subjects")
            {
                root.subjectsFLP.Visible = true;
                SubjectAdd subjectAdd = new SubjectAdd();

                Color nextColor = ColorTranslator.FromHtml(root.randColors[new System.Random().Next(0, root.randColors.Length)]);
                root.color = nextColor;

                subjectAdd.icon.GradientTopColor = nextColor;
                subjectAdd.icon.GradientBottomColor = nextColor;

                root.subjectsFLP.Controls.Add(subjectAdd);
                root.subjectsFLP.Controls.SetChildIndex(root.subjectsFLP.Controls[root.subjectsFLP.Controls.Count - 1], 0);
                root.subjectsFLP.Controls[0].Controls[0].Controls[0].Focus();
                root.subjectsFLP.Height += 56;
            }
            else if (ButtonText == "  Finance Tracker")
            {
                root.MenuLabel.Text = "Extra Badge Clicked";
            }
        }

        #endregion Button Click Events
    }
}