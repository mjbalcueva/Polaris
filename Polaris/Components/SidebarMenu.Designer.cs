namespace Polaris.Components
{
    partial class SidebarMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.badge = new Polaris.Components.RoundedButton();
            this.sidebarMenuItem = new Polaris.Components.RoundedButton();
            this.SuspendLayout();
            // 
            // badge
            // 
            this.badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.badge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.badge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.badge.BorderRadius = 15;
            this.badge.BorderSize = 0;
            this.badge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badge.FlatAppearance.BorderSize = 0;
            this.badge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.badge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.badge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.badge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.badge.IconSize = 20;
            this.badge.Location = new System.Drawing.Point(240, 13);
            this.badge.Margin = new System.Windows.Forms.Padding(0);
            this.badge.Name = "badge";
            this.badge.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.badge.Size = new System.Drawing.Size(35, 35);
            this.badge.TabIndex = 4;
            this.badge.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.UseVisualStyleBackColor = false;
            // 
            // sidebarMenuItem
            // 
            this.sidebarMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarMenuItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarMenuItem.BorderRadius = 15;
            this.sidebarMenuItem.BorderSize = 0;
            this.sidebarMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebarMenuItem.FlatAppearance.BorderSize = 0;
            this.sidebarMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.sidebarMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.sidebarMenuItem.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.sidebarMenuItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.sidebarMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarMenuItem.IconSize = 30;
            this.sidebarMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarMenuItem.Location = new System.Drawing.Point(10, 0);
            this.sidebarMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarMenuItem.Name = "sidebarMenuItem";
            this.sidebarMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sidebarMenuItem.Size = new System.Drawing.Size(280, 60);
            this.sidebarMenuItem.TabIndex = 3;
            this.sidebarMenuItem.Text = "sidebarMenu";
            this.sidebarMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarMenuItem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.sidebarMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarMenuItem.UseVisualStyleBackColor = false;
            this.sidebarMenuItem.Click += new System.EventHandler(this.sidebarMenuItem_Click);
            // 
            // SidebarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.badge);
            this.Controls.Add(this.sidebarMenuItem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Name = "SidebarMenu";
            this.Size = new System.Drawing.Size(300, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public RoundedButton badge;
        public RoundedButton sidebarMenuItem;
    }
}
