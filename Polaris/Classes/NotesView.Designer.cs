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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.TablesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(864, 60);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 60);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(864, 60);
            this.FilterPanel.TabIndex = 1;
            // 
            // TablesPanel
            // 
            this.TablesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.TablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesPanel.Location = new System.Drawing.Point(0, 120);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Size = new System.Drawing.Size(864, 406);
            this.TablesPanel.TabIndex = 2;
            // 
            // NotesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.TablesPanel);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.MenuPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotesView";
            this.Text = "NotesView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel TablesPanel;
    }
}