namespace Passave
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.PictureBox();
            this.SecureButton = new System.Windows.Forms.PictureBox();
            this.UIButton = new System.Windows.Forms.PictureBox();
            this.BorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.ThemePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderPanel
            // 
            this.BorderPanel.Controls.Add(this.HeaderLabel);
            this.BorderPanel.Controls.Add(this.CloseButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(162, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(638, 48);
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
            this.HeaderLabel.Size = new System.Drawing.Size(111, 26);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "SETTINGS";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(604, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // ThemePanel
            // 
            this.ThemePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.ThemePanel.BackgroundImage = global::Passave.Properties.Resources.menuimage_desert;
            this.ThemePanel.Controls.Add(this.AboutButton);
            this.ThemePanel.Controls.Add(this.SecureButton);
            this.ThemePanel.Controls.Add(this.UIButton);
            this.ThemePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThemePanel.Location = new System.Drawing.Point(0, 0);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(162, 450);
            this.ThemePanel.TabIndex = 1;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.Image = global::Passave.Properties.Resources.about_button_default;
            this.AboutButton.Location = new System.Drawing.Point(14, 178);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(135, 50);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.TabStop = false;
            this.AboutButton.MouseLeave += new System.EventHandler(this.AboutButton_MouseLeave);
            this.AboutButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AboutButton_MouseMove);
            // 
            // SecureButton
            // 
            this.SecureButton.BackColor = System.Drawing.Color.Transparent;
            this.SecureButton.Image = global::Passave.Properties.Resources.secure_button_default;
            this.SecureButton.Location = new System.Drawing.Point(14, 122);
            this.SecureButton.Name = "SecureButton";
            this.SecureButton.Size = new System.Drawing.Size(135, 50);
            this.SecureButton.TabIndex = 2;
            this.SecureButton.TabStop = false;
            this.SecureButton.MouseLeave += new System.EventHandler(this.SecureButton_MouseLeave);
            this.SecureButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecureButton_MouseMove);
            // 
            // UIButton
            // 
            this.UIButton.BackColor = System.Drawing.Color.Transparent;
            this.UIButton.Image = global::Passave.Properties.Resources.ui_button_default;
            this.UIButton.Location = new System.Drawing.Point(14, 66);
            this.UIButton.Name = "UIButton";
            this.UIButton.Size = new System.Drawing.Size(135, 50);
            this.UIButton.TabIndex = 1;
            this.UIButton.TabStop = false;
            this.UIButton.MouseLeave += new System.EventHandler(this.UIButton_MouseLeave);
            this.UIButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UIButton_MouseMove);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.ThemePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ThemePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox UIButton;
        private System.Windows.Forms.PictureBox AboutButton;
        private System.Windows.Forms.PictureBox SecureButton;
    }
}