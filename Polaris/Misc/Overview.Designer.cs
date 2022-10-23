namespace Polaris
{
    partial class Overview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.OverviewPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.USTVision = new System.Windows.Forms.Label();
            this.txtVision = new System.Windows.Forms.RichTextBox();
            this.USTMission = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OverviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OverviewPanel
            // 
            this.OverviewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.OverviewPanel.Controls.Add(this.richTextBox1);
            this.OverviewPanel.Controls.Add(this.USTMission);
            this.OverviewPanel.Controls.Add(this.txtVision);
            this.OverviewPanel.Controls.Add(this.USTVision);
            this.OverviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewPanel.Location = new System.Drawing.Point(0, 0);
            this.OverviewPanel.Name = "OverviewPanel";
            this.OverviewPanel.Size = new System.Drawing.Size(864, 526);
            this.OverviewPanel.TabIndex = 0;
            this.OverviewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OverviewPanel_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // USTVision
            // 
            this.USTVision.AutoSize = true;
            this.USTVision.Dock = System.Windows.Forms.DockStyle.Top;
            this.USTVision.Font = new System.Drawing.Font("Oxygen", 16F, System.Drawing.FontStyle.Bold);
            this.USTVision.ForeColor = System.Drawing.SystemColors.Control;
            this.USTVision.Location = new System.Drawing.Point(0, 0);
            this.USTVision.Name = "USTVision";
            this.USTVision.Size = new System.Drawing.Size(256, 34);
            this.USTVision.TabIndex = 1;
            this.USTVision.Text = "UST-Legazpi Vision";
            // 
            // txtVision
            // 
            this.txtVision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.txtVision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVision.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtVision.Font = new System.Drawing.Font("Nobile", 12F);
            this.txtVision.ForeColor = System.Drawing.SystemColors.Info;
            this.txtVision.Location = new System.Drawing.Point(0, 34);
            this.txtVision.Name = "txtVision";
            this.txtVision.ReadOnly = true;
            this.txtVision.Size = new System.Drawing.Size(864, 274);
            this.txtVision.TabIndex = 2;
            this.txtVision.Text = resources.GetString("txtVision.Text");
            // 
            // USTMission
            // 
            this.USTMission.Dock = System.Windows.Forms.DockStyle.Top;
            this.USTMission.Font = new System.Drawing.Font("Oxygen", 16F, System.Drawing.FontStyle.Bold);
            this.USTMission.ForeColor = System.Drawing.SystemColors.Control;
            this.USTMission.Location = new System.Drawing.Point(0, 308);
            this.USTMission.Name = "USTMission";
            this.USTMission.Size = new System.Drawing.Size(864, 61);
            this.USTMission.TabIndex = 3;
            this.USTMission.Text = "UST-Legazpi Mission";
            this.USTMission.Click += new System.EventHandler(this.USTMission_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Nobile", 12F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(0, 369);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(864, 223);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.OverviewPanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Overview";
            this.Text = "Overview";
            this.OverviewPanel.ResumeLayout(false);
            this.OverviewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OverviewPanel;
        private System.Windows.Forms.Label USTMission;
        private System.Windows.Forms.RichTextBox txtVision;
        private System.Windows.Forms.Label USTVision;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}