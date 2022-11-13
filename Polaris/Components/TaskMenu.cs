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

        #endregion Getter, Setter & Constructor
    }
}