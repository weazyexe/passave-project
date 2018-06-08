﻿namespace Passave
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
            this.ForestButton = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.PictureBox();
            this.SecureButton = new System.Windows.Forms.PictureBox();
            this.UIButton = new System.Windows.Forms.PictureBox();
            this.DesertButton = new System.Windows.Forms.PictureBox();
            this.MountainsButton = new System.Windows.Forms.PictureBox();
            this.CityButton = new System.Windows.Forms.PictureBox();
            this.SunsetButton = new System.Windows.Forms.PictureBox();
            this.ApplyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.mDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.RussianButton = new System.Windows.Forms.Button();
            this.BorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForestButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesertButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MountainsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunsetButton)).BeginInit();
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
            this.ThemeLabel.Location = new System.Drawing.Point(191, 66);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(62, 20);
            this.ThemeLabel.TabIndex = 11;
            this.ThemeLabel.Text = "Theme:";
            // 
            // ForestButton
            // 
            this.ForestButton.Image = global::Passave.Properties.Resources.menuimage_forest;
            this.ForestButton.Location = new System.Drawing.Point(194, 97);
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
            // DesertButton
            // 
            this.DesertButton.Image = global::Passave.Properties.Resources.menuimage_desert;
            this.DesertButton.Location = new System.Drawing.Point(308, 97);
            this.DesertButton.Name = "DesertButton";
            this.DesertButton.Size = new System.Drawing.Size(107, 231);
            this.DesertButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DesertButton.TabIndex = 12;
            this.DesertButton.TabStop = false;
            this.DesertButton.Click += new System.EventHandler(this.DesertButton_Click);
            this.DesertButton.MouseLeave += new System.EventHandler(this.DesertButton_MouseLeave);
            this.DesertButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DesertButton_MouseMove);
            // 
            // MountainsButton
            // 
            this.MountainsButton.Image = global::Passave.Properties.Resources.menuimage_mountains;
            this.MountainsButton.Location = new System.Drawing.Point(421, 97);
            this.MountainsButton.Name = "MountainsButton";
            this.MountainsButton.Size = new System.Drawing.Size(107, 231);
            this.MountainsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MountainsButton.TabIndex = 13;
            this.MountainsButton.TabStop = false;
            this.MountainsButton.Click += new System.EventHandler(this.MountainsButton_Click);
            this.MountainsButton.MouseLeave += new System.EventHandler(this.MountainsButton_MouseLeave);
            this.MountainsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MountainsButton_MouseMove);
            // 
            // CityButton
            // 
            this.CityButton.Image = global::Passave.Properties.Resources.menuimage_city;
            this.CityButton.Location = new System.Drawing.Point(534, 97);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(107, 231);
            this.CityButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CityButton.TabIndex = 14;
            this.CityButton.TabStop = false;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            this.CityButton.MouseLeave += new System.EventHandler(this.CityButton_MouseLeave);
            this.CityButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CityButton_MouseMove);
            // 
            // SunsetButton
            // 
            this.SunsetButton.Image = global::Passave.Properties.Resources.menuimage_sunset;
            this.SunsetButton.Location = new System.Drawing.Point(647, 97);
            this.SunsetButton.Name = "SunsetButton";
            this.SunsetButton.Size = new System.Drawing.Size(107, 231);
            this.SunsetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SunsetButton.TabIndex = 15;
            this.SunsetButton.TabStop = false;
            this.SunsetButton.Click += new System.EventHandler(this.SunsetButton_Click);
            this.SunsetButton.MouseLeave += new System.EventHandler(this.SunsetButton_MouseLeave);
            this.SunsetButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SunsetButton_MouseMove);
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
            this.LanguageLabel.Location = new System.Drawing.Point(191, 357);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(84, 20);
            this.LanguageLabel.TabIndex = 20;
            this.LanguageLabel.Text = "Language:";
            // 
            // mDivider1
            // 
            this.mDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDivider1.Depth = 0;
            this.mDivider1.Location = new System.Drawing.Point(195, 344);
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
            this.EnglishButton.Location = new System.Drawing.Point(195, 391);
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
            this.RussianButton.Location = new System.Drawing.Point(308, 391);
            this.RussianButton.Name = "RussianButton";
            this.RussianButton.Size = new System.Drawing.Size(107, 44);
            this.RussianButton.TabIndex = 23;
            this.RussianButton.Text = "РУССКИЙ";
            this.RussianButton.UseVisualStyleBackColor = true;
            this.RussianButton.Click += new System.EventHandler(this.RussianButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 522);
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
            this.Name = "SettingsForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.BorderPanel.ResumeLayout(false);
            this.BorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForestButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UIButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesertButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MountainsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunsetButton)).EndInit();
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
    }
}