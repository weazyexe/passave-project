namespace Passave
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OKButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SecureKeyButton = new System.Windows.Forms.Label();
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
            this.MenuPanel.Size = new System.Drawing.Size(10, 205);
            this.MenuPanel.TabIndex = 1;
            // 
            // BorderPanel
            // 
            this.BorderPanel.Controls.Add(this.HeaderLabel);
            this.BorderPanel.Controls.Add(this.CloseButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(10, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(443, 48);
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
            this.HeaderLabel.Size = new System.Drawing.Size(127, 26);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "PASSWORD";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(409, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Hint = "Enter here";
            this.PasswordTextBox.Location = new System.Drawing.Point(39, 101);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.Size = new System.Drawing.Size(402, 23);
            this.PasswordTextBox.TabIndex = 16;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.UseSystemPasswordChar = false;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThemeLabel.Location = new System.Drawing.Point(35, 68);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(157, 20);
            this.ThemeLabel.TabIndex = 17;
            this.ThemeLabel.Text = "Enter your password:";
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(321, 154);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = false;
            this.CancelButton.Size = new System.Drawing.Size(73, 36);
            this.CancelButton.TabIndex = 19;
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
            this.OKButton.Location = new System.Drawing.Point(402, 154);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.Primary = false;
            this.OKButton.Size = new System.Drawing.Size(39, 36);
            this.OKButton.TabIndex = 18;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SecureKeyButton
            // 
            this.SecureKeyButton.AutoSize = true;
            this.SecureKeyButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecureKeyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SecureKeyButton.Location = new System.Drawing.Point(36, 140);
            this.SecureKeyButton.Name = "SecureKeyButton";
            this.SecureKeyButton.Size = new System.Drawing.Size(86, 15);
            this.SecureKeyButton.TabIndex = 20;
            this.SecureKeyButton.Text = "Use secure key";
            this.SecureKeyButton.Click += new System.EventHandler(this.SecureKeyButton_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 205);
            this.Controls.Add(this.SecureKeyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter your password";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTextBox;
        private System.Windows.Forms.Label ThemeLabel;
        private MaterialSkin.Controls.MaterialFlatButton CancelButton;
        private MaterialSkin.Controls.MaterialFlatButton OKButton;
        private System.Windows.Forms.Label SecureKeyButton;
    }
}