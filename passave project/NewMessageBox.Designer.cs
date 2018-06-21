namespace Passave
{
    partial class NewMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessageBox));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OKButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.MessageTextBox = new System.Windows.Forms.Label();
            this.YesButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.NoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.BorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.MenuPanel.BackgroundImage = global::Passave.Properties.Resources.menuimage_desert;
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(10, 220);
            this.MenuPanel.TabIndex = 1;
            // 
            // BorderPanel
            // 
            this.BorderPanel.Controls.Add(this.HeaderLabel);
            this.BorderPanel.Controls.Add(this.CloseButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(10, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(297, 48);
            this.BorderPanel.TabIndex = 5;
            this.BorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeaderLabel.Location = new System.Drawing.Point(24, 12);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(108, 26);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "MESSAGE";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(263, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(120, 169);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = false;
            this.CancelButton.Size = new System.Drawing.Size(73, 36);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKButton.Depth = 0;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(256, 169);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.Primary = false;
            this.OKButton.Size = new System.Drawing.Size(39, 36);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MessageTextBox.Location = new System.Drawing.Point(35, 68);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(260, 95);
            this.MessageTextBox.TabIndex = 17;
            this.MessageTextBox.Text = "Text here";
            // 
            // YesButton
            // 
            this.YesButton.AutoSize = true;
            this.YesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YesButton.Depth = 0;
            this.YesButton.Icon = null;
            this.YesButton.Location = new System.Drawing.Point(250, 169);
            this.YesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.YesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.YesButton.Name = "YesButton";
            this.YesButton.Primary = false;
            this.YesButton.Size = new System.Drawing.Size(45, 36);
            this.YesButton.TabIndex = 18;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.AutoSize = true;
            this.NoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoButton.Depth = 0;
            this.NoButton.Icon = null;
            this.NoButton.Location = new System.Drawing.Point(201, 169);
            this.NoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NoButton.Name = "NoButton";
            this.NoButton.Primary = false;
            this.NoButton.Size = new System.Drawing.Size(40, 36);
            this.NoButton.TabIndex = 19;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // NewMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 220);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.NewMessageBox_Load);
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox CloseButton;
        private MaterialSkin.Controls.MaterialFlatButton CancelButton;
        private MaterialSkin.Controls.MaterialFlatButton OKButton;
        private System.Windows.Forms.Label MessageTextBox;
        private MaterialSkin.Controls.MaterialFlatButton YesButton;
        private MaterialSkin.Controls.MaterialFlatButton NoButton;
    }
}