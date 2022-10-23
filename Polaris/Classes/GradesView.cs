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
    public partial class GradesView : Form
    {
        public GradesView()
        {
            InitializeComponent();
        }
        
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, GradesPanel, new object[] { true });

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            GradesPanel.Controls.Add(childForm);
            GradesPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            btnDisabled.Click -= btnDisabled_Click;
        }

        private void btnNotesView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Classes.NotesView());
        }

        private void btnActivitesView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Classes.ActivitiesView());
        }
    }
}
