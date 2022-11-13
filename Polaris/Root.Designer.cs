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
            this.toggleSidebarButton = new FontAwesome.Sharp.IconButton();
            this.border1 = new System.Windows.Forms.Panel();
            this.mainEmbedPanel = new System.Windows.Forms.Panel();
            this.mainHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(300, 678);
            this.sidebarPanel.TabIndex = 1;
            // 
            // mainHeaderPanel
            // 
            this.mainHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.mainHeaderPanel.Controls.Add(this.toggleSidebarButton);
            this.mainHeaderPanel.Controls.Add(this.border1);
            this.mainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeaderPanel.Location = new System.Drawing.Point(300, 0);
            this.mainHeaderPanel.Name = "mainHeaderPanel";
            this.mainHeaderPanel.Size = new System.Drawing.Size(822, 94);
            this.mainHeaderPanel.TabIndex = 3;
            // 
            // toggleSidebarButton
            // 
            this.toggleSidebarButton.FlatAppearance.BorderSize = 0;
            this.toggleSidebarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.toggleSidebarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.toggleSidebarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleSidebarButton.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.toggleSidebarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.toggleSidebarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toggleSidebarButton.IconSize = 30;
            this.toggleSidebarButton.Location = new System.Drawing.Point(25, 25);
            this.toggleSidebarButton.Name = "toggleSidebarButton";
            this.toggleSidebarButton.Size = new System.Drawing.Size(44, 44);
            this.toggleSidebarButton.TabIndex = 1;
            this.toggleSidebarButton.UseVisualStyleBackColor = true;
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border1.Location = new System.Drawing.Point(0, 92);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(822, 2);
            this.border1.TabIndex = 0;
            // 
            // mainEmbedPanel
            // 
            this.mainEmbedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.mainEmbedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEmbedPanel.Location = new System.Drawing.Point(300, 94);
            this.mainEmbedPanel.Name = "mainEmbedPanel";
            this.mainEmbedPanel.Size = new System.Drawing.Size(822, 584);
            this.mainEmbedPanel.TabIndex = 4;
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
            this.MinimumSize = new System.Drawing.Size(1122, 678);
            this.Name = "Root";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris";
            this.mainHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainHeaderPanel;
        private System.Windows.Forms.Panel border1;
        private System.Windows.Forms.Panel mainEmbedPanel;
        private FontAwesome.Sharp.IconButton toggleSidebarButton;
    }
}