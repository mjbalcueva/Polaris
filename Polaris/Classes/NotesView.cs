using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris.Classes
{
    public partial class NotesView : Form
    {
        public NotesView()
        {
            InitializeComponent();
        }

        #region CustomStyles

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            AddBorder(e);
        }

        private static void AddBorder(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }

        #endregion CustomStyles

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, FieldsPanel, new object[] { true });

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FieldsPanel.Controls.Add(childForm);
            FieldsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNewNote_Click(object sender, System.EventArgs e)
        {
            NewNote note = new NewNote();
            note.Show();
        }

        private void btnActivitesView_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new Classes.ActivitiesView());
        }

        private void btnGradesView_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new Classes.GradesView());
        }

    }
}