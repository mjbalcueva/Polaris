using System;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Forms.Tasks
{
    public partial class ClearTask : Form
    {
        private bool mouseDown = false;

        public ClearTask()
        {
            InitializeComponent();
        }

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
            Close();

            Root root = (Root)Application.OpenForms["Root"];
            root.UpdateTaskCount();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            Tasks tasks = (Tasks)Application.OpenForms["Tasks"];
            string currentText = tasks.sectionLabel.Text;

            connection.Close();
            connection.Open();

            if (currentText == "Drafts Section")
            {
                MoveTaskToDeleted("1", connection);
            }
            else if (currentText == "Archives Section")
            {
                MoveTaskToDeleted("2", connection);
            }
            else if (currentText == "Deleted Section")
            {
                DeleteAll(connection);
            }

            connection.Close();
            Close();

            tasks.TableRecord.Clear();
            tasks.GenerateDynamicRecords();

            Root root = (Root)Application.OpenForms["Root"];
            root.UpdateTaskCount();
        }

        private static void DeleteAll(OdbcConnection connection)
        {
            OdbcCommand cmd = new OdbcCommand($"DELETE FROM task WHERE group_id = 3", connection);
            cmd.ExecuteNonQuery();
        }

        private void MoveTaskToDeleted(string groupId, OdbcConnection connection)
        {
            OdbcCommand cmd = new OdbcCommand("UPDATE task SET group_id = 3 WHERE group_id = " + groupId, connection);
            cmd.ExecuteNonQuery();
        }
    }
}