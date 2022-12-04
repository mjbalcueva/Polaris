using FontAwesome.Sharp;
using Polaris.Forms.FinanceTracker;
using System;
using System.Collections;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Polaris.Forms.Tasks
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }
        
        private void checkBox_Click(object sender, EventArgs e)
        {
            checkBox.IconChar = checkBox.IconChar == IconChar.Square ? IconChar.CheckSquare : IconChar.Square;
        }

        private static readonly ArrayList records = new ArrayList();
        public ArrayList TableRecord { get; set; } = records;

        private void GetData(int section)
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=root;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM task WHERE group_id = '" + section + "'", connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string completed = dataReader.GetString(1);
                string description = dataReader.GetString(2);
                string createdDate = dataReader.GetString(3);
                string modifiedDate = dataReader.GetString(4);

                string[] date;
                date = createdDate.Split(' ');
                createdDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                date = modifiedDate.Split(' ');
                modifiedDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                AddRecord(completed, description, createdDate, modifiedDate);
            }
            connection.Close();
        }

        internal void AddRecord(string completed, string description, string created, string modified)
        {
            TableRecord.Add(new tableTasks
            {
                Completed = completed,
                TaskDesc = description,
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
                tableBodyFLP.Controls.Add((tableTasks)TableRecord[i]);
            }
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            TableRecord.Clear();
            if (sectionLabel.Text == "Drafts Section")
            {
                GetData(1);
            }
            else if (sectionLabel.Text == "Archives Section")
            {
                GetData(2);
            }
            else if (sectionLabel.Text == "Deleted Section")
            {
                GetData(3);
            } else
            {
                GetData(0);
            }
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
