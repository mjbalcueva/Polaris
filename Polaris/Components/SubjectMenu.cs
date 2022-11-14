using Polaris.Forms.Subjects;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class SubjectMenu : UserControl
    {
        public SubjectMenu()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _btnText;
        private Color _btnForeColor;
        private Color _iconColor;

        [Category("Subject Property")]
        public string ButtonText
        {
            get { return _btnText; }
            set { _btnText = value; subjectMenuItem.Text = value; }
        }

        [Category("Subject Property")]
        public Color ButtonForeColor
        {
            get { return _btnForeColor; }
            set { _btnForeColor = value; subjectMenuItem.ForeColor = value; }
        }

        [Category("Subject Property")]
        public Color IconColor
        {
            get { return _iconColor; }
            set { _iconColor = value; subjectMenuItem.IconColor = value; }
        }

        #endregion Getter, Setter & Constructor

        private void subjectMenuItem_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;

            root.MenuLabel.Text = ButtonText;
            root.OpenChildForm(new Subjects());
        }
    }
}