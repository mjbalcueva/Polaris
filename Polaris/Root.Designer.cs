namespace Polaris
{
    partial class Root
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TasksBtn = new FontAwesome.Sharp.IconButton();
            this.AllBtn = new FontAwesome.Sharp.IconButton();
            this.DraftsBtn = new FontAwesome.Sharp.IconButton();
            this.ArchivesBtn = new FontAwesome.Sharp.IconButton();
            this.DeletedBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.LogoBtn = new FontAwesome.Sharp.IconButton();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LabelText = new System.Windows.Forms.Label();
            this.TogglePanelBtn = new FontAwesome.Sharp.IconButton();
            this.EmbedPanel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.SidePanel.Controls.Add(this.tableLayoutPanel1);
            this.SidePanel.Controls.Add(this.LogoBtn);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(300, 653);
            this.SidePanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TasksBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AllBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DraftsBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ArchivesBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DeletedBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.iconButton6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconButton7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.iconButton8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.iconButton9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.iconButton10, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 280);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TasksBtn
            // 
            this.TasksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksBtn.FlatAppearance.BorderSize = 0;
            this.TasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TasksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TasksBtn.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.TasksBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TasksBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TasksBtn.IconSize = 35;
            this.TasksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.Location = new System.Drawing.Point(18, 18);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Size = new System.Drawing.Size(210, 44);
            this.TasksBtn.TabIndex = 0;
            this.TasksBtn.Text = "  Tasks";
            this.TasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // AllBtn
            // 
            this.AllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllBtn.FlatAppearance.BorderSize = 0;
            this.AllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.AllBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.AllBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.AllBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AllBtn.IconSize = 25;
            this.AllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllBtn.Location = new System.Drawing.Point(18, 68);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.AllBtn.Size = new System.Drawing.Size(210, 44);
            this.AllBtn.TabIndex = 1;
            this.AllBtn.Text = "  All";
            this.AllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AllBtn.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // DraftsBtn
            // 
            this.DraftsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DraftsBtn.FlatAppearance.BorderSize = 0;
            this.DraftsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftsBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DraftsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DraftsBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.DraftsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DraftsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DraftsBtn.IconSize = 25;
            this.DraftsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DraftsBtn.Location = new System.Drawing.Point(18, 118);
            this.DraftsBtn.Name = "DraftsBtn";
            this.DraftsBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DraftsBtn.Size = new System.Drawing.Size(210, 44);
            this.DraftsBtn.TabIndex = 2;
            this.DraftsBtn.Text = "  Drafts";
            this.DraftsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DraftsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DraftsBtn.Click += new System.EventHandler(this.DraftsBtn_Click);
            // 
            // ArchivesBtn
            // 
            this.ArchivesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivesBtn.FlatAppearance.BorderSize = 0;
            this.ArchivesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchivesBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ArchivesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ArchivesBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.ArchivesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ArchivesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArchivesBtn.IconSize = 25;
            this.ArchivesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArchivesBtn.Location = new System.Drawing.Point(18, 168);
            this.ArchivesBtn.Name = "ArchivesBtn";
            this.ArchivesBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ArchivesBtn.Size = new System.Drawing.Size(210, 44);
            this.ArchivesBtn.TabIndex = 3;
            this.ArchivesBtn.Text = "  Archived";
            this.ArchivesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArchivesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArchivesBtn.Click += new System.EventHandler(this.ArchivesBtn_Click);
            // 
            // DeletedBtn
            // 
            this.DeletedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletedBtn.FlatAppearance.BorderSize = 0;
            this.DeletedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletedBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DeletedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DeletedBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.DeletedBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DeletedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeletedBtn.IconSize = 25;
            this.DeletedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletedBtn.Location = new System.Drawing.Point(18, 218);
            this.DeletedBtn.Name = "DeletedBtn";
            this.DeletedBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DeletedBtn.Size = new System.Drawing.Size(210, 44);
            this.DeletedBtn.TabIndex = 4;
            this.DeletedBtn.Text = "  Deleted";
            this.DeletedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeletedBtn.Click += new System.EventHandler(this.DeletedBtn_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 25;
            this.iconButton6.Location = new System.Drawing.Point(234, 18);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(48, 44);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(234, 68);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(48, 44);
            this.iconButton7.TabIndex = 6;
            this.iconButton7.Text = "0";
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(234, 118);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(48, 44);
            this.iconButton8.TabIndex = 7;
            this.iconButton8.Text = "0";
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.iconButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.Location = new System.Drawing.Point(234, 168);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(48, 44);
            this.iconButton9.TabIndex = 8;
            this.iconButton9.Text = "0";
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.iconButton10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton10.IconColor = System.Drawing.Color.Black;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.Location = new System.Drawing.Point(234, 218);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(48, 44);
            this.iconButton10.TabIndex = 9;
            this.iconButton10.Text = "0";
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // LogoBtn
            // 
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Nobile Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LogoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LogoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LogoBtn.IconColor = System.Drawing.Color.Black;
            this.LogoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.LogoBtn.Size = new System.Drawing.Size(300, 100);
            this.LogoBtn.TabIndex = 0;
            this.LogoBtn.Text = "Polaris";
            this.LogoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoBtn.UseVisualStyleBackColor = true;
            this.LogoBtn.Click += new System.EventHandler(this.LogoBtn_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.TitlePanel.Controls.Add(this.LabelText);
            this.TitlePanel.Controls.Add(this.TogglePanelBtn);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(300, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(882, 80);
            this.TitlePanel.TabIndex = 1;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Nobile Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LabelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LabelText.Location = new System.Drawing.Point(85, 30);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(103, 23);
            this.LabelText.TabIndex = 1;
            this.LabelText.Text = "Overview";
            // 
            // TogglePanelBtn
            // 
            this.TogglePanelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.TogglePanelBtn.FlatAppearance.BorderSize = 0;
            this.TogglePanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TogglePanelBtn.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.TogglePanelBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TogglePanelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TogglePanelBtn.IconSize = 40;
            this.TogglePanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TogglePanelBtn.Location = new System.Drawing.Point(0, 0);
            this.TogglePanelBtn.Name = "TogglePanelBtn";
            this.TogglePanelBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.TogglePanelBtn.Size = new System.Drawing.Size(80, 80);
            this.TogglePanelBtn.TabIndex = 0;
            this.TogglePanelBtn.UseVisualStyleBackColor = true;
            this.TogglePanelBtn.Click += new System.EventHandler(this.TogglePanelBtn_Click);
            // 
            // EmbedPanel
            // 
            this.EmbedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.EmbedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmbedPanel.Location = new System.Drawing.Point(300, 80);
            this.EmbedPanel.Name = "EmbedPanel";
            this.EmbedPanel.Size = new System.Drawing.Size(882, 573);
            this.EmbedPanel.TabIndex = 2;
            this.EmbedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EmbedPanel_Paint);
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.EmbedPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Root";
            this.ShowIcon = false;
            this.Text = "Polaris";
            this.SidePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel EmbedPanel;
        private FontAwesome.Sharp.IconButton TogglePanelBtn;
        private System.Windows.Forms.Label LabelText;
        private FontAwesome.Sharp.IconButton LogoBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton TasksBtn;
        private FontAwesome.Sharp.IconButton AllBtn;
        private FontAwesome.Sharp.IconButton DraftsBtn;
        private FontAwesome.Sharp.IconButton ArchivesBtn;
        private FontAwesome.Sharp.IconButton DeletedBtn;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton10;
    }
}

