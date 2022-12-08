using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Forms.FinanceTracker
{
    public partial class FTInput : Form
    {
        private bool mouseDown = false;

        public FTInput()
        {
            InitializeComponent();
        }

        #region Events

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
                Location = new Point(Cursor.Position.X - 300, Cursor.Position.Y - 15);
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        public bool editing = false;
        public string recordID = "";

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            connection.Close();
            connection.Open();

            if (editing)
            {
                OdbcCommand cmd = new OdbcCommand($"UPDATE finance SET value = '{valueLabel.Text}', description = '{descriptionLabel.Text}', modified = NOW() WHERE id = {recordID}",
                    connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand($"INSERT INTO finance (value, description) VALUES ('{valueLabel.Text}', '{descriptionLabel.Text}')", connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            Close();

            FinanceTracker financeTracker = (FinanceTracker)Application.OpenForms["FinanceTracker"];
            financeTracker.FinanceTracker_Load(sender, e);
        }

        #endregion Events
    }
}