namespace Polaris.Forms.Subjects
{
    partial class Subjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sectionLabel = new System.Windows.Forms.Label();
            this.embedPanel = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new Polaris.Components.RoundedPanel();
            this.GradesView = new Polaris.Components.RoundedButton();
            this.ActivitiesView = new Polaris.Components.RoundedButton();
            this.NotesView = new Polaris.Components.RoundedButton();
            this.sectionButton = new Polaris.Components.RoundedButton();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sectionLabel.Location = new System.Drawing.Point(35, 28);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(157, 36);
            this.sectionLabel.TabIndex = 11;
            this.sectionLabel.Text = "sectionLabel";
            // 
            // embedPanel
            // 
            this.embedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embedPanel.Location = new System.Drawing.Point(38, 97);
            this.embedPanel.Name = "embedPanel";
            this.embedPanel.Size = new System.Drawing.Size(1138, 617);
            this.embedPanel.TabIndex = 16;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.AutoSize = true;
            this.roundedPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.GradesView);
            this.roundedPanel1.Controls.Add(this.ActivitiesView);
            this.roundedPanel1.Controls.Add(this.NotesView);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.GradientAngle = 90F;
            this.roundedPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.roundedPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.roundedPanel1.Location = new System.Drawing.Point(590, 28);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.roundedPanel1.Size = new System.Drawing.Size(380, 48);
            this.roundedPanel1.TabIndex = 18;
            // 
            // GradesView
            // 
            this.GradesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.GradesView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.GradesView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GradesView.BorderRadius = 15;
            this.GradesView.BorderSize = 0;
            this.GradesView.FlatAppearance.BorderSize = 0;
            this.GradesView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.GradesView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.GradesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradesView.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GradesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.GradesView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.GradesView.IconColor = System.Drawing.Color.Black;
            this.GradesView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GradesView.Location = new System.Drawing.Point(256, 5);
            this.GradesView.Name = "GradesView";
            this.GradesView.Size = new System.Drawing.Size(120, 39);
            this.GradesView.TabIndex = 2;
            this.GradesView.Text = "Grades";
            this.GradesView.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.GradesView.UseVisualStyleBackColor = false;
            this.GradesView.Click += new System.EventHandler(this.GradesView_Click);
            // 
            // ActivitiesView
            // 
            this.ActivitiesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ActivitiesView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ActivitiesView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ActivitiesView.BorderRadius = 15;
            this.ActivitiesView.BorderSize = 0;
            this.ActivitiesView.FlatAppearance.BorderSize = 0;
            this.ActivitiesView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ActivitiesView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ActivitiesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivitiesView.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ActivitiesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ActivitiesView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ActivitiesView.IconColor = System.Drawing.Color.Black;
            this.ActivitiesView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActivitiesView.Location = new System.Drawing.Point(130, 5);
            this.ActivitiesView.Name = "ActivitiesView";
            this.ActivitiesView.Size = new System.Drawing.Size(120, 39);
            this.ActivitiesView.TabIndex = 1;
            this.ActivitiesView.Text = "Activities";
            this.ActivitiesView.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ActivitiesView.UseVisualStyleBackColor = false;
            this.ActivitiesView.Click += new System.EventHandler(this.ActivitiesView_Click);
            // 
            // NotesView
            // 
            this.NotesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.NotesView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.NotesView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.NotesView.BorderRadius = 15;
            this.NotesView.BorderSize = 0;
            this.NotesView.FlatAppearance.BorderSize = 0;
            this.NotesView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.NotesView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.NotesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotesView.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.NotesView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.NotesView.IconColor = System.Drawing.Color.Black;
            this.NotesView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NotesView.Location = new System.Drawing.Point(4, 5);
            this.NotesView.Name = "NotesView";
            this.NotesView.Size = new System.Drawing.Size(120, 39);
            this.NotesView.TabIndex = 0;
            this.NotesView.Text = "Notes";
            this.NotesView.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.NotesView.UseVisualStyleBackColor = false;
            this.NotesView.Click += new System.EventHandler(this.NotesView_Click);
            // 
            // sectionButton
            // 
            this.sectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(94)))), ((int)(((byte)(216)))));
            this.sectionButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(94)))), ((int)(((byte)(216)))));
            this.sectionButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.sectionButton.BorderRadius = 15;
            this.sectionButton.BorderSize = 0;
            this.sectionButton.FlatAppearance.BorderSize = 0;
            this.sectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.sectionButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sectionButton.IconColor = System.Drawing.Color.Black;
            this.sectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sectionButton.Location = new System.Drawing.Point(976, 28);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(200, 48);
            this.sectionButton.TabIndex = 12;
            this.sectionButton.Text = "sectionButton";
            this.sectionButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.sectionButton.UseVisualStyleBackColor = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1214, 726);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.embedPanel);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.sectionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Components.RoundedButton sectionButton;
        public System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Panel embedPanel;
        private Components.RoundedPanel roundedPanel1;
        private Components.RoundedButton GradesView;
        private Components.RoundedButton ActivitiesView;
        private Components.RoundedButton NotesView;
    }
}