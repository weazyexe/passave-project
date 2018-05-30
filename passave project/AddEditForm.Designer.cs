namespace Passave
{
    partial class AddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.NameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RepeatPasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PhoneTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UrlTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NotesTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.HeaderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.BorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemePanel
            // 
            this.ThemePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.ThemePanel.BackgroundImage = global::Passave.Properties.Resources.menuimage_forest;
            this.ThemePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThemePanel.Location = new System.Drawing.Point(0, 0);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(10, 500);
            this.ThemePanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(271, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // BorderPanel
            // 
            this.BorderPanel.Controls.Add(this.HeaderLabel);
            this.BorderPanel.Controls.Add(this.CloseButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(10, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(305, 48);
            this.BorderPanel.TabIndex = 4;
            this.BorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseDown);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Depth = 0;
            this.NameTextBox.Hint = "Name";
            this.NameTextBox.Location = new System.Drawing.Point(39, 67);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.Size = new System.Drawing.Size(242, 23);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TabStop = false;
            this.NameTextBox.UseSystemPasswordChar = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Depth = 0;
            this.LoginTextBox.Hint = "Login";
            this.LoginTextBox.Location = new System.Drawing.Point(39, 117);
            this.LoginTextBox.MaxLength = 32767;
            this.LoginTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.SelectionLength = 0;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.Size = new System.Drawing.Size(242, 23);
            this.LoginTextBox.TabIndex = 7;
            this.LoginTextBox.TabStop = false;
            this.LoginTextBox.UseSystemPasswordChar = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Hint = "Password";
            this.PasswordTextBox.Location = new System.Drawing.Point(39, 167);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.Size = new System.Drawing.Size(242, 23);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.UseSystemPasswordChar = false;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Depth = 0;
            this.RepeatPasswordTextBox.Hint = "Repeat Password";
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(39, 217);
            this.RepeatPasswordTextBox.MaxLength = 32767;
            this.RepeatPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '•';
            this.RepeatPasswordTextBox.SelectedText = "";
            this.RepeatPasswordTextBox.SelectionLength = 0;
            this.RepeatPasswordTextBox.SelectionStart = 0;
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(242, 23);
            this.RepeatPasswordTextBox.TabIndex = 9;
            this.RepeatPasswordTextBox.TabStop = false;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = false;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Depth = 0;
            this.PhoneTextBox.Hint = "Phone";
            this.PhoneTextBox.Location = new System.Drawing.Point(39, 267);
            this.PhoneTextBox.MaxLength = 32767;
            this.PhoneTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '\0';
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.SelectionLength = 0;
            this.PhoneTextBox.SelectionStart = 0;
            this.PhoneTextBox.Size = new System.Drawing.Size(242, 23);
            this.PhoneTextBox.TabIndex = 10;
            this.PhoneTextBox.TabStop = false;
            this.PhoneTextBox.UseSystemPasswordChar = false;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Depth = 0;
            this.UrlTextBox.Hint = "URL";
            this.UrlTextBox.Location = new System.Drawing.Point(39, 317);
            this.UrlTextBox.MaxLength = 32767;
            this.UrlTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.PasswordChar = '\0';
            this.UrlTextBox.SelectedText = "";
            this.UrlTextBox.SelectionLength = 0;
            this.UrlTextBox.SelectionStart = 0;
            this.UrlTextBox.Size = new System.Drawing.Size(242, 23);
            this.UrlTextBox.TabIndex = 11;
            this.UrlTextBox.TabStop = false;
            this.UrlTextBox.UseSystemPasswordChar = false;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Depth = 0;
            this.NotesTextBox.Hint = "Notes";
            this.NotesTextBox.Location = new System.Drawing.Point(39, 367);
            this.NotesTextBox.MaxLength = 32767;
            this.NotesTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.PasswordChar = '\0';
            this.NotesTextBox.SelectedText = "";
            this.NotesTextBox.SelectionLength = 0;
            this.NotesTextBox.SelectionStart = 0;
            this.NotesTextBox.Size = new System.Drawing.Size(242, 23);
            this.NotesTextBox.TabIndex = 12;
            this.NotesTextBox.TabStop = false;
            this.NotesTextBox.UseSystemPasswordChar = false;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeaderLabel.Location = new System.Drawing.Point(24, 12);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(126, 26);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "ADD ENTRY";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 500);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.ThemePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel BorderPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField RepeatPasswordTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PhoneTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField UrlTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField NotesTextBox;
        private System.Windows.Forms.Label HeaderLabel;
    }
}