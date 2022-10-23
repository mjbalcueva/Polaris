namespace Polaris.Classes
{
    partial class NotesView
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
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnGradesView = new System.Windows.Forms.Button();
            this.btnActivitesView = new System.Windows.Forms.Button();
            this.btnNotesView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLastModified = new FontAwesome.Sharp.IconButton();
            this.btnDateCreated = new FontAwesome.Sharp.IconButton();
            this.btnTagsSort = new FontAwesome.Sharp.IconButton();
            this.btnDescriptionSort = new FontAwesome.Sharp.IconButton();
            this.btnTitleSort = new FontAwesome.Sharp.IconButton();
            this.FieldsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.btnAddFilter.FlatAppearance.BorderSize = 0;
            this.btnAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddFilter.Location = new System.Drawing.Point(19, 67);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(104, 37);
            this.btnAddFilter.TabIndex = 0;
            this.btnAddFilter.Text = "+ Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = false;
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.FieldsPanel.Controls.Add(this.btnNewNote);
            this.FieldsPanel.Controls.Add(this.btnGradesView);
            this.FieldsPanel.Controls.Add(this.btnActivitesView);
            this.FieldsPanel.Controls.Add(this.btnNotesView);
            this.FieldsPanel.Controls.Add(this.label1);
            this.FieldsPanel.Controls.Add(this.btnAddFilter);
            this.FieldsPanel.Controls.Add(this.panel1);
            this.FieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsPanel.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FieldsPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(864, 526);
            this.FieldsPanel.TabIndex = 2;
            // 
            // btnNewNote
            // 
            this.btnNewNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.btnNewNote.FlatAppearance.BorderSize = 0;
            this.btnNewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewNote.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNewNote.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewNote.Location = new System.Drawing.Point(723, 12);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(106, 35);
            this.btnNewNote.TabIndex = 9;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = false;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnGradesView
            // 
            this.btnGradesView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGradesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.btnGradesView.FlatAppearance.BorderSize = 0;
            this.btnGradesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradesView.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnGradesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.btnGradesView.Location = new System.Drawing.Point(572, 12);
            this.btnGradesView.Name = "btnGradesView";
            this.btnGradesView.Size = new System.Drawing.Size(104, 35);
            this.btnGradesView.TabIndex = 8;
            this.btnGradesView.Text = "Grades View";
            this.btnGradesView.UseVisualStyleBackColor = false;
            this.btnGradesView.Click += new System.EventHandler(this.btnGradesView_Click);
            // 
            // btnActivitesView
            // 
            this.btnActivitesView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivitesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.btnActivitesView.FlatAppearance.BorderSize = 0;
            this.btnActivitesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivitesView.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnActivitesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.btnActivitesView.Location = new System.Drawing.Point(436, 12);
            this.btnActivitesView.Name = "btnActivitesView";
            this.btnActivitesView.Size = new System.Drawing.Size(130, 35);
            this.btnActivitesView.TabIndex = 7;
            this.btnActivitesView.Text = "Activities View";
            this.btnActivitesView.UseVisualStyleBackColor = false;
            this.btnActivitesView.Click += new System.EventHandler(this.btnActivitesView_Click);
            // 
            // btnNotesView
            // 
            this.btnNotesView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.btnNotesView.FlatAppearance.BorderSize = 0;
            this.btnNotesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotesView.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNotesView.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNotesView.Location = new System.Drawing.Point(326, 12);
            this.btnNotesView.Name = "btnNotesView";
            this.btnNotesView.Size = new System.Drawing.Size(104, 35);
            this.btnNotesView.TabIndex = 6;
            this.btnNotesView.Text = "Notes View";
            this.btnNotesView.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Oxygen", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notes Section";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnLastModified);
            this.panel1.Controls.Add(this.btnDateCreated);
            this.panel1.Controls.Add(this.btnTagsSort);
            this.panel1.Controls.Add(this.btnDescriptionSort);
            this.panel1.Controls.Add(this.btnTitleSort);
            this.panel1.Location = new System.Drawing.Point(19, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnLastModified
            // 
            this.btnLastModified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastModified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnLastModified.FlatAppearance.BorderSize = 0;
            this.btnLastModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastModified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnLastModified.IconChar = FontAwesome.Sharp.IconChar.Unsorted;
            this.btnLastModified.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnLastModified.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLastModified.IconSize = 12;
            this.btnLastModified.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLastModified.Location = new System.Drawing.Point(659, 3);
            this.btnLastModified.Name = "btnLastModified";
            this.btnLastModified.Size = new System.Drawing.Size(135, 40);
            this.btnLastModified.TabIndex = 5;
            this.btnLastModified.Text = "Last Modified";
            this.btnLastModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLastModified.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLastModified.UseVisualStyleBackColor = false;
            // 
            // btnDateCreated
            // 
            this.btnDateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDateCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnDateCreated.FlatAppearance.BorderSize = 0;
            this.btnDateCreated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnDateCreated.IconChar = FontAwesome.Sharp.IconChar.Unsorted;
            this.btnDateCreated.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnDateCreated.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDateCreated.IconSize = 12;
            this.btnDateCreated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateCreated.Location = new System.Drawing.Point(521, 3);
            this.btnDateCreated.Name = "btnDateCreated";
            this.btnDateCreated.Size = new System.Drawing.Size(136, 40);
            this.btnDateCreated.TabIndex = 4;
            this.btnDateCreated.Text = "Date Created";
            this.btnDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDateCreated.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDateCreated.UseVisualStyleBackColor = false;
            // 
            // btnTagsSort
            // 
            this.btnTagsSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTagsSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnTagsSort.FlatAppearance.BorderSize = 0;
            this.btnTagsSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTagsSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnTagsSort.IconChar = FontAwesome.Sharp.IconChar.Unsorted;
            this.btnTagsSort.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnTagsSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTagsSort.IconSize = 12;
            this.btnTagsSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTagsSort.Location = new System.Drawing.Point(361, 3);
            this.btnTagsSort.Name = "btnTagsSort";
            this.btnTagsSort.Size = new System.Drawing.Size(83, 40);
            this.btnTagsSort.TabIndex = 3;
            this.btnTagsSort.Text = "Tags";
            this.btnTagsSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTagsSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTagsSort.UseVisualStyleBackColor = false;
            // 
            // btnDescriptionSort
            // 
            this.btnDescriptionSort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDescriptionSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnDescriptionSort.FlatAppearance.BorderSize = 0;
            this.btnDescriptionSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescriptionSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnDescriptionSort.IconChar = FontAwesome.Sharp.IconChar.Unsorted;
            this.btnDescriptionSort.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnDescriptionSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescriptionSort.IconSize = 12;
            this.btnDescriptionSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescriptionSort.Location = new System.Drawing.Point(184, 3);
            this.btnDescriptionSort.Name = "btnDescriptionSort";
            this.btnDescriptionSort.Size = new System.Drawing.Size(133, 40);
            this.btnDescriptionSort.TabIndex = 2;
            this.btnDescriptionSort.Text = "Description";
            this.btnDescriptionSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescriptionSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDescriptionSort.UseVisualStyleBackColor = false;
            // 
            // btnTitleSort
            // 
            this.btnTitleSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnTitleSort.FlatAppearance.BorderSize = 0;
            this.btnTitleSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnTitleSort.IconChar = FontAwesome.Sharp.IconChar.Unsorted;
            this.btnTitleSort.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnTitleSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTitleSort.IconSize = 12;
            this.btnTitleSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitleSort.Location = new System.Drawing.Point(38, 3);
            this.btnTitleSort.Name = "btnTitleSort";
            this.btnTitleSort.Size = new System.Drawing.Size(101, 40);
            this.btnTitleSort.TabIndex = 1;
            this.btnTitleSort.Text = "Title";
            this.btnTitleSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTitleSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTitleSort.UseVisualStyleBackColor = false;
            // 
            // NotesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.FieldsPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotesView";
            this.Text = "NotesView";
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FieldsPanel;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTitleSort;
        private FontAwesome.Sharp.IconButton btnDescriptionSort;
        private FontAwesome.Sharp.IconButton btnTagsSort;
        private FontAwesome.Sharp.IconButton btnLastModified;
        private FontAwesome.Sharp.IconButton btnDateCreated;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.Button btnGradesView;
        private System.Windows.Forms.Button btnActivitesView;
        private System.Windows.Forms.Button btnNotesView;
        private System.Windows.Forms.Label label1;
    }
}