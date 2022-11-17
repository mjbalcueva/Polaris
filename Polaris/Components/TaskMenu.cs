using Polaris.Forms.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Components
{
    public partial class TaskMenu : UserControl
    {
        public TaskMenu()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _btnText;
        private Color _btnForeColor;
        private Color _iconColor;
        private string _badgeText;

        [Category("Task Property")]
        public string ButtonText
        {
            get { return _btnText; }
            set { _btnText = value; taskMenuItem.Text = value; }
        }

        [Category("Task Property")]
        public Color ButtonForeColor
        {
            get { return _btnForeColor; }
            set { _btnForeColor = value; taskMenuItem.ForeColor = value; }
        }

        [Category("Task Property")]
        public Color IconColor
        {
            get { return _iconColor; }
            set { _iconColor = value; taskMenuItem.IconColor = value; }
        }

        [Category("Task Property")]
        public string BadgeText
        {
            get { return _badgeText; }
            set { _badgeText = value; badge.Text = value; }
        }

        #endregion Getter, Setter & Constructor

        #region Button Click Events

        private void taskMenuItem_Click(object sender, System.EventArgs e)
        {
            Root root = (Root)ParentForm;
            root.MenuLabel.Text = "Tasks";
            Tasks tasks = new Tasks();

            switch (taskMenuItem.Text)
            {
                case "  All":
                    tasks.sectionLabel.Text = "All Section";
                    tasks.sectionButton.Text = "New Tasks";
                    break;

                case "  Drafts":
                    tasks.sectionLabel.Text = "Drafts Section";
                    tasks.sectionButton.Text = "Clear Drafts";
                    tasks.sectionButton.BackColor = Color.FromArgb(189, 21, 67);
                    break;

                case "  Archived":
                    tasks.sectionLabel.Text = "Archives Section";
                    tasks.sectionButton.Text = "Clear Archives";
                    tasks.sectionButton.BackColor = Color.FromArgb(189, 21, 67);
                    break;

                case "  Deleted":
                    tasks.sectionLabel.Text = "Deleted Section";
                    tasks.sectionButton.Text = "Clear Deletes";
                    tasks.sectionButton.BackColor = Color.FromArgb(189, 21, 67);
                    break;
            }

            root.OpenChildForm(tasks);
        }

        private void taskMenuItem_Enter(object sender, System.EventArgs e)
        {
            taskMenuItem.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
            taskMenuItem.IconColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        private void taskMenuItem_Leave(object sender, System.EventArgs e)
        {
            taskMenuItem.ForeColor = ColorTranslator.FromHtml("#6A6A73");
            taskMenuItem.IconColor = ColorTranslator.FromHtml("#6A6A73");
        }

        #endregion Button Click Events
    }
}