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
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.mDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.RussianButton = new System.Windows.Forms.Button();
            this.AboutProgramLabel = new System.Windows.Forms.Label();
            this.AboutDevLink = new System.Windows.Forms.LinkLabel();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.SunsetButton = new System.Windows.Forms.PictureBox();
            this.CityButton = new System.Windows.Forms.PictureBox();
            this.MountainsButton = new System.Windows.Forms.PictureBox();
            this.DesertButton = new System.Windows.Forms.PictureBox();
            this.ForestButton = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.PictureBox();
            this.SecureButton = new System.Windows.Forms.PictureBox();
            this.UIButton = new System.Windows.Forms.PictureBox();
            this.ChangePassLabel = new System.Windows.Forms.Label();
            this.OldPasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NewPasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ConfirmPasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChangeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.CreateKeyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CreateKeyLabel = new System.Windows.Forms.Label();
            this.SecureKeyDescLabel = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.BorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunsetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MountainsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesertButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForestButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
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
            this.BorderPanel.Size = new System.Drawing.Size(625, 48);
            this.BorderPanel.TabIndex = 5;
            this.BorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeaderLabel.Location = new System.Drawing.Point(28, 12);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(111, 26);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "SETTINGS";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(591, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThemeLabel.Location = new System.Drawing.Point(192, 91);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(62, 20);
            this.ThemeLabel.TabIndex = 11;
            this.ThemeLabel.Text = "Theme:";
            // 
            // ApplyButton
            // 
            this.ApplyButton.AutoSize = true;
            this.ApplyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApplyButton.Depth = 0;
            this.ApplyButton.Icon = null;
            this.ApplyButton.Location = new System.Drawing.Point(712, 471);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApplyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Primary = false;
            this.ApplyButton.Size = new System.Drawing.Size(63, 36);
            this.ApplyButton.TabIndex = 16;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(631, 471);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = false;
            this.CancelButton.Size = new System.Drawing.Size(73, 36);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LanguageLabel.Location = new System.Drawing.Point(192, 382);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(84, 20);
            this.LanguageLabel.TabIndex = 20;
            this.LanguageLabel.Text = "Language:";
            // 
            // mDivider1
            // 
            this.mDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDivider1.Depth = 0;
            this.mDivider1.Location = new System.Drawing.Point(196, 369);
            this.mDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDivider1.Name = "mDivider1";
            this.mDivider1.Size = new System.Drawing.Size(560, 1);
            this.mDivider1.TabIndex = 21;
            this.mDivider1.Text = "materialDivider1";
            // 
            // EnglishButton
            // 
            this.EnglishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(181)))), ((int)(((byte)(125)))));
            this.EnglishButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(181)))), ((int)(((byte)(125)))));
            this.EnglishButton.FlatAppearance.BorderSize = 2;
            this.EnglishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnglishButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishButton.ForeColor = System.Drawing.Color.White;
            this.EnglishButton.Location = new System.Drawing.Point(196, 416);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(106, 44);
            this.EnglishButton.TabIndex = 22;
            this.EnglishButton.Text = "ENGLISH";
            this.EnglishButton.UseVisualStyleBackColor = false;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // RussianButton
            // 
            this.RussianButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(181)))), ((int)(((byte)(125)))));
            this.RussianButton.FlatAppearance.BorderSize = 2;
            this.RussianButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RussianButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RussianButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(181)))), ((int)(((byte)(125)))));
            this.RussianButton.Location = new System.Drawing.Point(309, 416);
            this.RussianButton.Name = "RussianButton";
            this.RussianButton.Size = new System.Drawing.Size(107, 44);
            this.RussianButton.TabIndex = 23;
            this.RussianButton.Text = "РУССКИЙ";
            this.RussianButton.UseVisualStyleBackColor = true;
            this.RussianButton.Click += new System.EventHandler(this.RussianButton_Click);
            // 
            // AboutProgramLabel
            // 
            this.AboutProgramLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProgramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutProgramLabel.Location = new System.Drawing.Point(269, 276);
            this.AboutProgramLabel.Name = "AboutProgramLabel";
            this.AboutProgramLabel.Size = new System.Drawing.Size(413, 99);
            this.AboutProgramLabel.TabIndex = 25;
            this.AboutProgramLabel.Text = "Passave - simple and beautiful password manager\r\nAn open source project (dev link" +
    " is clickable to github)\r\nCompilation date: 18.06.2018";
            this.AboutProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutDevLink
            // 
            this.AboutDevLink.ActiveLinkColor = System.Drawing.Color.Gray;
            this.AboutDevLink.AutoSize = true;
            this.AboutDevLink.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutDevLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AboutDevLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.AboutDevLink.Location = new System.Drawing.Point(401, 388);
            this.AboutDevLink.Name = "AboutDevLink";
            this.AboutDevLink.Size = new System.Drawing.Size(163, 20);
            this.AboutDevLink.TabIndex = 26;
            this.AboutDevLink.TabStop = true;
            this.AboutDevLink.Text = "Developer: weazy.exe";
            this.AboutDevLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutDevLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutDevLink_LinkClicked);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Passave.Properties.Resources.logo;
            this.LogoPicture.Location = new System.Drawing.Point(354, 89);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(237, 184);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 24;
            this.LogoPicture.TabStop = false;
            // 
            // SunsetButton
            // 
            this.SunsetButton.Image = global::Passave.Properties.Resources.menuimage_sunset;
            this.SunsetButton.Location = new System.Drawing.Point(648, 122);
            this.SunsetButton.Name = "SunsetButton";
            this.SunsetButton.Size = new System.Drawing.Size(107, 231);
            this.SunsetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SunsetButton.TabIndex = 15;
            this.SunsetButton.TabStop = false;
            this.SunsetButton.Click += new System.EventHandler(this.SunsetButton_Click);
            this.SunsetButton.MouseLeave += new System.EventHandler(this.SunsetButton_MouseLeave);
            this.SunsetButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SunsetButton_MouseMove);
            // 
            // CityButton
            // 
            this.CityButton.Image = global::Passave.Properties.Resources.menuimage_city;
            this.CityButton.Location = new System.Drawing.Point(535, 122);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(107, 231);
            this.CityButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CityButton.TabIndex = 14;
            this.CityButton.TabStop = false;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            this.CityButton.MouseLeave += new System.EventHandler(this.CityButton_MouseLeave);
            this.CityButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CityButton_MouseMove);
            // 
            // MountainsButton
            // 
            this.MountainsButton.Image = global::Passave.Properties.Resources.menuimage_mountains;
            this.MountainsButton.Location = new System.Drawing.Point(422, 122);
            this.MountainsButton.Name = "MountainsButton";
            this.MountainsButton.Size = new System.Drawing.Size(107, 231);
            this.MountainsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MountainsButton.TabIndex = 13;
            this.MountainsButton.TabStop = false;
            this.MountainsButton.Click += new System.EventHandler(this.MountainsButton_Click);
            this.MountainsButton.MouseLeave += new System.EventHandler(this.MountainsButton_MouseLeave);
            this.MountainsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MountainsButton_MouseMove);
            // 
            // DesertButton
            // 
            this.DesertButton.Image = global::Passave.Properties.Resources.menuimage_desert;
            this.DesertButton.Location = new System.Drawing.Point(309, 122);
            this.DesertButton.Name = "DesertButton";
            this.DesertButton.Size = new System.Drawing.Size(107, 231);
            this.DesertButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DesertButton.TabIndex = 12;
            this.DesertButton.TabStop = false;
            this.DesertButton.Click += new System.EventHandler(this.DesertButton_Click);
            this.DesertButton.MouseLeave += new System.EventHandler(this.DesertButton_MouseLeave);
            this.DesertButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DesertButton_MouseMove);
            // 
            // ForestButton
            // 
            this.ForestButton.Image = global::Passave.Properties.Resources.menuimage_forest;
            this.ForestButton.Location = new System.Drawing.Point(195, 122);
            this.ForestButton.Name = "ForestButton";
            this.ForestButton.Size = new System.Drawing.Size(107, 231);
            this.ForestButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ForestButton.TabIndex = 6;
            this.ForestButton.TabStop = false;
            this.ForestButton.Click += new System.EventHandler(this.ForestButton_Click);
            this.ForestButton.MouseLeave += new System.EventHandler(this.ForestButton_MouseLeave);
            this.ForestButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ForestButton_MouseMove);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(213)))));
            this.MenuPanel.BackgroundImage = global::Passave.Properties.Resources.menuimage_desert;
            this.MenuPanel.Controls.Add(this.AboutButton);
            this.MenuPanel.Controls.Add(this.SecureButton);
            this.MenuPanel.Controls.Add(this.UIButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(162, 522);
            this.MenuPanel.TabIndex = 1;
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
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
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
            this.SecureButton.Click += new System.EventHandler(this.SecureButton_Click);
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
            this.UIButton.Click += new System.EventHandler(this.UIButton_Click);
            this.UIButton.MouseLeave += new System.EventHandler(this.UIButton_MouseLeave);
            this.UIButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UIButton_MouseMove);
            // 
            // ChangePassLabel
            // 
            this.ChangePassLabel.AutoSize = true;
            this.ChangePassLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangePassLabel.Location = new System.Drawing.Point(191, 91);
            this.ChangePassLabel.Name = "ChangePassLabel";
            this.ChangePassLabel.Size = new System.Drawing.Size(140, 20);
            this.ChangePassLabel.TabIndex = 27;
            this.ChangePassLabel.Text = "Change password:";
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Depth = 0;
            this.OldPasswordTextBox.Hint = "Old password";
            this.OldPasswordTextBox.Location = new System.Drawing.Point(195, 122);
            this.OldPasswordTextBox.MaxLength = 32767;
            this.OldPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.PasswordChar = '\0';
            this.OldPasswordTextBox.SelectedText = "";
            this.OldPasswordTextBox.SelectionLength = 0;
            this.OldPasswordTextBox.SelectionStart = 0;
            this.OldPasswordTextBox.Size = new System.Drawing.Size(200, 23);
            this.OldPasswordTextBox.TabIndex = 28;
            this.OldPasswordTextBox.TabStop = false;
            this.OldPasswordTextBox.UseSystemPasswordChar = false;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Depth = 0;
            this.NewPasswordTextBox.Hint = "New password";
            this.NewPasswordTextBox.Location = new System.Drawing.Point(195, 163);
            this.NewPasswordTextBox.MaxLength = 32767;
            this.NewPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '\0';
            this.NewPasswordTextBox.SelectedText = "";
            this.NewPasswordTextBox.SelectionLength = 0;
            this.NewPasswordTextBox.SelectionStart = 0;
            this.NewPasswordTextBox.Size = new System.Drawing.Size(200, 23);
            this.NewPasswordTextBox.TabIndex = 29;
            this.NewPasswordTextBox.TabStop = false;
            this.NewPasswordTextBox.UseSystemPasswordChar = false;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Depth = 0;
            this.ConfirmPasswordTextBox.Hint = "Confirm new password";
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(195, 205);
            this.ConfirmPasswordTextBox.MaxLength = 32767;
            this.ConfirmPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '\0';
            this.ConfirmPasswordTextBox.SelectedText = "";
            this.ConfirmPasswordTextBox.SelectionLength = 0;
            this.ConfirmPasswordTextBox.SelectionStart = 0;
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(200, 23);
            this.ConfirmPasswordTextBox.TabIndex = 30;
            this.ConfirmPasswordTextBox.TabStop = false;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.AutoSize = true;
            this.ChangeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeButton.Depth = 0;
            this.ChangeButton.Icon = null;
            this.ChangeButton.Location = new System.Drawing.Point(195, 256);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Primary = false;
            this.ChangeButton.Size = new System.Drawing.Size(76, 36);
            this.ChangeButton.TabIndex = 31;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(195, 301);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(560, 1);
            this.materialDivider1.TabIndex = 32;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // CreateKeyButton
            // 
            this.CreateKeyButton.AutoSize = true;
            this.CreateKeyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateKeyButton.Depth = 0;
            this.CreateKeyButton.Icon = null;
            this.CreateKeyButton.Location = new System.Drawing.Point(195, 408);
            this.CreateKeyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateKeyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateKeyButton.Name = "CreateKeyButton";
            this.CreateKeyButton.Primary = false;
            this.CreateKeyButton.Size = new System.Drawing.Size(153, 36);
            this.CreateKeyButton.TabIndex = 33;
            this.CreateKeyButton.Text = "Create secure key";
            this.CreateKeyButton.UseVisualStyleBackColor = true;
            this.CreateKeyButton.Click += new System.EventHandler(this.CreateKeyButton_Click);
            // 
            // CreateKeyLabel
            // 
            this.CreateKeyLabel.AutoSize = true;
            this.CreateKeyLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateKeyLabel.Location = new System.Drawing.Point(191, 316);
            this.CreateKeyLabel.Name = "CreateKeyLabel";
            this.CreateKeyLabel.Size = new System.Drawing.Size(132, 20);
            this.CreateKeyLabel.TabIndex = 34;
            this.CreateKeyLabel.Text = "Create secure key";
            // 
            // SecureKeyDescLabel
            // 
            this.SecureKeyDescLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecureKeyDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SecureKeyDescLabel.Location = new System.Drawing.Point(192, 340);
            this.SecureKeyDescLabel.Name = "SecureKeyDescLabel";
            this.SecureKeyDescLabel.Size = new System.Drawing.Size(321, 62);
            this.SecureKeyDescLabel.TabIndex = 35;
            this.SecureKeyDescLabel.Text = "Secure key - the key you need to open your database, if you forgot password. Keep" +
    " it safe. Restore access to database otherwise impossible!\r\n";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WarningLabel.Location = new System.Drawing.Point(402, 122);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(168, 87);
            this.WarningLabel.TabIndex = 36;
            this.WarningLabel.Text = "If you will change password, your old secure key will be disabled!\r\n";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 522);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SecureKeyDescLabel);
            this.Controls.Add(this.CreateKeyLabel);
            this.Controls.Add(this.CreateKeyButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.ChangePassLabel);
            this.Controls.Add(this.AboutDevLink);
            this.Controls.Add(this.AboutProgramLabel);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.RussianButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.mDivider1);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.SunsetButton);
            this.Controls.Add(this.CityButton);
            this.Controls.Add(this.MountainsButton);
            this.Controls.Add(this.DesertButton);
            this.Controls.Add(this.ForestButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunsetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MountainsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesertButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForestButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox UIButton;
        private System.Windows.Forms.PictureBox AboutButton;
        private System.Windows.Forms.PictureBox SecureButton;
        private System.Windows.Forms.PictureBox ForestButton;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.PictureBox DesertButton;
        private System.Windows.Forms.PictureBox MountainsButton;
        private System.Windows.Forms.PictureBox CityButton;
        private System.Windows.Forms.PictureBox SunsetButton;
        private MaterialSkin.Controls.MaterialFlatButton ApplyButton;
        private MaterialSkin.Controls.MaterialFlatButton CancelButton;
        private System.Windows.Forms.Label LanguageLabel;
        private MaterialSkin.Controls.MaterialDivider mDivider1;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Button RussianButton;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label AboutProgramLabel;
        private System.Windows.Forms.LinkLabel AboutDevLink;
        private System.Windows.Forms.Label ChangePassLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField OldPasswordTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField NewPasswordTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField ConfirmPasswordTextBox;
        private MaterialSkin.Controls.MaterialFlatButton ChangeButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton CreateKeyButton;
        private System.Windows.Forms.Label CreateKeyLabel;
        private System.Windows.Forms.Label SecureKeyDescLabel;
        private System.Windows.Forms.Label WarningLabel;
    }
}