using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polaris.Classes
{
    public partial class ActivitiesView : Form
    {
        public ActivitiesView()
        {
            InitializeComponent();
        }
        
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

        private void btnNewAct_Click(object sender, EventArgs e)
        {
            NewActivity act = new NewActivity();
            act.Show();
        }

        private void btnNotesViewA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Classes.NotesView());
        }

        private void btnGradesViewA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Classes.GradesView());
        }
    }
}
