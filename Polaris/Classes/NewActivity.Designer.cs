namespace Polaris.Classes
{
    partial class NewActivity
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.NewEditAct = new System.Windows.Forms.Label();
            this.FieldsPanel = new System.Windows.Forms.Panel();
            this.numOutOf = new System.Windows.Forms.NumericUpDown();
            this.ScoreEnd = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.txtShortDesc = new System.Windows.Forms.RichTextBox();
            this.ScoreStart = new System.Windows.Forms.Label();
            this.ShortDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditTag = new FontAwesome.Sharp.IconButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.FieldsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.MenuPanel.Controls.Add(this.NewEditAct);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(543, 60);
            this.MenuPanel.TabIndex = 1;
            // 
            // NewEditAct
            // 
            this.NewEditAct.AutoSize = true;
            this.NewEditAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewEditAct.Font = new System.Drawing.Font("Oxygen", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.NewEditAct.ForeColor = System.Drawing.SystemColors.Control;
            this.NewEditAct.Location = new System.Drawing.Point(14, 9);
            this.NewEditAct.Name = "NewEditAct";
            this.NewEditAct.Size = new System.Drawing.Size(282, 38);
            this.NewEditAct.TabIndex = 0;
            this.NewEditAct.Text = "New / Edit Activity";
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.FieldsPanel.Controls.Add(this.numOutOf);
            this.FieldsPanel.Controls.Add(this.ScoreEnd);
            this.FieldsPanel.Controls.Add(this.numScore);
            this.FieldsPanel.Controls.Add(this.txtShortDesc);
            this.FieldsPanel.Controls.Add(this.ScoreStart);
            this.FieldsPanel.Controls.Add(this.ShortDesc);
            this.FieldsPanel.Controls.Add(this.panel1);
            this.FieldsPanel.Controls.Add(this.MenuPanel);
            this.FieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsPanel.Font = new System.Drawing.Font("Nobile", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FieldsPanel.Location = new System.Drawing.Point(0, 0);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(543, 466);
            this.FieldsPanel.TabIndex = 4;
            // 
            // numOutOf
            // 
            this.numOutOf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.numOutOf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numOutOf.ForeColor = System.Drawing.SystemColors.Info;
            this.numOutOf.Location = new System.Drawing.Point(235, 215);
            this.numOutOf.Name = "numOutOf";
            this.numOutOf.Size = new System.Drawing.Size(119, 19);
            this.numOutOf.TabIndex = 9;
            // 
            // ScoreEnd
            // 
            this.ScoreEnd.AutoSize = true;
            this.ScoreEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreEnd.Font = new System.Drawing.Font("Oxygen", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ScoreEnd.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreEnd.Location = new System.Drawing.Point(230, 175);
            this.ScoreEnd.Name = "ScoreEnd";
            this.ScoreEnd.Size = new System.Drawing.Size(75, 26);
            this.ScoreEnd.TabIndex = 8;
            this.ScoreEnd.Text = "Out of:";
            // 
            // numScore
            // 
            this.numScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.numScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numScore.ForeColor = System.Drawing.SystemColors.Info;
            this.numScore.Location = new System.Drawing.Point(20, 215);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(119, 19);
            this.numScore.TabIndex = 7;
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtShortDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShortDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShortDesc.Font = new System.Drawing.Font("Nobile", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtShortDesc.ForeColor = System.Drawing.Color.White;
            this.txtShortDesc.Location = new System.Drawing.Point(20, 115);
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.Size = new System.Drawing.Size(499, 35);
            this.txtShortDesc.TabIndex = 5;
            this.txtShortDesc.Text = "";
            // 
            // ScoreStart
            // 
            this.ScoreStart.AutoSize = true;
            this.ScoreStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreStart.Font = new System.Drawing.Font("Oxygen", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ScoreStart.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreStart.Location = new System.Drawing.Point(20, 175);
            this.ScoreStart.Name = "ScoreStart";
            this.ScoreStart.Size = new System.Drawing.Size(69, 26);
            this.ScoreStart.TabIndex = 4;
            this.ScoreStart.Text = "Score:";
            // 
            // ShortDesc
            // 
            this.ShortDesc.AutoSize = true;
            this.ShortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShortDesc.Font = new System.Drawing.Font("Oxygen", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ShortDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.ShortDesc.Location = new System.Drawing.Point(20, 75);
            this.ShortDesc.Name = "ShortDesc";
            this.ShortDesc.Size = new System.Drawing.Size(181, 26);
            this.ShortDesc.TabIndex = 1;
            this.ShortDesc.Text = "Short Description:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnEditTag);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 60);
            this.panel1.TabIndex = 2;
            // 
            // btnEditTag
            // 
            this.btnEditTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnEditTag.FlatAppearance.BorderSize = 0;
            this.btnEditTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnEditTag.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnEditTag.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(149)))));
            this.btnEditTag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTag.IconSize = 15;
            this.btnEditTag.Location = new System.Drawing.Point(21, 9);
            this.btnEditTag.Name = "btnEditTag";
            this.btnEditTag.Size = new System.Drawing.Size(141, 41);
            this.btnEditTag.TabIndex = 5;
            this.btnEditTag.Text = "  Edit Tags";
            this.btnEditTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditTag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTag.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(375, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Oxygen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(253, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 466);
            this.Controls.Add(this.FieldsPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewActivity";
            this.ShowInTaskbar = false;
            this.Text = "NewActivity";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label NewEditAct;
        private System.Windows.Forms.Panel FieldsPanel;
        private System.Windows.Forms.RichTextBox txtShortDesc;
        private System.Windows.Forms.Label ScoreStart;
        private System.Windows.Forms.Label ShortDesc;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditTag;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numOutOf;
        private System.Windows.Forms.Label ScoreEnd;
        private System.Windows.Forms.NumericUpDown numScore;
    }
}