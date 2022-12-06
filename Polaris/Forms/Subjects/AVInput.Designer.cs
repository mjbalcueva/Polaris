namespace Polaris.Forms.Subjects
{
    partial class AVInput
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
            this.Main = new Polaris.Components.RoundedPanel();
            this.border3 = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Panel();
            this.CancelButton = new Polaris.Components.RoundedButton();
            this.SaveButton = new Polaris.Components.RoundedButton();
            this.Body = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new Polaris.Components.RoundedPanel();
            this.descriptionLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Polaris.Components.RoundedPanel();
            this.scoreLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.border2 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.title1 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Polaris.Components.RoundedPanel();
            this.outOfLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Body.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(700, 700);
            this.Main.TabIndex = 2;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.border3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border3.Location = new System.Drawing.Point(3, 615);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(694, 2);
            this.border3.TabIndex = 3;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Footer.Controls.Add(this.CancelButton);
            this.Footer.Controls.Add(this.SaveButton);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Footer.Location = new System.Drawing.Point(3, 617);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Footer.Size = new System.Drawing.Size(694, 80);
            this.Footer.TabIndex = 4;
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
            this.CancelButton.Location = new System.Drawing.Point(367, 16);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 48);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.SaveButton.Location = new System.Drawing.Point(523, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 48);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Body.Controls.Add(this.roundedPanel3);
            this.Body.Controls.Add(this.label3);
            this.Body.Controls.Add(this.roundedPanel2);
            this.Body.Controls.Add(this.label2);
            this.Body.Controls.Add(this.roundedPanel1);
            this.Body.Controls.Add(this.label1);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Body.Location = new System.Drawing.Point(3, 85);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.Body.Size = new System.Drawing.Size(694, 612);
            this.Body.TabIndex = 2;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel2.BorderRadius = 15;
            this.roundedPanel2.Controls.Add(this.descriptionLabel);
            this.roundedPanel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roundedPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedPanel2.GradientAngle = 90F;
            this.roundedPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel2.Location = new System.Drawing.Point(25, 176);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(15, 9, 15, 9);
            this.roundedPanel2.Size = new System.Drawing.Size(648, 40);
            this.roundedPanel2.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.descriptionLabel.Location = new System.Drawing.Point(15, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(618, 22);
            this.descriptionLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(19, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Short Description";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.scoreLabel);
            this.roundedPanel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roundedPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedPanel1.GradientAngle = 90F;
            this.roundedPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel1.Location = new System.Drawing.Point(24, 68);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(15, 9, 15, 9);
            this.roundedPanel1.Size = new System.Drawing.Size(206, 40);
            this.roundedPanel1.TabIndex = 11;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.scoreLabel.Location = new System.Drawing.Point(15, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(176, 22);
            this.scoreLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.border2.Dock = System.Windows.Forms.DockStyle.Top;
            this.border2.Location = new System.Drawing.Point(3, 83);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(694, 2);
            this.border2.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Header.Controls.Add(this.title1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Header.Size = new System.Drawing.Size(694, 80);
            this.Header.TabIndex = 0;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(18, 22);
            this.title1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(243, 36);
            this.title1.TabIndex = 1;
            this.title1.Text = "New / Edit Activity";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel3.BorderRadius = 15;
            this.roundedPanel3.Controls.Add(this.outOfLabel);
            this.roundedPanel3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roundedPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedPanel3.GradientAngle = 90F;
            this.roundedPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel3.Location = new System.Drawing.Point(327, 68);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Padding = new System.Windows.Forms.Padding(15, 9, 15, 9);
            this.roundedPanel3.Size = new System.Drawing.Size(206, 40);
            this.roundedPanel3.TabIndex = 13;
            // 
            // outOfLabel
            // 
            this.outOfLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.outOfLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outOfLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outOfLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.outOfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.outOfLabel.Location = new System.Drawing.Point(15, 9);
            this.outOfLabel.Name = "outOfLabel";
            this.outOfLabel.Size = new System.Drawing.Size(176, 22);
            this.outOfLabel.TabIndex = 0;
            this.outOfLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.outOfLabel_MouseDown);
            this.outOfLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.outOfLabel_MouseMove);
            this.outOfLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.outOfLabel_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(321, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Out of";
            // 
            // AVInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.Main);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AVInput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVInput";
            this.Main.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RoundedPanel Main;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Panel Footer;
        public Components.RoundedButton CancelButton;
        public Components.RoundedButton SaveButton;
        private System.Windows.Forms.Panel Body;
        private Components.RoundedPanel roundedPanel2;
        public System.Windows.Forms.TextBox descriptionLabel;
        private System.Windows.Forms.Label label2;
        private Components.RoundedPanel roundedPanel1;
        public System.Windows.Forms.TextBox scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel border2;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label title1;
        private Components.RoundedPanel roundedPanel3;
        public System.Windows.Forms.TextBox outOfLabel;
        private System.Windows.Forms.Label label3;
    }
}