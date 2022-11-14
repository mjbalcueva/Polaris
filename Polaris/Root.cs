using Polaris.Components;
using Polaris.Forms.Misc;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Polaris
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
            CustomWindow(ColorTranslator.FromHtml("#090a0b"), ColorTranslator.FromHtml("#fdfdff"), ColorTranslator.FromHtml("#27282f"), Handle);
            OpenChildForm(new Overview());
        }

        #region Change form color

        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        private const int DWWMA_CAPTION_COLOR = 35;
        private const int DWWMA_BORDER_COLOR = 34;
        private const int DWMWA_TEXT_COLOR = 36;

        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);
        }

        #endregion Change form color

        #region Open Form

        private Form activeForm = null;

        public void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, mainEmbedPanel, new object[] { true });

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainEmbedPanel.Controls.Add(childForm);
            mainEmbedPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Open Form

        private void LogoButton_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = "Overview";
            OpenChildForm(new Overview());
        }

        private void toggleSidebarButton_Click(object sender, EventArgs e)
        {
            sidebarPanel.Visible = !sidebarPanel.Visible;
        }

        #region Dynamic Subjects

        private readonly string[] subjectItems = { "SDF 104", "CC 104", "CC 105" };
        private readonly string[] randColors = { "#F5F17C", "#F25757", "#B699FE" };

        private void GenerateDynamicSubjects()
        {
            subjectsFLP.Controls.Clear();

            int subjectsCount = subjectItems.Length;
            SubjectMenu[] subjectsMenu = new SubjectMenu[subjectItems.Length];

            for (int i = 0; i < subjectsCount; i++)
            {
                subjectsMenu[i] = new SubjectMenu
                {
                    ButtonText = subjectItems[i],
                    IconColor = ColorTranslator.FromHtml(randColors[i])
                };

                subjectsFLP.Controls.Add(subjectsMenu[i]);
                subjectsFLP.Height = (subjectsMenu[i].Height + 6) * subjectsCount;
            }
        }

        #endregion Dynamic Subjects

        private void Root_Load(object sender, EventArgs e)
        {
            GenerateDynamicSubjects();
        }
    }
}