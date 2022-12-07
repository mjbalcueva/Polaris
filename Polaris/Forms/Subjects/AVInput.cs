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

namespace Polaris.Forms.Subjects
{
    public partial class AVInput : Form
    {
        private bool mouseDown = false;
        private string subText;
        private int subID;
        static AVInput act = new AVInput();
        public AVInput()
        {
            InitializeComponent();
        }

        public AVInput(string text)
        {
            act.subText = text;
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
            Close();
        }

        public bool editing = false;
        public string recordID = "";

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand read = new OdbcCommand("SELECT id FROM subject WHERE subject_title = '" + act.subText + "'", connection);
            dataReader = read.ExecuteReader();

            while (dataReader.Read())
            {
                string subjID = dataReader.GetString(0);
                act.subID = Int32.Parse(subjID);
            }
            if (editing)
            {
                OdbcCommand cmd = new OdbcCommand($"UPDATE activity SET current_score = '{scoreLabel.Text}', max_score = '{outOfLabel.Text}', activity_description = '{descriptionLabel.Text}', modified = NOW() WHERE subject_id = {recordID}",
                        connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand($"INSERT INTO activity (current_score, max_score, activity_description, subject_id) VALUES ('{scoreLabel.Text}', '{outOfLabel.Text}', '{descriptionLabel.Text}', '{act.subID}')", connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            Close();

            Root root = (Root)Application.OpenForms["Root"];
            root.OpenChildForm(new Subjects(act.subText));
        }
        
        #endregion Events
    }
}
