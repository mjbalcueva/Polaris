using System.Drawing;
using System.Windows.Forms;

namespace Polaris
{
    public partial class SubjectsBtn : UserControl
    {
        public SubjectsBtn()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Button Text, ForeColor, IconChar & IconColor

        private string _btnText;
        private Color _btnForeColor;
        private Color _iconColor;

        public string BtnText
        {
            get { return _btnText; }
            set { _btnText = value; subjectButton.Text = value; }
        }

        public Color BtnForeColor
        {
            get { return _btnForeColor; }
            set { _btnForeColor = value; subjectButton.ForeColor = value; }
        }

        public Color IconColor
        {
            get { return _iconColor; }
            set { _iconColor = value; subjectButton.IconColor = value; }
        }

        #endregion Getter & Setter For Button Text, ForeColor, IconChar & IconColor
    }
}