using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class SubjectsButton : UserControl
    {
        public SubjectsButton()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Button Text, ForeColor & IconColor

        private string _btnText;
        private Color _btnForeColor;
        private Color _iconColor;

        [Category("Subject Property")]
        public string ButtonText
        {
            get { return _btnText; }
            set { _btnText = value; subjectButton.Text = value; }
        }

        [Category("Subject Property")]
        public Color ButtonForeColor
        {
            get { return _btnForeColor; }
            set { _btnForeColor = value; subjectButton.ForeColor = value; }
        }

        [Category("Subject Property")]
        public Color IconColor
        {
            get { return _iconColor; }
            set { _iconColor = value; subjectButton.IconColor = value; }
        }

        #endregion Getter & Setter For Button Text, ForeColor & IconColor
    }
}