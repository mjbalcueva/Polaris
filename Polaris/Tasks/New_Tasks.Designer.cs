namespace Polaris.Tasks
{
    partial class New_Tasks
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
            this.newTasksBtns = new System.Windows.Forms.Panel();
            this.saveCFBtn = new System.Windows.Forms.Button();
            this.cancelCFBtn = new System.Windows.Forms.Button();
            this.editTagsCFBtn = new System.Windows.Forms.Button();
            this.FiltersPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.newTaskPanel = new System.Windows.Forms.Panel();
            this.cashFlow = new System.Windows.Forms.Label();
            this.addBalFT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descFT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newTasksBtns.SuspendLayout();
            this.newTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTasksBtns
            // 
            this.newTasksBtns.Controls.Add(this.saveCFBtn);
            this.newTasksBtns.Controls.Add(this.cancelCFBtn);
            this.newTasksBtns.Controls.Add(this.editTagsCFBtn);
            this.newTasksBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newTasksBtns.Location = new System.Drawing.Point(35, 545);
            this.newTasksBtns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newTasksBtns.Name = "newTasksBtns";
            this.newTasksBtns.Size = new System.Drawing.Size(730, 112);
            this.newTasksBtns.TabIndex = 14;
            this.newTasksBtns.Paint += new System.Windows.Forms.PaintEventHandler(this.newTasksBtns_Paint);
            // 
            // saveCFBtn
            // 
            this.saveCFBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(97)))), ((int)(((byte)(254)))));
            this.saveCFBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveCFBtn.FlatAppearance.BorderSize = 0;
            this.saveCFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCFBtn.Font = new System.Drawing.Font("Nobile Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.saveCFBtn.ForeColor = System.Drawing.Color.White;
            this.saveCFBtn.Location = new System.Drawing.Point(504, 25);
            this.saveCFBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveCFBtn.Name = "saveCFBtn";
            this.saveCFBtn.Size = new System.Drawing.Size(171, 40);
            this.saveCFBtn.TabIndex = 4;
            this.saveCFBtn.Text = "Save Changes";
            this.saveCFBtn.UseVisualStyleBackColor = false;
            // 
            // cancelCFBtn
            // 
            this.cancelCFBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.cancelCFBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCFBtn.FlatAppearance.BorderSize = 0;
            this.cancelCFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCFBtn.Font = new System.Drawing.Font("Nobile Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cancelCFBtn.ForeColor = System.Drawing.Color.White;
            this.cancelCFBtn.Location = new System.Drawing.Point(385, 25);
            this.cancelCFBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelCFBtn.Name = "cancelCFBtn";
            this.cancelCFBtn.Size = new System.Drawing.Size(113, 40);
            this.cancelCFBtn.TabIndex = 3;
            this.cancelCFBtn.Text = "Cancel";
            this.cancelCFBtn.UseVisualStyleBackColor = false;
            // 
            // editTagsCFBtn
            // 
            this.editTagsCFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTagsCFBtn.Font = new System.Drawing.Font("Nobile Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.editTagsCFBtn.ForeColor = System.Drawing.Color.White;
            this.editTagsCFBtn.Location = new System.Drawing.Point(6, 31);
            this.editTagsCFBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editTagsCFBtn.Name = "editTagsCFBtn";
            this.editTagsCFBtn.Size = new System.Drawing.Size(132, 34);
            this.editTagsCFBtn.TabIndex = 2;
            this.editTagsCFBtn.Text = "+ Edit Tags";
            this.editTagsCFBtn.UseVisualStyleBackColor = true;
            // 
            // FiltersPanel
            // 
            this.FiltersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.FiltersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FiltersPanel.Location = new System.Drawing.Point(765, 91);
            this.FiltersPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltersPanel.Name = "FiltersPanel";
            this.FiltersPanel.Size = new System.Drawing.Size(35, 566);
            this.FiltersPanel.TabIndex = 13;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 91);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(35, 566);
            this.MenuPanel.TabIndex = 12;
            // 
            // newTaskPanel
            // 
            this.newTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.newTaskPanel.Controls.Add(this.cashFlow);
            this.newTaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.newTaskPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newTaskPanel.Name = "newTaskPanel";
            this.newTaskPanel.Size = new System.Drawing.Size(800, 91);
            this.newTaskPanel.TabIndex = 15;
            this.newTaskPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.newTasksPanel_Paint);
            // 
            // cashFlow
            // 
            this.cashFlow.AutoSize = true;
            this.cashFlow.Font = new System.Drawing.Font("Nobile Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cashFlow.ForeColor = System.Drawing.Color.White;
            this.cashFlow.Location = new System.Drawing.Point(28, 33);
            this.cashFlow.Name = "cashFlow";
            this.cashFlow.Size = new System.Drawing.Size(292, 40);
            this.cashFlow.TabIndex = 0;
            this.cashFlow.Text = "New / Edit Task";
            // 
            // addBalFT
            // 
            this.addBalFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.addBalFT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addBalFT.Font = new System.Drawing.Font("Oxygen", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addBalFT.ForeColor = System.Drawing.Color.White;
            this.addBalFT.Location = new System.Drawing.Point(59, 276);
            this.addBalFT.Name = "addBalFT";
            this.addBalFT.Size = new System.Drawing.Size(153, 31);
            this.addBalFT.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nobile Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(162)))));
            this.label2.Location = new System.Drawing.Point(56, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Target Date: ";
            // 
            // descFT
            // 
            this.descFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.descFT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descFT.Font = new System.Drawing.Font("Oxygen", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descFT.ForeColor = System.Drawing.Color.White;
            this.descFT.Location = new System.Drawing.Point(59, 159);
            this.descFT.Name = "descFT";
            this.descFT.Size = new System.Drawing.Size(621, 31);
            this.descFT.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nobile Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(56, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Short Description: ";
            // 
            // New_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.newTasksBtns);
            this.Controls.Add(this.FiltersPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.newTaskPanel);
            this.Controls.Add(this.addBalFT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descFT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Tasks";
            this.ShowInTaskbar = false;
            this.Text = "New_Tasks";
            this.newTasksBtns.ResumeLayout(false);
            this.newTaskPanel.ResumeLayout(false);
            this.newTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel newTasksBtns;
        private System.Windows.Forms.Button saveCFBtn;
        private System.Windows.Forms.Button cancelCFBtn;
        private System.Windows.Forms.Button editTagsCFBtn;
        private System.Windows.Forms.Panel FiltersPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel newTaskPanel;
        private System.Windows.Forms.Label cashFlow;
        private System.Windows.Forms.TextBox addBalFT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descFT;
        private System.Windows.Forms.Label label1;
    }
}