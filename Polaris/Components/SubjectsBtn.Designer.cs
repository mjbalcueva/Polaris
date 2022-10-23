namespace Polaris
{
    partial class SubjectsBtn
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
            this.subjectButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // subjectButton
            // 
            this.subjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.subjectButton.FlatAppearance.BorderSize = 0;
            this.subjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectButton.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.subjectButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.subjectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subjectButton.IconSize = 25;
            this.subjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectButton.Location = new System.Drawing.Point(0, 0);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.subjectButton.Size = new System.Drawing.Size(264, 44);
            this.subjectButton.TabIndex = 0;
            this.subjectButton.Text = "subjectButton";
            this.subjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subjectButton.UseVisualStyleBackColor = false;
            // 
            // SubjectsBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subjectButton);
            this.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "SubjectsBtn";
            this.Size = new System.Drawing.Size(264, 44);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton subjectButton;
    }
}
