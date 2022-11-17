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
            this.sectionButton = new Polaris.Components.RoundedButton();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.embedPanel = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new Polaris.Components.RoundedPanel();
            this.NotesView = new Polaris.Components.RoundedPanel();
            this.ActivitiesView = new Polaris.Components.RoundedPanel();
            this.GradesView = new Polaris.Components.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.NotesView.SuspendLayout();
            this.ActivitiesView.SuspendLayout();
            this.GradesView.SuspendLayout();
            this.SuspendLayout();
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
            this.sectionButton.Location = new System.Drawing.Point(566, 28);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(200, 48);
            this.sectionButton.TabIndex = 12;
            this.sectionButton.Text = "New Record";
            this.sectionButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.sectionButton.UseVisualStyleBackColor = false;
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
            this.embedPanel.Size = new System.Drawing.Size(728, 442);
            this.embedPanel.TabIndex = 16;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.GradesView);
            this.roundedPanel1.Controls.Add(this.ActivitiesView);
            this.roundedPanel1.Controls.Add(this.NotesView);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.GradientAngle = 90F;
            this.roundedPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.roundedPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.roundedPanel1.Location = new System.Drawing.Point(109, 28);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(440, 48);
            this.roundedPanel1.TabIndex = 18;
            // 
            // NotesView
            // 
            this.NotesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.NotesView.BorderRadius = 15;
            this.NotesView.Controls.Add(this.label1);
            this.NotesView.ForeColor = System.Drawing.Color.Black;
            this.NotesView.GradientAngle = 90F;
            this.NotesView.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.NotesView.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.NotesView.Location = new System.Drawing.Point(4, 2);
            this.NotesView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotesView.Name = "NotesView";
            this.NotesView.Padding = new System.Windows.Forms.Padding(8);
            this.NotesView.Size = new System.Drawing.Size(140, 44);
            this.NotesView.TabIndex = 1;
            // 
            // ActivitiesView
            // 
            this.ActivitiesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivitiesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ActivitiesView.BorderRadius = 15;
            this.ActivitiesView.Controls.Add(this.label2);
            this.ActivitiesView.ForeColor = System.Drawing.Color.Black;
            this.ActivitiesView.GradientAngle = 90F;
            this.ActivitiesView.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ActivitiesView.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ActivitiesView.Location = new System.Drawing.Point(150, 2);
            this.ActivitiesView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivitiesView.Name = "ActivitiesView";
            this.ActivitiesView.Padding = new System.Windows.Forms.Padding(8);
            this.ActivitiesView.Size = new System.Drawing.Size(140, 44);
            this.ActivitiesView.TabIndex = 2;
            // 
            // GradesView
            // 
            this.GradesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.GradesView.BorderRadius = 15;
            this.GradesView.Controls.Add(this.label3);
            this.GradesView.ForeColor = System.Drawing.Color.Black;
            this.GradesView.GradientAngle = 90F;
            this.GradesView.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.GradesView.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.GradesView.Location = new System.Drawing.Point(296, 2);
            this.GradesView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GradesView.Name = "GradesView";
            this.GradesView.Padding = new System.Windows.Forms.Padding(8);
            this.GradesView.Size = new System.Drawing.Size(140, 44);
            this.GradesView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notes View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activities View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grades View";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(804, 551);
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
            this.NotesView.ResumeLayout(false);
            this.NotesView.PerformLayout();
            this.ActivitiesView.ResumeLayout(false);
            this.ActivitiesView.PerformLayout();
            this.GradesView.ResumeLayout(false);
            this.GradesView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Components.RoundedButton sectionButton;
        public System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Panel embedPanel;
        private Components.RoundedPanel roundedPanel1;
        private Components.RoundedPanel NotesView;
        private Components.RoundedPanel GradesView;
        private Components.RoundedPanel ActivitiesView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}