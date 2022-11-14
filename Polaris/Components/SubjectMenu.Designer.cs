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
            this.subjectMenuButton = new Polaris.Components.RoundedButton();
            this.SuspendLayout();
            // 
            // subjectMenuButton
            // 
            this.subjectMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.subjectMenuButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.subjectMenuButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.subjectMenuButton.BorderRadius = 15;
            this.subjectMenuButton.BorderSize = 0;
            this.subjectMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectMenuButton.FlatAppearance.BorderSize = 0;
            this.subjectMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.subjectMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.subjectMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectMenuButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.subjectMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectMenuButton.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.subjectMenuButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subjectMenuButton.IconSize = 30;
            this.subjectMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuButton.Location = new System.Drawing.Point(10, 0);
            this.subjectMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this.subjectMenuButton.Name = "subjectMenuButton";
            this.subjectMenuButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.subjectMenuButton.Size = new System.Drawing.Size(280, 50);
            this.subjectMenuButton.TabIndex = 0;
            this.subjectMenuButton.Text = "subjectMenuButton";
            this.subjectMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subjectMenuButton.UseVisualStyleBackColor = false;
            // 
            // SubjectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.subjectMenuButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Name = "SubjectMenu";
            this.Size = new System.Drawing.Size(300, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton subjectMenuButton;
    }
}
