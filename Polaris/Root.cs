﻿using Polaris.Components;
using Polaris.Forms.Misc;
using System;
using System.Collections;
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

            activeForm?.Close();
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

        #region Toggle Active Button Font & Icon Color

        private void TasksMenu_Enter(object sender, EventArgs e)
        {
            All.taskMenuItem.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
            All.taskMenuItem.IconColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        private void TasksMenu_Leave(object sender, EventArgs e)
        {
            All.taskMenuItem.ForeColor = ColorTranslator.FromHtml("#6A6A73");
            All.taskMenuItem.IconColor = ColorTranslator.FromHtml("#6A6A73");
        }

        #endregion Toggle Active Button Font & Icon Color

        #region ButtonClick Events

        private void LogoButton_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = "Overview";
            OpenChildForm(new Overview());
        }

        private void toggleSidebarButton_Click(object sender, EventArgs e)
        {
            sidebarPanel.Visible = !sidebarPanel.Visible;
        }

        #endregion ButtonClick Events

        #region Colors

        private readonly string[] randColors = { "#E7E250", "#FF4D4D", "#AF70EB", "#22c55e", "#0ea5e9", "#F1904B" };

        private int[] RandomArray(int length)
        {
            int[] arr = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(0, length);
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] != arr[j])
                        continue;
                    i--;
                    break;
                }
            }
            return arr;
        }

        #endregion Colors

        // sample data

        private string[] subjectItems = { "SDF 104", "CC 104", "CC 105" };
        private ArrayList subjectMenu = new ArrayList();

        public string[] SubjectItems { get => subjectItems; set => subjectItems = value; }
        public ArrayList SubjectMenu { get => subjectMenu; set => subjectMenu = value; }

        #region Dynamic Subjects

        private void FillSubjectMenu()
        {
            int[] randomColors = RandomArray(randColors.Length);

            for (int i = 0; i < SubjectItems.Length; i++)
                SubjectMenu.Add(new SubjectMenu
                {
                    ButtonText = "  " + SubjectItems[i],
                    IconColor = ColorTranslator.FromHtml(randColors[randomColors[i]])
                });
        }

        public void GenerateDynamicSubjects()
        {
            subjectsFLP.Controls.Clear();
            int subjectsCount = SubjectMenu.Count;

            if (subjectsCount == 0)
                subjectsFLP.Height = 0;
            else
                for (int i = 0; i < subjectsCount; i++)
                {
                    subjectsFLP.Controls.Add((SubjectMenu)SubjectMenu[i]);
                    subjectsFLP.Height = (((SubjectMenu)SubjectMenu[i]).Height + 6) * subjectsCount;
                }
        }

        #endregion Dynamic Subjects

        #region Hidden Scroll

        private void HiddenScroll()
        {
            sidebarPanel.AutoScroll = false;
            sidebarPanel.VerticalScroll.Visible = false;
            sidebarPanel.VerticalScroll.Enabled = false;
            sidebarPanel.VerticalScroll.Maximum = 0;
            sidebarPanel.AutoScroll = true;
        }

        #endregion Hidden Scroll

        private void Root_Load(object sender, EventArgs e)
        {
            CustomWindow(ColorTranslator.FromHtml("#090a0b"), ColorTranslator.FromHtml("#fdfdff"), ColorTranslator.FromHtml("#27282f"), Handle);
            OpenChildForm(new Overview());
            FillSubjectMenu();
            GenerateDynamicSubjects();
            HiddenScroll();
        }
    }
}