using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class SubjectAdd : UserControl
    {
        public SubjectAdd()
        {
            InitializeComponent();
        }

        #region Events

        public void bgHover_MouseEnter(object sender, System.EventArgs e)
        {
            bgHover.GradientTopColor = ColorTranslator.FromHtml("#27282F");
            bgHover.GradientBottomColor = ColorTranslator.FromHtml("#27282F");
        }

        private void bgHover_MouseLeave(object sender, System.EventArgs e)
        {
            bgHover.GradientTopColor = ColorTranslator.FromHtml("#1B1C22");
            bgHover.GradientBottomColor = ColorTranslator.FromHtml("#1B1C22");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Root root = (Root)ParentForm;
                root.AddSubject(textBox1.Text.Trim(), root.Color);

                string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
                OdbcConnection connection = new OdbcConnection(connectionString);

                connection.Close();
                connection.Open();

                OdbcCommand cmd = new OdbcCommand("INSERT INTO subject(subject_title) VALUES('" + textBox1.Text.Trim() + "')", connection);
                cmd.ExecuteNonQuery();

                connection.Close();

                textBox1.Text = "";
                root.GenerateDynamicSubjects();
            }
        }

        #endregion Events

        private void badge_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;
            root.GenerateDynamicSubjects();
        }
    }
}