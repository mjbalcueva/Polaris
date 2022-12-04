using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polaris.Forms.Subjects
{
    public partial class tableAV : UserControl //need help in placing max_score next to current_score(Score panel)
    {
        public tableAV()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _value = "0";
        private string _description = "Description";
        private string _createdDate = "Created Date";
        private string _modifiedDate = "Modified Date";
        private Color _color = ColorTranslator.FromHtml("#141519");

        [Category("Record Property")]
        public string Score
        {
            get { return _value; }
            set { _value = value; ScoreLabel.Text = value; }
        }

        [Category("Record Property")]
        public string ActDesc
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

        [Category("Record Property")]
        public Color Color
        {
            get { return _color; }
            set { _color = value; background.BackColor = value; }
        }

        #endregion Getter, Setter & Constructor

        private void tableFT_Load(object sender, EventArgs e)
        {
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            background.BackColor = ColorTranslator.FromHtml("#1B1C22");
        }

        private void control_MouseLeave(object sender, EventArgs e)
        {
            background.BackColor = ColorTranslator.FromHtml("#141519");
        }
    }
}
