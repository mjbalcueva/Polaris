using FontAwesome.Sharp;
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
        public IconChar IconChar
        {
            get { return _iconChar; }
            set { _iconChar = value; taskMenuItem.IconChar = value; }
        }

        [Category("Task Property")]
        public Color BadgeIconColor
        {
            get { return _badgeIconColor; }
            set { _badgeIconColor = value; badge.IconColor = value; }
        }

        #endregion Getter, Setter & Constructor
    }
}