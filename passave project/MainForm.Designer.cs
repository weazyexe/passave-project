namespace Passave
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("kek");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.SearchTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.PictureBox();
            this.NewButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.OtherButton = new System.Windows.Forms.PictureBox();
            this.LicensesButton = new System.Windows.Forms.PictureBox();
            this.HomebankingButton = new System.Windows.Forms.PictureBox();
            this.EmailButton = new System.Windows.Forms.PictureBox();
            this.SNButton = new System.Windows.Forms.PictureBox();
            this.BorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicensesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomebankingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNButton)).BeginInit();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7});
            this.materialListView1.Location = new System.Drawing.Point(297, 77);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(691, 511);
            this.materialListView1.TabIndex = 2;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // BorderPanel
            // 
            this.BorderPanel.Controls.Add(this.SearchButton);
            this.BorderPanel.Controls.Add(this.SearchTextBox);
            this.BorderPanel.Controls.Add(this.SaveButton);
            this.BorderPanel.Controls.Add(this.OpenButton);
            this.BorderPanel.Controls.Add(this.NewButton);
            this.BorderPanel.Controls.Add(this.MinimizeButton);
            this.BorderPanel.Controls.Add(this.CloseButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(280, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(720, 59);
            this.BorderPanel.TabIndex = 3;
            this.BorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseDown);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Depth = 0;
            this.SearchTextBox.Hint = "Search";
            this.SearchTextBox.Location = new System.Drawing.Point(149, 24);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.Size = new System.Drawing.Size(156, 23);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TabStop = false;
            this.SearchTextBox.UseSystemPasswordChar = false;
            // 
            // SearchButton
            // 
            this.SearchButton.ErrorImage = null;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(311, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(35, 35);
            this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchButton.TabIndex = 6;
            this.SearchButton.TabStop = false;
            this.SearchButton.MouseLeave += new System.EventHandler(this.SearchButton_MouseLeave);
            this.SearchButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchButton_MouseMove);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(99, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(35, 35);
            this.SaveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SaveButton.TabIndex = 4;
            this.SaveButton.TabStop = false;
            this.SaveButton.MouseLeave += new System.EventHandler(this.SaveButton_MouseLeave);
            this.SaveButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaveButton_MouseMove);
            // 
            // OpenButton
            // 
            this.OpenButton.Image = global::Passave.Properties.Resources.open_button_default;
            this.OpenButton.Location = new System.Drawing.Point(58, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(35, 35);
            this.OpenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenButton.TabIndex = 3;
            this.OpenButton.TabStop = false;
            this.OpenButton.MouseLeave += new System.EventHandler(this.OpenButton_MouseLeave);
            this.OpenButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OpenButton_MouseMove);
            // 
            // NewButton
            // 
            this.NewButton.Image = global::Passave.Properties.Resources.new_button_default;
            this.NewButton.Location = new System.Drawing.Point(17, 12);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(35, 35);
            this.NewButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewButton.TabIndex = 2;
            this.NewButton.TabStop = false;
            this.NewButton.MouseLeave += new System.EventHandler(this.NewButton_MouseLeave);
            this.NewButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewButton_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(658, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 22);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            this.MinimizeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(686, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.BackgroundImage = global::Passave.Properties.Resources.menuimage_forest;
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.OtherButton);
            this.MenuPanel.Controls.Add(this.LicensesButton);
            this.MenuPanel.Controls.Add(this.HomebankingButton);
            this.MenuPanel.Controls.Add(this.EmailButton);
            this.MenuPanel.Controls.Add(this.SNButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(280, 600);
            this.MenuPanel.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Image = global::Passave.Properties.Resources.settings_button_default;
            this.SettingsButton.Location = new System.Drawing.Point(29, 538);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(220, 50);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.MouseLeave += new System.EventHandler(this.SettingsButton_MouseLeave);
            this.SettingsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsButton_MouseMove);
            // 
            // OtherButton
            // 
            this.OtherButton.BackColor = System.Drawing.Color.Transparent;
            this.OtherButton.Image = global::Passave.Properties.Resources.other_button_default;
            this.OtherButton.Location = new System.Drawing.Point(29, 301);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(220, 50);
            this.OtherButton.TabIndex = 4;
            this.OtherButton.TabStop = false;
            this.OtherButton.MouseLeave += new System.EventHandler(this.OtherButton_MouseLeave);
            this.OtherButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OtherButton_MouseMove);
            // 
            // LicensesButton
            // 
            this.LicensesButton.BackColor = System.Drawing.Color.Transparent;
            this.LicensesButton.Image = global::Passave.Properties.Resources.licenses_button_default;
            this.LicensesButton.Location = new System.Drawing.Point(29, 245);
            this.LicensesButton.Name = "LicensesButton";
            this.LicensesButton.Size = new System.Drawing.Size(220, 50);
            this.LicensesButton.TabIndex = 3;
            this.LicensesButton.TabStop = false;
            this.LicensesButton.MouseLeave += new System.EventHandler(this.LicensesButton_MouseLeave);
            this.LicensesButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LicensesButton_MouseMove);
            // 
            // HomebankingButton
            // 
            this.HomebankingButton.BackColor = System.Drawing.Color.Transparent;
            this.HomebankingButton.Image = global::Passave.Properties.Resources.homebanking_button_default;
            this.HomebankingButton.Location = new System.Drawing.Point(29, 189);
            this.HomebankingButton.Name = "HomebankingButton";
            this.HomebankingButton.Size = new System.Drawing.Size(220, 50);
            this.HomebankingButton.TabIndex = 2;
            this.HomebankingButton.TabStop = false;
            this.HomebankingButton.MouseLeave += new System.EventHandler(this.HomebankingButton_MouseLeave);
            this.HomebankingButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomebankingButton_MouseMove);
            // 
            // EmailButton
            // 
            this.EmailButton.BackColor = System.Drawing.Color.Transparent;
            this.EmailButton.Image = global::Passave.Properties.Resources.email_button_default;
            this.EmailButton.Location = new System.Drawing.Point(29, 133);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(220, 50);
            this.EmailButton.TabIndex = 1;
            this.EmailButton.TabStop = false;
            this.EmailButton.MouseLeave += new System.EventHandler(this.EmailButton_MouseLeave);
            this.EmailButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmailButton_MouseMove);
            // 
            // SNButton
            // 
            this.SNButton.BackColor = System.Drawing.Color.Transparent;
            this.SNButton.Image = global::Passave.Properties.Resources.sn_button_default;
            this.SNButton.Location = new System.Drawing.Point(29, 77);
            this.SNButton.Name = "SNButton";
            this.SNButton.Size = new System.Drawing.Size(220, 50);
            this.SNButton.TabIndex = 0;
            this.SNButton.TabStop = false;
            this.SNButton.MouseLeave += new System.EventHandler(this.SNButton_MouseLeave);
            this.SNButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SNButton_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passave";
            this.BorderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicensesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomebankingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.PictureBox OtherButton;
        private System.Windows.Forms.PictureBox LicensesButton;
        private System.Windows.Forms.PictureBox HomebankingButton;
        private System.Windows.Forms.PictureBox EmailButton;
        private System.Windows.Forms.PictureBox SNButton;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox SearchButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField SearchTextBox;
        private System.Windows.Forms.PictureBox SaveButton;
        private System.Windows.Forms.PictureBox OpenButton;
        private System.Windows.Forms.PictureBox NewButton;
    }
}

