namespace Polaris.Forms.FinanceTracker
{
    partial class FinanceTracker
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
            this.TableHeader = new System.Windows.Forms.Panel();
            this.Value = new Polaris.Components.RoundedButton();
            this.Tags = new Polaris.Components.RoundedButton();
            this.Due = new Polaris.Components.RoundedButton();
            this.Created = new Polaris.Components.RoundedButton();
            this.Description = new Polaris.Components.RoundedButton();
            this.sectionButton = new Polaris.Components.RoundedButton();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tag1 = new Polaris.Components.Tag();
            this.roundedButton1 = new Polaris.Components.RoundedButton();
            this.TableHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableHeader
            // 
            this.TableHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.TableHeader.Controls.Add(this.Value);
            this.TableHeader.Controls.Add(this.Tags);
            this.TableHeader.Controls.Add(this.Due);
            this.TableHeader.Controls.Add(this.Created);
            this.TableHeader.Controls.Add(this.Description);
            this.TableHeader.Location = new System.Drawing.Point(38, 157);
            this.TableHeader.Name = "TableHeader";
            this.TableHeader.Size = new System.Drawing.Size(728, 50);
            this.TableHeader.TabIndex = 8;
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Value.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Value.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Value.BorderRadius = 15;
            this.Value.BorderSize = 0;
            this.Value.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Value.FlatAppearance.BorderSize = 0;
            this.Value.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Value.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Value.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Value.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Value.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.Value.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Value.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Value.IconSize = 25;
            this.Value.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Value.Location = new System.Drawing.Point(3, 5);
            this.Value.Name = "Value";
            this.Value.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Value.Rotation = 90D;
            this.Value.Size = new System.Drawing.Size(125, 40);
            this.Value.TabIndex = 5;
            this.Value.Text = "Value";
            this.Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Value.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Value.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Value.UseVisualStyleBackColor = false;
            // 
            // Tags
            // 
            this.Tags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Tags.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Tags.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Tags.BorderRadius = 15;
            this.Tags.BorderSize = 0;
            this.Tags.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tags.FlatAppearance.BorderSize = 0;
            this.Tags.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Tags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Tags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tags.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Tags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Tags.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.Tags.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Tags.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Tags.IconSize = 25;
            this.Tags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tags.Location = new System.Drawing.Point(303, 5);
            this.Tags.Name = "Tags";
            this.Tags.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Tags.Rotation = 90D;
            this.Tags.Size = new System.Drawing.Size(110, 40);
            this.Tags.TabIndex = 4;
            this.Tags.Text = "Tags";
            this.Tags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tags.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Tags.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Tags.UseVisualStyleBackColor = false;
            // 
            // Due
            // 
            this.Due.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Due.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Due.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Due.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Due.BorderRadius = 15;
            this.Due.BorderSize = 0;
            this.Due.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Due.FlatAppearance.BorderSize = 0;
            this.Due.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Due.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Due.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Due.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Due.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Due.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.Due.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Due.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Due.IconSize = 25;
            this.Due.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Due.Location = new System.Drawing.Point(575, 5);
            this.Due.Name = "Due";
            this.Due.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Due.Rotation = 90D;
            this.Due.Size = new System.Drawing.Size(150, 40);
            this.Due.TabIndex = 3;
            this.Due.Text = "Updated";
            this.Due.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Due.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Due.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Due.UseVisualStyleBackColor = false;
            // 
            // Created
            // 
            this.Created.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Created.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Created.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Created.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Created.BorderRadius = 15;
            this.Created.BorderSize = 0;
            this.Created.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Created.FlatAppearance.BorderSize = 0;
            this.Created.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Created.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Created.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Created.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Created.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Created.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.Created.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Created.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Created.IconSize = 25;
            this.Created.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Created.Location = new System.Drawing.Point(419, 5);
            this.Created.Name = "Created";
            this.Created.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Created.Rotation = 90D;
            this.Created.Size = new System.Drawing.Size(150, 40);
            this.Created.TabIndex = 2;
            this.Created.Text = "Created";
            this.Created.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Created.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Created.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Created.UseVisualStyleBackColor = false;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Description.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Description.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Description.BorderRadius = 15;
            this.Description.BorderSize = 0;
            this.Description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Description.FlatAppearance.BorderSize = 0;
            this.Description.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Description.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Description.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.Description.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Description.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Description.IconSize = 25;
            this.Description.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Description.Location = new System.Drawing.Point(122, 5);
            this.Description.Name = "Description";
            this.Description.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Description.Rotation = 90D;
            this.Description.Size = new System.Drawing.Size(175, 40);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Description.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Description.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Description.UseVisualStyleBackColor = false;
            // 
            // sectionButton
            // 
            this.sectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(94)))), ((int)(((byte)(216)))));
            this.sectionButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(94)))), ((int)(((byte)(216)))));
            this.sectionButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.sectionButton.BorderRadius = 15;
            this.sectionButton.BorderSize = 0;
            this.sectionButton.FlatAppearance.BorderSize = 0;
            this.sectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.sectionButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.sectionButton.IconColor = System.Drawing.Color.Black;
            this.sectionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sectionButton.Location = new System.Drawing.Point(566, 28);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(200, 48);
            this.sectionButton.TabIndex = 7;
            this.sectionButton.Text = "New Record";
            this.sectionButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.sectionButton.UseVisualStyleBackColor = false;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sectionLabel.Location = new System.Drawing.Point(35, 28);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(284, 36);
            this.sectionLabel.TabIndex = 6;
            this.sectionLabel.Text = "Finance Tracker Section";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.flowLayoutPanel1.Controls.Add(this.tag1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 39);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // tag1
            // 
            this.tag1.AutoSize = true;
            this.tag1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tag1.Location = new System.Drawing.Point(3, 3);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(112, 33);
            this.tag1.TabIndex = 0;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.PesoSign;
            this.roundedButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton1.IconSize = 20;
            this.roundedButton1.Location = new System.Drawing.Point(360, 28);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(200, 48);
            this.roundedButton1.TabIndex = 10;
            this.roundedButton1.Text = "0.00";
            this.roundedButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // FinanceTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(804, 551);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TableHeader);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.sectionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Name = "FinanceTracker";
            this.Text = "FinanceTracker";
            this.TableHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TableHeader;
        private Components.RoundedButton Tags;
        private Components.RoundedButton Due;
        private Components.RoundedButton Created;
        private Components.RoundedButton Description;
        public Components.RoundedButton sectionButton;
        public System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Components.Tag tag1;
        private Components.RoundedButton Value;
        public Components.RoundedButton roundedButton1;
    }
}