namespace Polaris.Components
{
    partial class Tag
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
            this.tagControl = new Polaris.Components.RoundedButton();
            this.SuspendLayout();
            // 
            // tagControl
            // 
            this.tagControl.AutoSize = true;
            this.tagControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.tagControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.tagControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.tagControl.BorderRadius = 15;
            this.tagControl.BorderSize = 0;
            this.tagControl.FlatAppearance.BorderSize = 0;
            this.tagControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.tagControl.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.tagControl.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.tagControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tagControl.IconSize = 20;
            this.tagControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagControl.Location = new System.Drawing.Point(0, 0);
            this.tagControl.Margin = new System.Windows.Forms.Padding(0);
            this.tagControl.Name = "tagControl";
            this.tagControl.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tagControl.Size = new System.Drawing.Size(114, 35);
            this.tagControl.TabIndex = 0;
            this.tagControl.Text = "Add Filter";
            this.tagControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.tagControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tagControl.UseVisualStyleBackColor = false;
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tagControl);
            this.Name = "Tag";
            this.Size = new System.Drawing.Size(114, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton tagControl;
    }
}
