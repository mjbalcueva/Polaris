namespace Polaris
{
    partial class All_Tasks
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
            this.AllTasksPanel = new System.Windows.Forms.Panel();
            this.ViewHeader = new System.Windows.Forms.Panel();
            this.AllTasksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTasksPanel
            // 
            this.AllTasksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.AllTasksPanel.Controls.Add(this.ViewHeader);
            this.AllTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTasksPanel.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AllTasksPanel.Location = new System.Drawing.Point(0, 0);
            this.AllTasksPanel.Name = "AllTasksPanel";
            this.AllTasksPanel.Size = new System.Drawing.Size(864, 526);
            this.AllTasksPanel.TabIndex = 0;
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
            // All_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.AllTasksPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "All_Tasks";
            this.Text = "All";
            this.AllTasksPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AllTasksPanel;
        private System.Windows.Forms.Panel ViewHeader;
    }
}