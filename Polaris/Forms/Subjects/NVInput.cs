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
    public partial class NVInput : Form
    {

        private bool mouseDown = false;
        private string subText;
        private int subID;
        static NVInput note = new NVInput();
        
        public NVInput()
        {
            InitializeComponent();
        }

        public NVInput(string text)
        {
            note.subText = text;
            InitializeComponent();
        }

        #region Events
       
        public bool editing = false;
        public string recordID = "";
  
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand read = new OdbcCommand("SELECT id FROM subject WHERE subject_title = '" + note.subText + "'", connection);
            dataReader = read.ExecuteReader();

            while (dataReader.Read())
            {
                string subjID = dataReader.GetString(0);
                note.subID = Int32.Parse(subjID);
            } 
                if (editing)
            {
                OdbcCommand cmd = new OdbcCommand($"UPDATE note SET note_title = '{titleLabel.Text}', note_description = '{descriptionLabel.Text}', modified = NOW() WHERE subject_id = {recordID}",
                        connection);
                cmd.ExecuteNonQuery();
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand($"INSERT INTO note (note_title, note_description, subject_id) VALUES ('{titleLabel.Text}', '{descriptionLabel.Text}', '{note.subID}')", connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            Close();

            Root root = (Root)Application.OpenForms["Root"];
            root.OpenChildForm(new Subjects(note.subText));
        }
    }
            
        #endregion Events
    }

