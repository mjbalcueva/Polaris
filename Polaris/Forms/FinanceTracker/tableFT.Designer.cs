namespace Polaris.Forms.FinanceTracker
{
    partial class tableFT
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
            this.border = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.editButton = new FontAwesome.Sharp.IconButton();
            this.border.SuspendLayout();
            this.background.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel0.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.border.Controls.Add(this.background);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.border.Size = new System.Drawing.Size(1138, 50);
            this.border.TabIndex = 0;
            this.border.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.border.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.background.Controls.Add(this.tableLayoutPanel1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1136, 48);
            this.background.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editButton, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 48);
            this.tableLayoutPanel1.TabIndex = 21;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ValueLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(63, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(140, 42);
            this.panel1.TabIndex = 8;
            this.panel1.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.panel1.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.ValueLabel.Location = new System.Drawing.Point(13, 12);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(81, 20);
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "ValueLabel";
            this.ValueLabel.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.ValueLabel.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 25;
            this.deleteButton.Location = new System.Drawing.Point(1087, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(46, 42);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DescriptionLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(384, 42);
            this.panel2.TabIndex = 2;
            this.panel2.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.panel2.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 12);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(121, 20);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "DescriptionLabel";
            this.DescriptionLabel.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.DescriptionLabel.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.idLabel);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(3, 3);
            this.panel0.Name = "panel0";
            this.panel0.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel0.Size = new System.Drawing.Size(54, 42);
            this.panel0.TabIndex = 1;
            this.panel0.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.panel0.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.idLabel.Location = new System.Drawing.Point(13, 12);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            this.idLabel.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.idLabel.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ModifiedLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(891, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(140, 42);
            this.panel4.TabIndex = 4;
            this.panel4.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.panel4.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ModifiedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.ModifiedLabel.Location = new System.Drawing.Point(13, 12);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(106, 20);
            this.ModifiedLabel.TabIndex = 1;
            this.ModifiedLabel.Text = "ModifiedLabel";
            this.ModifiedLabel.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.ModifiedLabel.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CreatedLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(745, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(140, 42);
            this.panel3.TabIndex = 3;
            this.panel3.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.panel3.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CreatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.CreatedLabel.Location = new System.Drawing.Point(13, 12);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(97, 20);
            this.CreatedLabel.TabIndex = 1;
            this.CreatedLabel.Text = "CreatedLabel";
            this.CreatedLabel.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.CreatedLabel.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(599, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 42);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.editButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 30;
            this.editButton.Location = new System.Drawing.Point(1037, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(44, 42);
            this.editButton.TabIndex = 6;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.MouseEnter += new System.EventHandler(this.mouse_Enter);
            this.editButton.MouseLeave += new System.EventHandler(this.mouse_Leave);
            // 
            // tableFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.border);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(168)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "tableFT";
            this.Size = new System.Drawing.Size(1138, 50);
            this.Load += new System.EventHandler(this.tableFT_Load);
            this.border.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label CreatedLabel;
        public FontAwesome.Sharp.IconButton editButton;
        public System.Windows.Forms.Panel panel0;
        public System.Windows.Forms.Panel border;
        public System.Windows.Forms.Panel background;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label ValueLabel;
        public FontAwesome.Sharp.IconButton deleteButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
