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
    public partial class ActivitiesView : Form //change Password="your password";
    {
        private string subText;
        static ActivitiesView activity = new ActivitiesView();
        
        public ActivitiesView()
        {
            InitializeComponent();
        }
        
        public ActivitiesView(string text)
        {
            activity.subText = text;
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

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM activity WHERE subject_id = '" + subjectID + "'", connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string score = dataReader.GetString(1);
                string description = dataReader.GetString(3);
                string createdDate = dataReader.GetString(4);
                string modifiedDate = dataReader.GetString(5);

                string[] date;
                date = createdDate.Split(' ');
                createdDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                date = modifiedDate.Split(' ');
                modifiedDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                AddRecord(score, description, createdDate, modifiedDate);
            }

            connection.Close();
        }

        internal void AddRecord(string score, string description, string created, string modified)
        {
            TableRecord.Add(new tableAV
            {
                Score = score,
                ActDesc = description,
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
                tableBodyFLP.Controls.Add((tableAV)TableRecord[i]);
            }
        }

        private void ActivitiesView_Load(object sender, EventArgs e)
        {
            TableRecord.Clear();
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT id FROM subject WHERE subject_title = '" + activity.subText + "'", connection);
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

        private void tableBodyFLP_Resize(object sender, EventArgs e)
        {
            foreach (Control c in tableBodyFLP.Controls)
            {
                c.Width = tableBodyFLP.Width;
            }

        }
    }
}
