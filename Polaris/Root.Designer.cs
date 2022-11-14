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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.border3 = new System.Windows.Forms.Panel();
            this.placeholder = new System.Windows.Forms.Panel();
            this.placeholder1 = new System.Windows.Forms.Panel();
            this.border2 = new System.Windows.Forms.Panel();
            this.mainHeaderPanel = new System.Windows.Forms.Panel();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.border1 = new System.Windows.Forms.Panel();
            this.mainEmbedPanel = new System.Windows.Forms.Panel();
            this.toggleSidebarButton = new Polaris.Components.RoundedButton();
            this.Subjects = new Polaris.Components.SidebarMenu();
            this.Deleted = new Polaris.Components.TaskMenu();
            this.Archived = new Polaris.Components.TaskMenu();
            this.Drafts = new Polaris.Components.TaskMenu();
            this.All = new Polaris.Components.TaskMenu();
            this.Tasks = new Polaris.Components.SidebarMenu();
            this.LogoButton = new Polaris.Components.RoundedButton();
            this.sidebarPanel.SuspendLayout();
            this.mainHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarPanel.Controls.Add(this.Subjects);
            this.sidebarPanel.Controls.Add(this.panel1);
            this.sidebarPanel.Controls.Add(this.border3);
            this.sidebarPanel.Controls.Add(this.placeholder);
            this.sidebarPanel.Controls.Add(this.Deleted);
            this.sidebarPanel.Controls.Add(this.Archived);
            this.sidebarPanel.Controls.Add(this.Drafts);
            this.sidebarPanel.Controls.Add(this.All);
            this.sidebarPanel.Controls.Add(this.Tasks);
            this.sidebarPanel.Controls.Add(this.placeholder1);
            this.sidebarPanel.Controls.Add(this.border2);
            this.sidebarPanel.Controls.Add(this.LogoButton);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(300, 678);
            this.sidebarPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 10);
            this.panel1.TabIndex = 10;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border3.Dock = System.Windows.Forms.DockStyle.Top;
            this.border3.Location = new System.Drawing.Point(0, 403);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(300, 3);
            this.border3.TabIndex = 9;
            // 
            // placeholder
            // 
            this.placeholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeholder.Location = new System.Drawing.Point(0, 383);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(300, 20);
            this.placeholder.TabIndex = 8;
            // 
            // placeholder1
            // 
            this.placeholder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeholder1.Location = new System.Drawing.Point(0, 113);
            this.placeholder1.Name = "placeholder1";
            this.placeholder1.Size = new System.Drawing.Size(300, 10);
            this.placeholder1.TabIndex = 2;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border2.Dock = System.Windows.Forms.DockStyle.Top;
            this.border2.Location = new System.Drawing.Point(0, 110);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(300, 3);
            this.border2.TabIndex = 1;
            // 
            // mainHeaderPanel
            // 
            this.mainHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.mainHeaderPanel.Controls.Add(this.MenuLabel);
            this.mainHeaderPanel.Controls.Add(this.toggleSidebarButton);
            this.mainHeaderPanel.Controls.Add(this.border1);
            this.mainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeaderPanel.Location = new System.Drawing.Point(300, 0);
            this.mainHeaderPanel.Name = "mainHeaderPanel";
            this.mainHeaderPanel.Size = new System.Drawing.Size(822, 80);
            this.mainHeaderPanel.TabIndex = 3;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MenuLabel.Location = new System.Drawing.Point(81, 21);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(108, 31);
            this.MenuLabel.TabIndex = 3;
            this.MenuLabel.Text = "Overview";
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border1.Location = new System.Drawing.Point(0, 78);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(822, 2);
            this.border1.TabIndex = 0;
            // 
            // mainEmbedPanel
            // 
            this.mainEmbedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.mainEmbedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEmbedPanel.Location = new System.Drawing.Point(300, 80);
            this.mainEmbedPanel.Name = "mainEmbedPanel";
            this.mainEmbedPanel.Size = new System.Drawing.Size(822, 598);
            this.mainEmbedPanel.TabIndex = 4;
            // 
            // toggleSidebarButton
            // 
            this.toggleSidebarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.toggleSidebarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.toggleSidebarButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.toggleSidebarButton.BorderRadius = 15;
            this.toggleSidebarButton.BorderSize = 0;
            this.toggleSidebarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSidebarButton.FlatAppearance.BorderSize = 0;
            this.toggleSidebarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.toggleSidebarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.toggleSidebarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleSidebarButton.ForeColor = System.Drawing.Color.White;
            this.toggleSidebarButton.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.toggleSidebarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.toggleSidebarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toggleSidebarButton.IconSize = 30;
            this.toggleSidebarButton.Location = new System.Drawing.Point(25, 15);
            this.toggleSidebarButton.Name = "toggleSidebarButton";
            this.toggleSidebarButton.Padding = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.toggleSidebarButton.Size = new System.Drawing.Size(50, 50);
            this.toggleSidebarButton.TabIndex = 2;
            this.toggleSidebarButton.TextColor = System.Drawing.Color.White;
            this.toggleSidebarButton.UseVisualStyleBackColor = false;
            this.toggleSidebarButton.Click += new System.EventHandler(this.toggleSidebarButton_Click);
            // 
            // Subjects
            // 
            this.Subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Subjects.BadgeIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Subjects.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Subjects.ButtonText = "  Subjects";
            this.Subjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.Subjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Subjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Subjects.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.Subjects.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Subjects.Location = new System.Drawing.Point(0, 416);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(300, 60);
            this.Subjects.TabIndex = 11;
            // 
            // Deleted
            // 
            this.Deleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Deleted.BadgeText = "0";
            this.Deleted.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Deleted.ButtonText = "  Deleted";
            this.Deleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Deleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Deleted.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Deleted.Location = new System.Drawing.Point(0, 333);
            this.Deleted.Name = "Deleted";
            this.Deleted.Size = new System.Drawing.Size(300, 50);
            this.Deleted.TabIndex = 7;
            // 
            // Archived
            // 
            this.Archived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Archived.BadgeText = "0";
            this.Archived.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Archived.ButtonText = "  Archived";
            this.Archived.Dock = System.Windows.Forms.DockStyle.Top;
            this.Archived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Archived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Archived.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Archived.Location = new System.Drawing.Point(0, 283);
            this.Archived.Name = "Archived";
            this.Archived.Size = new System.Drawing.Size(300, 50);
            this.Archived.TabIndex = 6;
            // 
            // Drafts
            // 
            this.Drafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Drafts.BadgeText = "0";
            this.Drafts.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Drafts.ButtonText = "  Drafts";
            this.Drafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.Drafts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Drafts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Drafts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Drafts.Location = new System.Drawing.Point(0, 233);
            this.Drafts.Name = "Drafts";
            this.Drafts.Size = new System.Drawing.Size(300, 50);
            this.Drafts.TabIndex = 5;
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.All.BadgeText = "0";
            this.All.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.All.ButtonText = "  All";
            this.All.Dock = System.Windows.Forms.DockStyle.Top;
            this.All.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.All.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.All.Location = new System.Drawing.Point(0, 183);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(300, 50);
            this.All.TabIndex = 4;
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Tasks.BadgeIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Tasks.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Tasks.ButtonText = "  Tasks";
            this.Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Tasks.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.Tasks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Tasks.Location = new System.Drawing.Point(0, 123);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(300, 60);
            this.Tasks.TabIndex = 3;
            // 
            // LogoButton
            // 
            this.LogoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.LogoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.LogoButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LogoButton.BorderRadius = 0;
            this.LogoButton.BorderSize = 0;
            this.LogoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoButton.FlatAppearance.BorderSize = 0;
            this.LogoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.LogoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.LogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LogoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LogoButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LogoButton.IconColor = System.Drawing.Color.Black;
            this.LogoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoButton.Location = new System.Drawing.Point(0, 0);
            this.LogoButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LogoButton.Size = new System.Drawing.Size(300, 110);
            this.LogoButton.TabIndex = 0;
            this.LogoButton.Text = "Polaris";
            this.LogoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LogoButton.UseVisualStyleBackColor = false;
            this.LogoButton.Click += new System.EventHandler(this.LogoButton_Click);
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 678);
            this.Controls.Add(this.mainEmbedPanel);
            this.Controls.Add(this.mainHeaderPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1140, 725);
            this.Name = "Root";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris";
            this.sidebarPanel.ResumeLayout(false);
            this.mainHeaderPanel.ResumeLayout(false);
            this.mainHeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainHeaderPanel;
        private System.Windows.Forms.Panel border1;
        private System.Windows.Forms.Panel mainEmbedPanel;
        private Components.RoundedButton toggleSidebarButton;
        private System.Windows.Forms.Panel border2;
        private Components.RoundedButton LogoButton;
        private System.Windows.Forms.Panel placeholder1;
        private Components.SidebarMenu Tasks;
        private Components.TaskMenu All;
        private Components.TaskMenu Deleted;
        private Components.TaskMenu Archived;
        private Components.TaskMenu Drafts;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Panel placeholder;
        private Components.SidebarMenu Subjects;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label MenuLabel;
    }
}