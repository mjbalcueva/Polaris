using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris.Forms.Subjects
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        #region Open Form

        private Form activeForm = null;

        public void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, embedPanel, new object[] { true });

            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            embedPanel.Controls.Add(childForm);
            embedPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Open Form

        #region Events

        private void NotesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Notes Section";
            ToggleActiveButton(NotesView);
            OpenChildForm(new NotesView());
        }

        private void ActivitiesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Activities Section";
            ToggleActiveButton(ActivitiesView);
            OpenChildForm(new ActivitiesView());
        }

        private void GradesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Grades Section";
            ToggleActiveButton(GradesView);
            OpenChildForm(new GradesView());
        }

        #endregion Events

        private IconButton activeBtn = null;

        private void ToggleActiveButton(IconButton button)
        {
            if (activeBtn != null)
            {
                activeBtn.BackColor = ColorTranslator.FromHtml("#090A0B");
                activeBtn.ForeColor = ColorTranslator.FromHtml("#6A6A73");
            }
            activeBtn = button;
            activeBtn.BackColor = ColorTranslator.FromHtml("#414149");
            activeBtn.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            OpenChildForm(new NotesView());
            sectionLabel.Text = "Notes Section";
            ToggleActiveButton(NotesView);
        }
    }
}