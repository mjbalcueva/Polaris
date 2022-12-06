using System.ComponentModel;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class Tag : UserControl
    {
        public Tag()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _tagName = "Tag";

        [Category("Tag Property")]
        public string TagName
        {
            get { return _tagName; }
            set { _tagName = value; tagLabel.Text = value; }
        }

        [Category("Tag Property")]
        public string TagID { get; set; } = "0";

        [Category("Tag Property")]
        public string TagParentID { get; set; } = "-1";

        #endregion Getter, Setter & Constructor
    }
}