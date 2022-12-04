using System;
using System.Collections;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Polaris.Forms.FinanceTracker
{
    public partial class FinanceTracker : Form
    {
        public FinanceTracker()
        {
            InitializeComponent();
        }

        #region Resize Table

        private void tableBody_Resize(object sender, EventArgs e)
        {
            foreach (Control c in tableBodyFLP.Controls)
            {
                c.Width = tableBodyFLP.Width;
            }
        }

        #endregion Resize Table

        #region Events

        private void sectionButton_Click(object sender, EventArgs e)
        {
            // open FTInput form
            FTInput ftInput = new FTInput();
            ftInput.Show();
        }

        #endregion Events

        #region Load Data

        private static readonly ArrayList records = new ArrayList();
        public ArrayList TableRecord { get; set; } = records;

        private void GetData()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM finance", connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string id = dataReader.GetString(0);
                string value = dataReader.GetString(1);
                string description = dataReader.GetString(2);
                string createdDate = dataReader.GetString(3);
                string modifiedDate = dataReader.GetString(4);

                string[] date;
                date = createdDate.Split(' ');
                createdDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];
                date = modifiedDate.Split(' ');
                modifiedDate = date[0].Split('-')[0] + " / " + date[0].Split('-')[1] + " / " + date[0].Split('-')[2];

                AddRecord(id, value, description, createdDate, modifiedDate);
            }

            connection.Close();
        }

        internal void AddRecord(string id, string value, string description, string created, string modified)
        {
            TableRecord.Add(new tableFT
            {
                ID = id,
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

        #region Hidden Scroll

        private void HiddenScroll()
        {
            tableBodyFLP.AutoScroll = false;
            tableBodyFLP.VerticalScroll.Visible = false;
            tableBodyFLP.VerticalScroll.Enabled = false;
            tableBodyFLP.VerticalScroll.Maximum = 0;
            tableBodyFLP.AutoScroll = true;
        }

        #endregion Hidden Scroll

        private void FinanceTracker_Load(object sender, EventArgs e)
        {
            TableRecord.Clear();
            GetData();
            GenerateDynamicRecords();
            HiddenScroll();
        }
    }
}