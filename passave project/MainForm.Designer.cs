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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("kek");
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.OtherButton = new System.Windows.Forms.PictureBox();
            this.LicensesButton = new System.Windows.Forms.PictureBox();
            this.HomebankingButton = new System.Windows.Forms.PictureBox();
            this.EmailButton = new System.Windows.Forms.PictureBox();
            this.SNButton = new System.Windows.Forms.PictureBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicensesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomebankingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SNButton)).BeginInit();
            this.SuspendLayout();
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
            this.OtherButton.Location = new System.Drawing.Point(29, 289);
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
            this.LicensesButton.Location = new System.Drawing.Point(29, 233);
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
            this.HomebankingButton.Location = new System.Drawing.Point(29, 177);
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
            this.EmailButton.Location = new System.Drawing.Point(29, 121);
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
            this.SNButton.Location = new System.Drawing.Point(29, 65);
            this.SNButton.Name = "SNButton";
            this.SNButton.Size = new System.Drawing.Size(220, 50);
            this.SNButton.TabIndex = 0;
            this.SNButton.TabStop = false;
            this.SNButton.MouseLeave += new System.EventHandler(this.SNButton_MouseLeave);
            this.SNButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SNButton_MouseMove);
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
            listViewItem1});
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            //this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passave";
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
    }
}

