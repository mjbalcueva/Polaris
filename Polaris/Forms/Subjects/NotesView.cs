using Polaris.Components;
using Polaris.Forms.FinanceTracker;
using System;
using System.Collections;
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
    public partial class NotesView : Form
    {
        private string subText; 
        static NotesView note = new NotesView(); 
        
        public NotesView()
        {
            InitializeComponent();
        }

        public NotesView(string text)
        {
            note.subText = text;
            InitializeComponent();
        }

        
        private static readonly ArrayList records = new ArrayList();
        public ArrayList TableRecord { get; set; } = records;

        private void GetData(int subjectID)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM note WHERE subject_id = '" + subjectID + "'", connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string note_title = dataReader.GetString(1);
                string note_description = dataReader.GetString(2);
                string createdDate = dataReader.GetString(3);
                string modifiedDate = dataReader.GetString(4);

                string[] date;
                date = createdDate.Split(' ');
                createdDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                date = modifiedDate.Split(' ');
                modifiedDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                AddRecord(note_title, note_description, createdDate, modifiedDate);
            }

            connection.Close();
        }

        internal void AddRecord(string title, string description, string created, string modified)
        { 
            TableRecord.Add(new tableNV
            {
                NoteTitle = title,
                NoteDesc = description,
                CreatedDate = created,
                ModifiedDate = modified
            }); 
        }

        public void GenerateDynamicRecords()
        {
            tableBodyFLP.Controls.Clear();
            int recordCount = TableRecord.Count;

           for (int i = 0; i < recordCount; i++)
            {
                tableBodyFLP.Controls.Add((tableNV)TableRecord[i]);
            }
        }

        private void NotesView_Load(object sender, EventArgs e)
        {   
            TableRecord.Clear();
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;
                      
            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT id FROM subject WHERE subject_title = '" + note.subText + "'", connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string subjID = dataReader.GetString(0);
                int subID = Int32.Parse(subjID);
                
                GetData(subID);
            }
            connection.Close(); 
            GenerateDynamicRecords();
        }

        private void tableBodyFLP_Resize_1(object sender, EventArgs e)
        {
            foreach (Control c in tableBodyFLP.Controls)
            {
                c.Width = tableBodyFLP.Width;
            }
        }
    }
}
