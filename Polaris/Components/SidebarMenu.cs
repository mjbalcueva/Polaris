using FontAwesome.Sharp;
using Polaris.Forms.Subjects;
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

        private void sidebarMenuItem_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;
            root.MenuLabel.Text = ButtonText.Substring(2);

            if (ButtonText == "  Tasks")
            {
                root.OpenChildForm(new Tasks());
            }
            else if (ButtonText == "  Subjects")
            {
                root.OpenChildForm(new Subjects());
            }
        }
    }
}