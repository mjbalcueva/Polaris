using Polaris.Components;
using Polaris.Forms.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polaris.Forms.Subjects
{
    public partial class tableNV : UserControl
    {
        public tableNV()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _id;
        private string _value = "0";
        private string _description = "Description";
        private string _createdDate = "Created Date";
        private string _modifiedDate = "Modified Date";
        private Color _color = ColorTranslator.FromHtml("#141519");

        [Category("Record Property")]
        public string ID
        {
            get { return _id; }
            set { _id = value; idLabel.Text = value; }
        }
        
        [Category("Record Property")]
        public string NoteTitle
        {
            get { return _value; }
            set { _value = value; TitleLabel.Text = value; }
        }

        [Category("Record Property")]
        public string NoteDesc
        {
            get { return _description; }
            set { _description = value; DescriptionLabel.Text = value; }
        }

        [Category("Record Property")]
        public string[] Tags { get; set; }

        [Category("Record Property")]
        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; CreatedLabel.Text = value; }
        }

        [Category("Record Property")]
        public string ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; ModifiedLabel.Text = value; }
        }

        [Category("Record Property")]
        public Color Color
        {
            get { return _color; }
            set { _color = value; background.BackColor = value; }
        }

        #endregion Getter, Setter & Constructor

        #region Events

        private void editButton_Click(object sender, EventArgs e)
        {
            NVInput nvinput = new NVInput();
            nvinput.titleLabel.Text = NoteTitle;
            nvinput.descriptionLabel.Text = NoteDesc;
            nvinput.editing = true;
            nvinput.recordID = ID;
            nvinput.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            NotesView notes = (NotesView)ParentForm;
            RemoveNoteFromDB();
            notes.TableRecord.Remove(this);
            notes.GenerateDynamicRecords();
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            background.BackColor = ColorTranslator.FromHtml("#1E2125");
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            background.BackColor = Color;
        }

        #endregion Events

        #region DB Functions

        private void RemoveNoteFromDB()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("DELETE FROM note WHERE id = " + ID, connection);
            cmd.ExecuteNonQuery();
            cmd = new OdbcCommand("DELETE FROM note_tags WHERE task_id = " + ID, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        private static readonly ArrayList tags = new ArrayList();
        public ArrayList TableTags { get; set; } = tags;
    
        private void LoadTags()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM note_tags WHERE note_id = " + ID, connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Tag tag = new Tag()
                {
                    TagName = dataReader.GetString(1),
                    TagID = dataReader.GetString(2),
                };
                TableTags.Add(tag);
            }
            connection.Close();
        }

        private void GenerateDynamicTags()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < TableTags.Count; i++)
            {
                Tag tag = (Tag)TableTags[i];
                if (tag.TagID == ID)
                {
                    flowLayoutPanel1.Controls.Add(tag);
                }
            }
        }

        #endregion DB Functions

        #region Hidden Scroll

        private void HiddenScroll()
        {
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
            flowLayoutPanel1.VerticalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = true;
        }

        #endregion Hidden Scroll

        private void tableNV_Load(object sender, EventArgs e)
        {
            LoadTags();
            GenerateDynamicTags();
            HiddenScroll();
        }
    }
}
