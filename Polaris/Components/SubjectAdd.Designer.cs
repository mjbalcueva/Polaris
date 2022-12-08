namespace Polaris.Components
{
    partial class SubjectAdd
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
            this.roundedPanel1 = new Polaris.Components.RoundedPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.icon = new Polaris.Components.RoundedPanel();
            this.bgHover = new Polaris.Components.RoundedPanel();
            this.badge = new Polaris.Components.RoundedButton();
            this.roundedPanel1.SuspendLayout();
            this.bgHover.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.Controls.Add(this.textBox1);
            this.roundedPanel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roundedPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedPanel1.GradientAngle = 90F;
            this.roundedPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.roundedPanel1.Location = new System.Drawing.Point(90, 6);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(9);
            this.roundedPanel1.Size = new System.Drawing.Size(140, 38);
            this.roundedPanel1.TabIndex = 10;
            this.roundedPanel1.MouseEnter += new System.EventHandler(this.bgHover_MouseEnter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(9, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.MouseEnter += new System.EventHandler(this.bgHover_MouseEnter);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.icon.BorderRadius = 10;
            this.icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.icon.GradientAngle = 90F;
            this.icon.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.icon.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.icon.Location = new System.Drawing.Point(58, 14);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(22, 22);
            this.icon.TabIndex = 8;
            this.icon.MouseEnter += new System.EventHandler(this.bgHover_MouseEnter);
            // 
            // bgHover
            // 
            this.bgHover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.bgHover.BorderRadius = 15;
            this.bgHover.Controls.Add(this.badge);
            this.bgHover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.bgHover.GradientAngle = 90F;
            this.bgHover.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.bgHover.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.bgHover.Location = new System.Drawing.Point(10, 0);
            this.bgHover.Name = "bgHover";
            this.bgHover.Size = new System.Drawing.Size(270, 50);
            this.bgHover.TabIndex = 11;
            this.bgHover.MouseEnter += new System.EventHandler(this.bgHover_MouseEnter);
            this.bgHover.MouseLeave += new System.EventHandler(this.bgHover_MouseLeave);
            // 
            // badge
            // 
            this.badge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.badge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.badge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.badge.BorderRadius = 35;
            this.badge.BorderSize = 0;
            this.badge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badge.FlatAppearance.BorderSize = 0;
            this.badge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.badge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.badge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.badge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.badge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.badge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.badge.IconSize = 20;
            this.badge.Location = new System.Drawing.Point(228, 8);
            this.badge.Margin = new System.Windows.Forms.Padding(0);
            this.badge.Name = "badge";
            this.badge.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.badge.Size = new System.Drawing.Size(35, 35);
            this.badge.TabIndex = 12;
            this.badge.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.badge.UseVisualStyleBackColor = false;
            this.badge.Click += new System.EventHandler(this.badge_Click);
            // 
            // SubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.bgHover);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Name = "SubjectAdd";
            this.Size = new System.Drawing.Size(300, 50);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.bgHover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel roundedPanel1;
        public System.Windows.Forms.TextBox textBox1;
        private RoundedPanel bgHover;
        public RoundedPanel icon;
        public RoundedButton badge;
    }
}
