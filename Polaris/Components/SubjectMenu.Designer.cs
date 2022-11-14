namespace Polaris.Components
{
    partial class SubjectMenu
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
            this.subjectMenuItem = new Polaris.Components.RoundedButton();
            this.SuspendLayout();
            // 
            // subjectMenuItem
            // 
            this.subjectMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.subjectMenuItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.subjectMenuItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.subjectMenuItem.BorderRadius = 15;
            this.subjectMenuItem.BorderSize = 0;
            this.subjectMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectMenuItem.FlatAppearance.BorderSize = 0;
            this.subjectMenuItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.subjectMenuItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.subjectMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.subjectMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectMenuItem.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.subjectMenuItem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subjectMenuItem.IconSize = 30;
            this.subjectMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuItem.Location = new System.Drawing.Point(10, 0);
            this.subjectMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.subjectMenuItem.Name = "subjectMenuItem";
            this.subjectMenuItem.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.subjectMenuItem.Size = new System.Drawing.Size(280, 50);
            this.subjectMenuItem.TabIndex = 0;
            this.subjectMenuItem.Text = "subjectMenuItem";
            this.subjectMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuItem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subjectMenuItem.UseVisualStyleBackColor = false;
            // 
            // SubjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.subjectMenuItem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Name = "SubjectMenu";
            this.Size = new System.Drawing.Size(300, 50);
            this.ResumeLayout(false);

        }

        #endregion

        public RoundedButton subjectMenuItem;
    }
}
