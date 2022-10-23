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
            this.mainHeaderPanel = new System.Windows.Forms.Panel();
            this.mainEmbedPanel = new System.Windows.Forms.Panel();
            this.border1 = new System.Windows.Forms.Panel();
            this.mainHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(300, 673);
            this.sidebarPanel.TabIndex = 1;
            // 
            // mainHeaderPanel
            // 
            this.mainHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.mainHeaderPanel.Controls.Add(this.border1);
            this.mainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeaderPanel.Location = new System.Drawing.Point(300, 0);
            this.mainHeaderPanel.Name = "mainHeaderPanel";
            this.mainHeaderPanel.Size = new System.Drawing.Size(962, 100);
            this.mainHeaderPanel.TabIndex = 3;
            // 
            // mainEmbedPanel
            // 
            this.mainEmbedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.mainEmbedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEmbedPanel.Location = new System.Drawing.Point(300, 100);
            this.mainEmbedPanel.Name = "mainEmbedPanel";
            this.mainEmbedPanel.Size = new System.Drawing.Size(962, 573);
            this.mainEmbedPanel.TabIndex = 4;
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border1.Location = new System.Drawing.Point(0, 98);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(962, 2);
            this.border1.TabIndex = 0;
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.mainEmbedPanel);
            this.Controls.Add(this.mainHeaderPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Nobile", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Root";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Root";
            this.mainHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainHeaderPanel;
        private System.Windows.Forms.Panel border1;
        private System.Windows.Forms.Panel mainEmbedPanel;
    }
}