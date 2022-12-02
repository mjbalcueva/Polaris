using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Polaris.Forms.FinanceTracker
{
    public partial class tableFT : UserControl
    {
        public tableFT()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _value;
        private string _description;
        private string _createdDate;
        private string _modifiedDate;

        [Category("Record Property")]
        public string Value
        {
            get { return _value; }
            set { _value = value; ValueLabel.Text = value; }
        }

        [Category("Record Property")]
        public string Description
        {
            get { return _description; }
            set { _description = value; DescriptionLabel.Text = value; }
        }

        [Category("Record Property")]
        public string[] Tags { get; set; }

        [Category("Record Property")]
        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; CreatedLabel.Text = value; }
        }

        [Category("Record Property")]
        public string ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; ModifiedLabel.Text = value; }
        }

        #endregion Getter, Setter & Constructor

        private void tableFT_Load(object sender, EventArgs e)
        {
            // hide iconbutton
            iconButton1.Visible = false;
            iconButton2.Visible = false;
        }
    }
}