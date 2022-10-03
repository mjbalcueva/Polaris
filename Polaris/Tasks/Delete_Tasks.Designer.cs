namespace Polaris
{
    partial class Delete_Tasks
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
            this.DeleteTasksPanel = new System.Windows.Forms.Panel();
            this.ViewHeader = new System.Windows.Forms.Panel();
            this.DeleteTasksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteTasksPanel
            // 
            this.DeleteTasksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.DeleteTasksPanel.Controls.Add(this.ViewHeader);
            this.DeleteTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteTasksPanel.Location = new System.Drawing.Point(0, 0);
            this.DeleteTasksPanel.Name = "DeleteTasksPanel";
            this.DeleteTasksPanel.Size = new System.Drawing.Size(864, 526);
            this.DeleteTasksPanel.TabIndex = 0;
            // 
            // ViewHeader
            // 
            this.ViewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewHeader.Location = new System.Drawing.Point(0, 0);
            this.ViewHeader.Name = "ViewHeader";
            this.ViewHeader.Size = new System.Drawing.Size(864, 60);
            this.ViewHeader.TabIndex = 0;
            this.ViewHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Delete_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.DeleteTasksPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Delete_Tasks";
            this.Text = "Deleted";
            this.DeleteTasksPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DeleteTasksPanel;
        private System.Windows.Forms.Panel ViewHeader;
    }
}