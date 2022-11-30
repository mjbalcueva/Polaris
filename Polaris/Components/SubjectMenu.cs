using Polaris.Forms.Misc;
using Polaris.Forms.Subjects;
using System.ComponentModel;
using System.Data.Odbc;
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

        #region Button Click Events

        private void subjectMenuItem_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;
            root.MenuLabel.Text = ButtonText.Trim();
            root.OpenChildForm(new Subjects());
        }

        private void subjectMenuItem_Enter(object sender, System.EventArgs e)
        {
            badge.Visible = true;
            subjectMenuItem.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        private void subjectMenuItem_Leave(object sender, System.EventArgs e)
        {
            badge.Visible = false;
            subjectMenuItem.ForeColor = ColorTranslator.FromHtml("#6A6A73");
        }

        private void badge_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;

            root.SubjectMenu.Remove(this);
            RemoveSubjectFromDB();
            root.GenerateDynamicSubjects();
            root.MenuLabel.Text = "Overview";
            root.OpenChildForm(new Overview());
        }

        #endregion Button Click Events

        #region RemoveSubjectFromDB

        private void RemoveSubjectFromDB()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("DELETE FROM subject WHERE subject_title = '" + ButtonText.Trim() + "'", connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        #endregion RemoveSubjectFromDB

        private void SubjectMenu_Load(object sender, System.EventArgs e)
        {
            badge.Visible = false;
        }
    }
}