namespace Polaris.Components
{
    partial class TaskMenu
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
            this.taskMenuItem = new Polaris.Components.RoundedButton();
            this.badge = new Polaris.Components.RoundedButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // taskMenuItem
            // 
            this.taskMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.taskMenuItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.taskMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.taskMenuItem.BorderRadius = 15;
            this.taskMenuItem.BorderSize = 0;
            this.taskMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskMenuItem.FlatAppearance.BorderSize = 0;
            this.taskMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.taskMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.taskMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.taskMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.taskMenuItem.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.taskMenuItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.taskMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.taskMenuItem.IconSize = 30;
            this.taskMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskMenuItem.Location = new System.Drawing.Point(10, 0);
            this.taskMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.taskMenuItem.Name = "taskMenuItem";
            this.taskMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.taskMenuItem.Size = new System.Drawing.Size(280, 50);
            this.taskMenuItem.TabIndex = 1;
            this.taskMenuItem.Text = "taskMenuItem";
            this.taskMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskMenuItem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.taskMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.taskMenuItem.UseVisualStyleBackColor = false;
            this.taskMenuItem.Click += new System.EventHandler(this.taskMenuItem_Click);
            // 
            // badge
            // 
            this.badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.badge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(49)))));
            this.badge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.badge.BorderRadius = 35;
            this.badge.BorderSize = 0;
            this.badge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badge.FlatAppearance.BorderSize = 0;
            this.badge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.badge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.badge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.IconChar = FontAwesome.Sharp.IconChar.None;
            this.badge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.badge.IconSize = 30;
            this.badge.Location = new System.Drawing.Point(240, 8);
            this.badge.Margin = new System.Windows.Forms.Padding(0);
            this.badge.Name = "badge";
            this.badge.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.badge.Size = new System.Drawing.Size(35, 35);
            this.badge.TabIndex = 2;
            this.badge.Text = "99";
            this.badge.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.UseVisualStyleBackColor = false;
            // 
            // TaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.badge);
            this.Controls.Add(this.taskMenuItem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Name = "TaskMenu";
            this.Size = new System.Drawing.Size(300, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton taskMenuItem;
        private RoundedButton badge;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
