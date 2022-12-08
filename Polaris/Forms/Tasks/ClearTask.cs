using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
            if(mouseDown)
            Location = new Point(Cursor.Position.X - 300, Cursor.Position.Y - 15);
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            connection.Close();
            connection.Open();

            if (DeleteLabel.Text == "Delete all records in Drafts Section?")
            {
                OdbcCommand cmd = new OdbcCommand($"DELETE FROM task WHERE group_id = 1", connection);
                cmd.ExecuteNonQuery();
            }
            else if (DeleteLabel.Text == "Delete all records in Archived Section?")
            {
                OdbcCommand cmd = new OdbcCommand($"DELETE FROM task WHERE group_id = 2", connection);
                cmd.ExecuteNonQuery();
            }
            else if (DeleteLabel.Text == "Delete all records in Deleted Section?")
            {
                OdbcCommand cmd = new OdbcCommand($"DELETE FROM task WHERE group_id = 3", connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            Close();
 
            Root root = (Root)Application.OpenForms["Root"];
            root.OpenChildForm(new Tasks());
        }
    }
}
