namespace Polaris
{
    partial class Archive_Tasks
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
            this.ArchiveTasksPanel = new System.Windows.Forms.Panel();
            this.ViewHeader = new System.Windows.Forms.Panel();
            this.ArchiveTasksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchiveTasksPanel
            // 
            this.ArchiveTasksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ArchiveTasksPanel.Controls.Add(this.ViewHeader);
            this.ArchiveTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchiveTasksPanel.Location = new System.Drawing.Point(0, 0);
            this.ArchiveTasksPanel.Name = "ArchiveTasksPanel";
            this.ArchiveTasksPanel.Size = new System.Drawing.Size(864, 526);
            this.ArchiveTasksPanel.TabIndex = 0;
            // 
            // ViewHeader
            // 
            this.ViewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewHeader.Location = new System.Drawing.Point(0, 0);
            this.ViewHeader.Name = "ViewHeader";
            this.ViewHeader.Size = new System.Drawing.Size(864, 60);
            this.ViewHeader.TabIndex = 0;
            this.ViewHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewHeader_Paint);
            // 
            // Archive_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.ArchiveTasksPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Archive_Tasks";
            this.Text = "Archives";
            this.ArchiveTasksPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ArchiveTasksPanel;
        private System.Windows.Forms.Panel ViewHeader;
    }
}