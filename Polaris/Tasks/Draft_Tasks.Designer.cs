namespace Polaris
{
    partial class Drafts_Tasks
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
            this.DraftsTasksPanel = new System.Windows.Forms.Panel();
            this.ViewHeader = new System.Windows.Forms.Panel();
            this.DraftsTasksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DraftsTasksPanel
            // 
            this.DraftsTasksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.DraftsTasksPanel.Controls.Add(this.ViewHeader);
            this.DraftsTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DraftsTasksPanel.Location = new System.Drawing.Point(0, 0);
            this.DraftsTasksPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DraftsTasksPanel.Name = "DraftsTasksPanel";
            this.DraftsTasksPanel.Size = new System.Drawing.Size(864, 526);
            this.DraftsTasksPanel.TabIndex = 0;
            // 
            // ViewHeader
            // 
            this.ViewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewHeader.Location = new System.Drawing.Point(0, 0);
            this.ViewHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ViewHeader.Name = "ViewHeader";
            this.ViewHeader.Size = new System.Drawing.Size(864, 60);
            this.ViewHeader.TabIndex = 0;
            this.ViewHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewHeader_Paint);
            // 
            // Drafts_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.DraftsTasksPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Drafts_Tasks";
            this.Text = "Drafts";
            this.DraftsTasksPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DraftsTasksPanel;
        private System.Windows.Forms.Panel ViewHeader;
    }
}