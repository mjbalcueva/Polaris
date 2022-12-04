using Polaris.Components;
using System;
using System.Collections;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Forms.FinanceTracker
{
    public partial class FinanceTracker : Form
    {
        public FinanceTracker()
        {
            InitializeComponent();
        }

        private void tableBody_Resize(object sender, EventArgs e)
        {
            foreach (Control c in tableBodyFLP.Controls)
            {
                c.Width = tableBodyFLP.Width;
            }
        }

        #region Load Data

        private static readonly ArrayList records = new ArrayList();
        public ArrayList TableRecord { get; set; } = records;

        private void GetData()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=root;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM finance", connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string value = dataReader.GetString(1);
                string description = dataReader.GetString(2);
                string createdDate = dataReader.GetString(3);
                string modifiedDate = dataReader.GetString(4);

                string[] date;
                date = createdDate.Split(' ');
                createdDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                date = modifiedDate.Split(' ');
                modifiedDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                //AddRecord(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                AddRecord(value, description, createdDate, modifiedDate);
            }

            connection.Close();
        }

        internal void AddRecord(string value, string description, string created, string modified)
        {
            TableRecord.Add(new tableFT
            {
                Value = value,
                Description = description,
                CreatedDate = created,
                ModifiedDate = modified
            });
        }

        public void GenerateDynamicRecords()
        {
            tableBodyFLP.Controls.Clear();
            int recordCount = TableRecord.Count;
            double totalValue = 0;

            for (int i = 0; i < recordCount; i++)
            {
                tableBodyFLP.Controls.Add((tableFT)TableRecord[i]);
                totalValue += Convert.ToDouble(((tableFT)TableRecord[i]).Value);
            }

            totalValueLabel.Text = totalValue.ToString();
        }

        #endregion Load Data

        private void FinanceTracker_Load(object sender, EventArgs e)
        {
            TableRecord.Clear();
            GetData();
            GenerateDynamicRecords();
        }
    }
}