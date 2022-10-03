using System;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        private void TogglePanelBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = !SidePanel.Visible;
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, EmbedPanel, new object[] { true });

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            EmbedPanel.Controls.Add(childForm);
            EmbedPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private FontAwesome.Sharp.IconButton activeIconButton = null;

        private void ToggleButtonFontColor(FontAwesome.Sharp.IconButton button)
        {
            if (activeIconButton != null)
            {
                activeIconButton.ForeColor = ColorTranslator.FromHtml("#6A6A73");
                activeIconButton.IconColor = ColorTranslator.FromHtml("#6A6A73");
            }
            activeIconButton = button;
            activeIconButton.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
            activeIconButton.IconColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        private void LogoBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Overview";
            OpenChildForm(new Overview());
            ToggleButtonFontColor(new FontAwesome.Sharp.IconButton());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Tasks";
            OpenChildForm(new All_Tasks());
            ToggleButtonFontColor(AllBtn);
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Tasks";
            OpenChildForm(new All_Tasks());
            ToggleButtonFontColor(AllBtn);
        }

        private void DraftsBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Tasks";
            OpenChildForm(new Drafts_Tasks());
            ToggleButtonFontColor(DraftsBtn);
        }

        private void ArchivesBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Tasks";
            OpenChildForm(new Archive_Tasks());
            ToggleButtonFontColor(ArchivesBtn);
        }

        private void DeletedBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Tasks";
            OpenChildForm(new Delete_Tasks());
            ToggleButtonFontColor(DeletedBtn);
        }
    }
}