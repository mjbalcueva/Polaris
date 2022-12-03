namespace Polaris.Forms.FinanceTracker
{
    partial class FTInput
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
            this.border = new Polaris.Components.RoundedPanel();
            this.Main = new Polaris.Components.RoundedPanel();
            this.Body = new System.Windows.Forms.Panel();
            this.border2 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.border3 = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Panel();
            this.SaveButton = new Polaris.Components.RoundedButton();
            this.CancelButton = new Polaris.Components.RoundedButton();
            this.border.SuspendLayout();
            this.Main.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border.BorderRadius = 15;
            this.border.Controls.Add(this.Main);
            this.border.ForeColor = System.Drawing.Color.Black;
            this.border.GradientAngle = 90F;
            this.border.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Padding = new System.Windows.Forms.Padding(3);
            this.border.Size = new System.Drawing.Size(700, 700);
            this.border.TabIndex = 2;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Main.BorderRadius = 15;
            this.Main.Controls.Add(this.border3);
            this.Main.Controls.Add(this.Footer);
            this.Main.Controls.Add(this.Body);
            this.Main.Controls.Add(this.border2);
            this.Main.Controls.Add(this.Header);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.Color.Black;
            this.Main.GradientAngle = 90F;
            this.Main.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.Main.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.Main.Location = new System.Drawing.Point(3, 3);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(694, 694);
            this.Main.TabIndex = 0;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(3, 85);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(688, 606);
            this.Body.TabIndex = 2;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.border2.Dock = System.Windows.Forms.DockStyle.Top;
            this.border2.Location = new System.Drawing.Point(3, 83);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(688, 2);
            this.border2.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(688, 80);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.border3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border3.Location = new System.Drawing.Point(3, 609);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(688, 2);
            this.border3.TabIndex = 3;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Footer.Controls.Add(this.CancelButton);
            this.Footer.Controls.Add(this.SaveButton);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(3, 611);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(688, 80);
            this.Footer.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(94)))), ((int)(((byte)(216)))));
            this.SaveButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(94)))), ((int)(((byte)(216)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.SaveButton.BorderRadius = 15;
            this.SaveButton.BorderSize = 0;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.SaveButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SaveButton.IconColor = System.Drawing.Color.Black;
            this.SaveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveButton.Location = new System.Drawing.Point(532, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 48);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.CancelButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.CancelButton.BorderRadius = 15;
            this.CancelButton.BorderSize = 0;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CancelButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CancelButton.IconColor = System.Drawing.Color.Black;
            this.CancelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelButton.Location = new System.Drawing.Point(376, 16);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 48);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FTInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.border);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTInput";
            this.TopMost = true;
            this.border.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RoundedPanel border;
        private Components.RoundedPanel Main;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel border2;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Panel Footer;
        public Components.RoundedButton SaveButton;
        public Components.RoundedButton CancelButton;
    }
}