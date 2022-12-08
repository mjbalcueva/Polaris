using System;
using System.Collections;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Forms.Tasks
{
    public partial class TasksInput : Form
    {
        private bool mouseDown = false;

        public TasksInput()
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (descriptionLabel.Text.Trim() == "")
            {
                Close();
            }
            else
            {
                string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
                OdbcConnection connection = new OdbcConnection(connectionString);

                connection.Close();
                connection.Open();

                OdbcCommand cmd = new OdbcCommand($"INSERT INTO task (description, group_id) VALUES ('{descriptionLabel.Text}', 1)", connection);
                cmd.ExecuteNonQuery();

                connection.Close();
                Close();
            }

            Root root = (Root)Application.OpenForms["Root"];
            root.UpdateTaskCount();
        }

        public bool editing = false;
        public string recordID = "";

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            connection.Close();
            connection.Open();

            if (editing)
            {
                OdbcCommand cmd = new OdbcCommand($"UPDATE task SET description = '{descriptionLabel.Text}', modified = NOW() WHERE id = {recordID}",
                        connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand($"INSERT INTO task (description) VALUES ('{descriptionLabel.Text}')", connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            Close();

            Root root = (Root)Application.OpenForms["Root"];
            root.UpdateTaskCount();
            Tasks tasks = (Tasks)Application.OpenForms["Tasks"];
            tasks.Tasks_Load(sender, e);
        }

        #endregion Events
    }
}