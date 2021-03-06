﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

using MaterialSkin.Controls;

using Passave.Cryptography;
using Passave.International;


namespace Passave
{
    public partial class MainForm : Form
    {
        #region Fields
        List<Entry> socialNetworkList = new List<Entry>();
        List<Entry> emailList = new List<Entry>();
        List<BankEntry> homebankingList = new List<BankEntry>();
        List<LicenseEntry> licensesList = new List<LicenseEntry>();
        List<Entry> otherList = new List<Entry>();

        Passave.Cryptography.AES aes;

        public static bool isSNShow = true, isEmailShow = false, isHomebankingShow = false, isLicensesShow = false, isOtherShow = false, isSecureKey = false, havePassword = false;

        public static int changes = 0;

        public static Theme theme = Theme.Desert;

        string fn = "";

        public static string password;

        string SaveChangesMB, AttentionHMB, ErrorHMB, UnknownErrorMB, WrongPasswordMB;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();

            SetLanguage();

            if (SettingsForm.language == Language.English)
            {
                SNButton.Image = Properties.Resources.sn_button_activated;
                EmailButton.Image = Properties.Resources.email_button_default;
                HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                LicensesButton.Image = Properties.Resources.licenses_button_default;
                OtherButton.Image = Properties.Resources.other_button_default;
            }

            if (SettingsForm.language == Language.Russian)
            {
                SNButton.Image = Properties.Resources.rus_sn_button_activated;
                EmailButton.Image = Properties.Resources.rus_email_button_default;
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                OtherButton.Image = Properties.Resources.rus_other_button_default;
            }

            SNListView.Show();
            EmailListView.Hide();
            HomebankingListView.Hide();
            LicensesListView.Hide();
            OtherListView.Hide();
        }

        public MainForm(string caller) : base()
        {
            fn = caller;
        }
        #endregion

        #region GUI

        #region FORM SHADOW
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        #endregion

        private void SNButton_MouseLeave(object sender, EventArgs e)
        {
            if (SettingsForm.language == Language.English)
                if (!isSNShow)
                    SNButton.Image = Properties.Resources.sn_button_default;

            if (SettingsForm.language == Language.Russian)
                if (!isSNShow)
                    SNButton.Image = Properties.Resources.rus_sn_button_default;
        }

        private void SNButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (SettingsForm.language == Language.English)
                SNButton.Image = Properties.Resources.sn_button_activated;
            if (SettingsForm.language == Language.Russian)
                SNButton.Image = Properties.Resources.rus_sn_button_activated;
        }

        private void EmailButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (SettingsForm.language == Language.English)
                EmailButton.Image = Properties.Resources.email_button_activated;
            if (SettingsForm.language == Language.Russian)
                EmailButton.Image = Properties.Resources.rus_email_button_activated;
        }

        private void EmailButton_MouseLeave(object sender, EventArgs e)
        {
            if (SettingsForm.language == Language.English)
                if (!isEmailShow)
                    EmailButton.Image = Properties.Resources.email_button_default;

            if (SettingsForm.language == Language.Russian)
                if (!isEmailShow)
                    EmailButton.Image = Properties.Resources.rus_email_button_default;
        }

        private void HomebankingButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (SettingsForm.language == Language.English)
                HomebankingButton.Image = Properties.Resources.homebanking_button_activated;
            if (SettingsForm.language == Language.Russian)
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_activated;
        }

        private void HomebankingButton_MouseLeave(object sender, EventArgs e)
        {
            if (SettingsForm.language == Language.English)
                if (!isHomebankingShow)
                    HomebankingButton.Image = Properties.Resources.homebanking_button_default;

            if (SettingsForm.language == Language.Russian)
                if (!isHomebankingShow)
                    HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
        }

        private void LicensesButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (SettingsForm.language == Language.English)
                LicensesButton.Image = Properties.Resources.licenses_button_activated;
            if (SettingsForm.language == Language.Russian)
                LicensesButton.Image = Properties.Resources.rus_licenses_button_activated;
        }

        private void LicensesButton_MouseLeave(object sender, EventArgs e)
        {
            if (SettingsForm.language == Language.English)
                if (!isLicensesShow)
                    LicensesButton.Image = Properties.Resources.licenses_button_default;

            if (SettingsForm.language == Language.Russian)
                if (!isLicensesShow)
                    LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
        }

        private void OtherButton_MouseLeave(object sender, EventArgs e)
        {
            if (SettingsForm.language == Language.English)
                if (!isOtherShow)
                    OtherButton.Image = Properties.Resources.other_button_default;

            if (SettingsForm.language == Language.Russian)
                if (!isOtherShow)
                    OtherButton.Image = Properties.Resources.rus_other_button_default;
        }

        private void OtherButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (SettingsForm.language == Language.English)
                OtherButton.Image = Properties.Resources.other_button_activated;
            if (SettingsForm.language == Language.Russian)
                OtherButton.Image = Properties.Resources.rus_other_button_activated;
        }

        private void SettingsButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (SettingsForm.language == Language.English)
                SettingsButton.Image = Properties.Resources.settings_button_activated;
            if (SettingsForm.language == Language.Russian)
                SettingsButton.Image = Properties.Resources.rus_settings_button_activated;
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            if (SettingsForm.language == Language.English)
                SettingsButton.Image = Properties.Resources.settings_button_default;

            if (SettingsForm.language == Language.Russian)
                SettingsButton.Image = Properties.Resources.rus_settings_button_default;
        }

        private void BorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            BorderPanel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_activated;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_default;
        }

        private void MinimizeButton_MouseMove(object sender, MouseEventArgs e)
        {
            MinimizeButton.Image = Properties.Resources.minimize_button_activated;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.Image = Properties.Resources.minimize_button_default;
        }

        private void SaveButton_MouseMove(object sender, MouseEventArgs e)
        {
            SaveButton.Image = Properties.Resources.save_button_activated;
        }

        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            SaveButton.Image = Properties.Resources.save_button_default;
        }

        private void OpenButton_MouseMove(object sender, MouseEventArgs e)
        {
            OpenButton.Image = Properties.Resources.open_button_activated;
        }

        private void OpenButton_MouseLeave(object sender, EventArgs e)
        {
            OpenButton.Image = Properties.Resources.open_button_default;
        }

        private void NewButton_MouseMove(object sender, MouseEventArgs e)
        {
            NewButton.Image = Properties.Resources.new_button_activated;
        }

        private void NewButton_MouseLeave(object sender, EventArgs e)
        {
            NewButton.Image = Properties.Resources.new_button_default;
        }

        private void SNButton_Click(object sender, EventArgs e)
        {
            isSNShow = true;
            isEmailShow = false;
            isHomebankingShow = false;
            isLicensesShow = false;
            isOtherShow = false;

            if (SettingsForm.language == Language.English)
            {
                SNButton.Image = Properties.Resources.sn_button_activated;
                EmailButton.Image = Properties.Resources.email_button_default;
                HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                LicensesButton.Image = Properties.Resources.licenses_button_default;
                OtherButton.Image = Properties.Resources.other_button_default;
            }

            if (SettingsForm.language == Language.Russian)
            {
                SNButton.Image = Properties.Resources.rus_sn_button_activated;
                EmailButton.Image = Properties.Resources.rus_email_button_default;
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                OtherButton.Image = Properties.Resources.rus_other_button_default;
            }

            SNListView.Show();
            EmailListView.Hide();
            HomebankingListView.Hide();
            LicensesListView.Hide();
            OtherListView.Hide();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            isSNShow = false;
            isEmailShow = true;
            isHomebankingShow = false;
            isLicensesShow = false;
            isOtherShow = false;

            if (SettingsForm.language == Language.English)
            {
                SNButton.Image = Properties.Resources.sn_button_default;
                EmailButton.Image = Properties.Resources.email_button_activated;
                HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                LicensesButton.Image = Properties.Resources.licenses_button_default;
                OtherButton.Image = Properties.Resources.other_button_default;
            }

            if (SettingsForm.language == Language.Russian)
            {
                SNButton.Image = Properties.Resources.rus_sn_button_default;
                EmailButton.Image = Properties.Resources.rus_email_button_activated;
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                OtherButton.Image = Properties.Resources.rus_other_button_default;
            }

            SNListView.Hide();
            EmailListView.Show();
            HomebankingListView.Hide();
            LicensesListView.Hide();
            OtherListView.Hide();
        }

        private void HomebankingButton_Click(object sender, EventArgs e)
        {
            isSNShow = false;
            isEmailShow = false;
            isHomebankingShow = true;
            isLicensesShow = false;
            isOtherShow = false;

            if (SettingsForm.language == Language.English)
            {
                SNButton.Image = Properties.Resources.sn_button_default;
                EmailButton.Image = Properties.Resources.email_button_default;
                HomebankingButton.Image = Properties.Resources.homebanking_button_activated;
                LicensesButton.Image = Properties.Resources.licenses_button_default;
                OtherButton.Image = Properties.Resources.other_button_default;
            }

            if (SettingsForm.language == Language.Russian)
            {
                SNButton.Image = Properties.Resources.rus_sn_button_default;
                EmailButton.Image = Properties.Resources.rus_email_button_default;
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_activated;
                LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                OtherButton.Image = Properties.Resources.rus_other_button_default;
            }

            SNListView.Hide();
            EmailListView.Hide();
            HomebankingListView.Show();
            LicensesListView.Hide();
            OtherListView.Hide();
        }

        private void LicensesButton_Click(object sender, EventArgs e)
        {
            isSNShow = false;
            isEmailShow = false;
            isHomebankingShow = false;
            isLicensesShow = true;
            isOtherShow = false;

            if (SettingsForm.language == Language.English)
            {
                SNButton.Image = Properties.Resources.sn_button_default;
                EmailButton.Image = Properties.Resources.email_button_default;
                HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                LicensesButton.Image = Properties.Resources.licenses_button_activated;
                OtherButton.Image = Properties.Resources.other_button_default;
            }

            if (SettingsForm.language == Language.Russian)
            {
                SNButton.Image = Properties.Resources.rus_sn_button_default;
                EmailButton.Image = Properties.Resources.rus_email_button_default;
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                LicensesButton.Image = Properties.Resources.rus_licenses_button_activated;
                OtherButton.Image = Properties.Resources.rus_other_button_default;
            }

            SNListView.Hide();
            EmailListView.Hide();
            HomebankingListView.Hide();
            LicensesListView.Show();
            OtherListView.Hide();
        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            isSNShow = false;
            isEmailShow = false;
            isHomebankingShow = false;
            isLicensesShow = false;
            isOtherShow = true;

            if (SettingsForm.language == Language.English)
            {
                SNButton.Image = Properties.Resources.sn_button_default;
                EmailButton.Image = Properties.Resources.email_button_default;
                HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                LicensesButton.Image = Properties.Resources.licenses_button_default;
                OtherButton.Image = Properties.Resources.other_button_activated;
            }

            if (SettingsForm.language == Language.Russian)
            {
                SNButton.Image = Properties.Resources.rus_sn_button_default;
                EmailButton.Image = Properties.Resources.rus_email_button_default;
                HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                OtherButton.Image = Properties.Resources.rus_other_button_activated;
            }

            SNListView.Hide();
            EmailListView.Hide();
            HomebankingListView.Hide();
            LicensesListView.Hide();
            OtherListView.Show();
        }

        #endregion

        #region UI handling

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (fn != "") Open(fn);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes != 0)
            {
                NewMessageBox messageBox = new NewMessageBox(SaveChangesMB, AttentionHMB, MessageBoxButtons.YesNoCancel);
                DialogResult dr = messageBox.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    Save();
                    e.Cancel = false;
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            SetLanguage();
        }


        private void OtherListView_MouseMove(object sender, MouseEventArgs e)
        {
            var selected = new MaterialListView.SelectedListViewItemCollection(OtherListView);

            if (selected.Count == 0)
            {
                EditEntryButton.Enabled = false;
                DeleteEntryButton.Enabled = false;
                CopyLoginButton.Enabled = false;
                CopyPasswordButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count == 1)
            {
                EditEntryButton.Enabled = true;
                DeleteEntryButton.Enabled = true;
                CopyLoginButton.Enabled = true;
                CopyPasswordButton.Enabled = true;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count > 1)
            {
                EditEntryButton.Enabled = false;
                DeleteEntryButton.Enabled = true;
                CopyLoginButton.Enabled = false;
                CopyPasswordButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntriesCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntriesCM;
            }
        }

        private void LicensesListView_MouseMove(object sender, MouseEventArgs e)
        {
            var selected = new MaterialListView.SelectedListViewItemCollection(LicensesListView);

            if (selected.Count == 0)
            {
                EditLicenseButton.Enabled = false;
                DeleteLicenseButton.Enabled = false;
                CopyKeyButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteLicenseButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteLicenseButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count == 1)
            {
                EditLicenseButton.Enabled = true;
                DeleteLicenseButton.Enabled = true;
                CopyKeyButton.Enabled = true;

                if (SettingsForm.language == Language.English)
                    DeleteLicenseButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteLicenseButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count > 1)
            {
                EditLicenseButton.Enabled = false;
                DeleteLicenseButton.Enabled = true;
                CopyKeyButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteLicenseButton.Text = Eng.DeleteEntriesCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteLicenseButton.Text = Rus.DeleteEntriesCM;
            }
        }

        private void HomebankingListView_MouseMove(object sender, MouseEventArgs e)
        {
            var selected = new MaterialListView.SelectedListViewItemCollection(HomebankingListView);

            if (selected.Count == 0)
            {
                EditCardButton.Enabled = false;
                DeleteCardButton.Enabled = false;
                CopyCardButton.Enabled = false;
                CopyCVCButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteCardButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteCardButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count == 1)
            {
                EditCardButton.Enabled = true;
                DeleteCardButton.Enabled = true;
                CopyCardButton.Enabled = true;
                CopyCVCButton.Enabled = true;

                if (SettingsForm.language == Language.English)
                    DeleteCardButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteCardButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count > 1)
            {
                EditCardButton.Enabled = false;
                DeleteCardButton.Enabled = true;
                CopyCardButton.Enabled = false;
                CopyCVCButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteCardButton.Text = Eng.DeleteEntriesCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteCardButton.Text = Rus.DeleteEntriesCM;
            }
        }

        private void EmailListView_MouseMove(object sender, MouseEventArgs e)
        {
            var selected = new MaterialListView.SelectedListViewItemCollection(EmailListView);

            if (selected.Count == 0)
            {
                EditEntryButton.Enabled = false;
                DeleteEntryButton.Enabled = false;
                CopyLoginButton.Enabled = false;
                CopyPasswordButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count == 1)
            {
                EditEntryButton.Enabled = true;
                DeleteEntryButton.Enabled = true;
                CopyLoginButton.Enabled = true;
                CopyPasswordButton.Enabled = true;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count > 1)
            {
                EditEntryButton.Enabled = false;
                DeleteEntryButton.Enabled = true;
                CopyLoginButton.Enabled = false;
                CopyPasswordButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntriesCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntriesCM;
            }
        }

        private void SNListView_MouseMove(object sender, MouseEventArgs e)
        {
            var selected = new MaterialListView.SelectedListViewItemCollection(SNListView);

            if (selected.Count == 0)
            {
                EditEntryButton.Enabled = false;
                DeleteEntryButton.Enabled = false;
                CopyLoginButton.Enabled = false;
                CopyPasswordButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count == 1)
            {
                EditEntryButton.Enabled = true;
                DeleteEntryButton.Enabled = true;
                CopyLoginButton.Enabled = true;
                CopyPasswordButton.Enabled = true;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntryCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntryCM;
            }

            if (selected.Count > 1)
            {
                EditEntryButton.Enabled = false;
                DeleteEntryButton.Enabled = true;
                CopyLoginButton.Enabled = false;
                CopyPasswordButton.Enabled = false;

                if (SettingsForm.language == Language.English)
                    DeleteEntryButton.Text = Eng.DeleteEntriesCM;

                if (SettingsForm.language == Language.Russian)
                    DeleteEntryButton.Text = Rus.DeleteEntriesCM;
            }
        }


        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Add);
            if (form.ShowDialog() == DialogResult.OK)
                Add();
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Add);
            if (form.ShowDialog() == DialogResult.OK)
                Add();
        }

        private void AddLicenseButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Add);
            if (form.ShowDialog() == DialogResult.OK)
                Add();
        }


        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void EditLicenseButton_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void EditCardButton_Click(object sender, EventArgs e)
        {
            Edit();
        }


        private void DeleteLicenseButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void CopyLoginButton_Click(object sender, EventArgs e)
        {
            if (isSNShow)
            {
                int i = SNListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, socialNetworkList[i].Login);
            }

            if (isEmailShow)
            {
                int i = EmailListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, emailList[i].Login);
            }

            if (isOtherShow)
            {
                int i = OtherListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, otherList[i].Login);
            }
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            if (isSNShow)
            {
                int i = SNListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, socialNetworkList[i].Password);
            }

            if (isEmailShow)
            {
                int i = EmailListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, emailList[i].Password);
            }

            if (isOtherShow)
            {
                int i = OtherListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, otherList[i].Password);
            }
        }

        private void CopyKeyButton_Click(object sender, EventArgs e)
        {
            if (isLicensesShow)
            {
                int i = LicensesListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, licensesList[i].Key);
            }
        }

        private void CopyCardButton_Click(object sender, EventArgs e)
        {
            if (isHomebankingShow)
            {
                int i = HomebankingListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, homebankingList[i].CardNumber);
            }
        }

        private void CopyCVCButton_Click(object sender, EventArgs e)
        {
            if (isHomebankingShow)
            {
                int i = HomebankingListView.SelectedIndices[0];
                Clipboard.SetData(DataFormats.StringFormat, homebankingList[i].CVC);
            }
        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            if (changes != 0)
            {
                NewMessageBox messageBox = new NewMessageBox(SaveChangesMB, AttentionHMB, MessageBoxButtons.YesNoCancel);
                DialogResult dr = messageBox.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    Save();
                    New();
                }
                else if (dr == DialogResult.No)
                {
                    New();
                }
            }
            else New();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (changes != 0)
            {
                NewMessageBox messageBox = new NewMessageBox(SaveChangesMB, AttentionHMB, MessageBoxButtons.YesNoCancel);
                DialogResult dr = messageBox.ShowDialog();

                if (dr == DialogResult.Yes)
                {
                    Save();
                    OpenFromFile();
                }
                else if (dr == DialogResult.No)
                {
                    OpenFromFile();
                }
            }
            else OpenFromFile();
        }


        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                if (theme == Theme.Forest)
                    MenuPanel.BackgroundImage = Properties.Resources.menuimage_forest;
                if (theme == Theme.Desert)
                    MenuPanel.BackgroundImage = Properties.Resources.menuimage_desert;
                if (theme == Theme.Mountains)
                    MenuPanel.BackgroundImage = Properties.Resources.menuimage_mountains;
                if (theme == Theme.City)
                    MenuPanel.BackgroundImage = Properties.Resources.menuimage_city;
                if (theme == Theme.Sunset)
                    MenuPanel.BackgroundImage = Properties.Resources.menuimage_sunset;

                SetLanguage();
            }
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        #endregion

        #region Actions w/ entries & database
        /// <summary>
        /// Add entry
        /// </summary>
        private void Add()
        {
            try
            {
                if (isSNShow || isEmailShow || isOtherShow)
                {
                    if (isSNShow)
                        socialNetworkList.Add(AddEditForm.addEntry);
                    if (isEmailShow)
                        emailList.Add(AddEditForm.addEntry);
                    if (isOtherShow)
                        otherList.Add(AddEditForm.addEntry);

                    ListViewItem listViewItem = new ListViewItem(AddEditForm.addEntry.Name);
                    listViewItem.SubItems.Add(AddEditForm.addEntry.Login);
                    listViewItem.SubItems.Add("••••••••••");
                    listViewItem.SubItems.Add(AddEditForm.addEntry.Phone);
                    listViewItem.SubItems.Add(AddEditForm.addEntry.URL);
                    listViewItem.SubItems.Add(AddEditForm.addEntry.Notes);

                    if (isSNShow)
                        SNListView.Items.Add(listViewItem);
                    if (isEmailShow)
                        EmailListView.Items.Add(listViewItem);
                    if (isOtherShow)
                        OtherListView.Items.Add(listViewItem);

                    changes++;
                }

                if (isHomebankingShow)
                {
                    homebankingList.Add(AddEditForm.addHomebankingEntry);

                    ListViewItem listViewItem = new ListViewItem(AddEditForm.addHomebankingEntry.Name);
                    listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.CardNumber);
                    listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.Date);
                    listViewItem.SubItems.Add("•••");
                    listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.Phone);
                    listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.Notes);

                    HomebankingListView.Items.Add(listViewItem);
                    changes++;
                }

                if (isLicensesShow)
                {
                    licensesList.Add(AddEditForm.addLicenseEntry);

                    ListViewItem listViewItem = new ListViewItem(AddEditForm.addLicenseEntry.Name);
                    listViewItem.SubItems.Add(AddEditForm.addLicenseEntry.Key);
                    listViewItem.SubItems.Add(AddEditForm.addLicenseEntry.Notes);

                    LicensesListView.Items.Add(listViewItem);
                    changes++;
                }
            }
            catch (Exception e)
            {
                NewMessageBox messageBox = new NewMessageBox(UnknownErrorMB + e.Message, ErrorHMB);
                messageBox.ShowDialog();
            }
        }

        /// <summary>
        /// Edit entry
        /// </summary>
        private void Edit()
        {
            try
            {
                if (isSNShow)
                {
                    AddEditForm form = new AddEditForm(Mode.Edit);

                    int i = SNListView.SelectedIndices[0];

                    AddEditForm.addEntry.Name = socialNetworkList[i].Name;
                    AddEditForm.addEntry.Login = socialNetworkList[i].Login;
                    AddEditForm.addEntry.Password = socialNetworkList[i].Password;
                    AddEditForm.addEntry.Phone = socialNetworkList[i].Phone;
                    AddEditForm.addEntry.URL = socialNetworkList[i].URL;
                    AddEditForm.addEntry.Notes = socialNetworkList[i].Notes;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        socialNetworkList[i].Name = AddEditForm.addEntry.Name;
                        socialNetworkList[i].Login = AddEditForm.addEntry.Login;
                        socialNetworkList[i].Password = AddEditForm.addEntry.Password;
                        socialNetworkList[i].Phone = AddEditForm.addEntry.Phone;
                        socialNetworkList[i].URL = AddEditForm.addEntry.URL;
                        socialNetworkList[i].Notes = AddEditForm.addEntry.Notes;

                        ListViewItem lvi = new ListViewItem(AddEditForm.addEntry.Name);
                        lvi.SubItems.Add(AddEditForm.addEntry.Login);
                        lvi.SubItems.Add("••••••••••");
                        lvi.SubItems.Add(AddEditForm.addEntry.Phone);
                        lvi.SubItems.Add(AddEditForm.addEntry.URL);
                        lvi.SubItems.Add(AddEditForm.addEntry.Notes);

                        SNListView.Items.RemoveAt(i);
                        SNListView.Items.Insert(i, lvi);

                        changes++;
                    }
                }

                if (isEmailShow)
                {
                    AddEditForm form = new AddEditForm(Mode.Edit);

                    int i = EmailListView.SelectedIndices[0];

                    AddEditForm.addEntry.Name = emailList[i].Name;
                    AddEditForm.addEntry.Login = emailList[i].Login;
                    AddEditForm.addEntry.Password = emailList[i].Password;
                    AddEditForm.addEntry.Phone = emailList[i].Phone;
                    AddEditForm.addEntry.URL = emailList[i].URL;
                    AddEditForm.addEntry.Notes = emailList[i].Notes;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        emailList[i].Name = AddEditForm.addEntry.Name;
                        emailList[i].Login = AddEditForm.addEntry.Login;
                        emailList[i].Password = AddEditForm.addEntry.Password;
                        emailList[i].Phone = AddEditForm.addEntry.Phone;
                        emailList[i].URL = AddEditForm.addEntry.URL;
                        emailList[i].Notes = AddEditForm.addEntry.Notes;

                        ListViewItem lvi = new ListViewItem(AddEditForm.addEntry.Name);
                        lvi.SubItems.Add(AddEditForm.addEntry.Login);
                        lvi.SubItems.Add("••••••••••");
                        lvi.SubItems.Add(AddEditForm.addEntry.Phone);
                        lvi.SubItems.Add(AddEditForm.addEntry.URL);
                        lvi.SubItems.Add(AddEditForm.addEntry.Notes);

                        EmailListView.Items.RemoveAt(i);
                        EmailListView.Items.Insert(i, lvi);

                        changes++;
                    }
                }

                if (isOtherShow)
                {
                    AddEditForm form = new AddEditForm(Mode.Edit);

                    int i = OtherListView.SelectedIndices[0];

                    AddEditForm.addEntry.Name = otherList[i].Name;
                    AddEditForm.addEntry.Login = otherList[i].Login;
                    AddEditForm.addEntry.Password = otherList[i].Password;
                    AddEditForm.addEntry.Phone = otherList[i].Phone;
                    AddEditForm.addEntry.URL = otherList[i].URL;
                    AddEditForm.addEntry.Notes = otherList[i].Notes;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        otherList[i].Name = AddEditForm.addEntry.Name;
                        otherList[i].Login = AddEditForm.addEntry.Login;
                        otherList[i].Password = AddEditForm.addEntry.Password;
                        otherList[i].Phone = AddEditForm.addEntry.Phone;
                        otherList[i].URL = AddEditForm.addEntry.URL;
                        otherList[i].Notes = AddEditForm.addEntry.Notes;

                        ListViewItem lvi = new ListViewItem(AddEditForm.addEntry.Name);
                        lvi.SubItems.Add(AddEditForm.addEntry.Login);
                        lvi.SubItems.Add("••••••••••");
                        lvi.SubItems.Add(AddEditForm.addEntry.Phone);
                        lvi.SubItems.Add(AddEditForm.addEntry.URL);
                        lvi.SubItems.Add(AddEditForm.addEntry.Notes);

                        OtherListView.Items.RemoveAt(i);
                        OtherListView.Items.Insert(i, lvi);

                        changes++;
                    }
                }

                if (isHomebankingShow)
                {
                    AddEditForm form = new AddEditForm(Mode.Edit);

                    int i = HomebankingListView.SelectedIndices[0];

                    AddEditForm.addHomebankingEntry.Name = homebankingList[i].Name;
                    AddEditForm.addHomebankingEntry.CardNumber = homebankingList[i].CardNumber;
                    AddEditForm.addHomebankingEntry.Date = homebankingList[i].Date;
                    AddEditForm.addHomebankingEntry.CVC = homebankingList[i].CVC;
                    AddEditForm.addHomebankingEntry.Phone = homebankingList[i].Phone;
                    AddEditForm.addHomebankingEntry.Notes = homebankingList[i].Notes;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        homebankingList[i].Name = AddEditForm.addHomebankingEntry.Name;
                        homebankingList[i].CardNumber = AddEditForm.addHomebankingEntry.CardNumber;
                        homebankingList[i].Date = AddEditForm.addHomebankingEntry.Date;
                        homebankingList[i].CVC = AddEditForm.addHomebankingEntry.CVC;
                        homebankingList[i].Phone = AddEditForm.addHomebankingEntry.Phone;
                        homebankingList[i].Notes = AddEditForm.addHomebankingEntry.Notes;

                        ListViewItem lvi = new ListViewItem(AddEditForm.addHomebankingEntry.Name);
                        lvi.SubItems.Add(AddEditForm.addHomebankingEntry.CardNumber);
                        lvi.SubItems.Add(AddEditForm.addHomebankingEntry.Date);
                        lvi.SubItems.Add("•••");
                        lvi.SubItems.Add(AddEditForm.addHomebankingEntry.Phone);
                        lvi.SubItems.Add(AddEditForm.addHomebankingEntry.Notes);

                        HomebankingListView.Items.RemoveAt(i);
                        HomebankingListView.Items.Insert(i, lvi);

                        changes++;
                    }
                }

                if (isLicensesShow)
                {
                    AddEditForm form = new AddEditForm(Mode.Edit);

                    int i = LicensesListView.SelectedIndices[0];

                    AddEditForm.addLicenseEntry.Name = licensesList[i].Name;
                    AddEditForm.addLicenseEntry.Key = licensesList[i].Key;
                    AddEditForm.addLicenseEntry.Notes = licensesList[i].Notes;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        licensesList[i].Name = AddEditForm.addLicenseEntry.Name;
                        licensesList[i].Key = AddEditForm.addLicenseEntry.Key;
                        licensesList[i].Notes = AddEditForm.addLicenseEntry.Notes;

                        ListViewItem lvi = new ListViewItem(AddEditForm.addLicenseEntry.Name);
                        lvi.SubItems.Add(AddEditForm.addLicenseEntry.Key);
                        lvi.SubItems.Add(AddEditForm.addLicenseEntry.Notes);

                        LicensesListView.Items.RemoveAt(i);
                        LicensesListView.Items.Insert(i, lvi);

                        changes++;
                    }
                }
            }
            catch (Exception e)
            {
                NewMessageBox messageBox = new NewMessageBox(UnknownErrorMB + e.Message, ErrorHMB);
                messageBox.ShowDialog();
            }
        }

        /// <summary>
        /// Delete entry
        /// </summary>
        private void Delete()
        {
            try
            {
                if (isSNShow)
                {
                    var selected = new MaterialListView.SelectedListViewItemCollection(SNListView);

                    int i = 0, j = 0, selCount = selected.Count;
                    while (i != selCount)
                    {
                        if (selected[0].SubItems[0].Text != socialNetworkList[j].Name) { j++; continue; }
                        if (selected[0].SubItems[1].Text != socialNetworkList[j].Login) { j++; continue; }
                        if (selected[0].SubItems[3].Text != socialNetworkList[j].Phone) { j++; continue; }
                        if (selected[0].SubItems[4].Text != socialNetworkList[j].URL) { j++; continue; }
                        if (selected[0].SubItems[5].Text != socialNetworkList[j].Notes) { j++; continue; }

                        socialNetworkList.RemoveAt(j);
                        SNListView.Items.RemoveAt(j);
                        i++;
                    }
                }

                if (isEmailShow)
                {
                    var selected = new MaterialListView.SelectedListViewItemCollection(EmailListView);

                    int i = 0, j = 0, selCount = selected.Count;
                    while (i != selCount)
                    {
                        if (selected[0].SubItems[0].Text != emailList[j].Name) { j++; continue; }
                        if (selected[0].SubItems[1].Text != emailList[j].Login) { j++; continue; }
                        if (selected[0].SubItems[3].Text != emailList[j].Phone) { j++; continue; }
                        if (selected[0].SubItems[4].Text != emailList[j].URL) { j++; continue; }
                        if (selected[0].SubItems[5].Text != emailList[j].Notes) { j++; continue; }

                        emailList.RemoveAt(j);
                        EmailListView.Items.RemoveAt(j);
                        i++;
                    }
                }

                if (isOtherShow)
                {
                    var selected = new MaterialListView.SelectedListViewItemCollection(OtherListView);

                    int i = 0, j = 0, selCount = selected.Count;
                    while (i != selCount)
                    {
                        if (selected[0].SubItems[0].Text != otherList[j].Name) { j++; continue; }
                        if (selected[0].SubItems[1].Text != otherList[j].Login) { j++; continue; }
                        if (selected[0].SubItems[3].Text != otherList[j].Phone) { j++; continue; }
                        if (selected[0].SubItems[4].Text != otherList[j].URL) { j++; continue; }
                        if (selected[0].SubItems[5].Text != otherList[j].Notes) { j++; continue; }

                        otherList.RemoveAt(j);
                        OtherListView.Items.RemoveAt(j);
                        i++;
                    }
                }

                if (isHomebankingShow)
                {
                    var selected = new MaterialListView.SelectedListViewItemCollection(HomebankingListView);

                    int i = 0, j = 0, selCount = selected.Count;
                    while (i != selCount)
                    {
                        if (selected[0].SubItems[0].Text != homebankingList[j].Name) { j++; continue; }
                        if (selected[0].SubItems[1].Text != homebankingList[j].CardNumber) { j++; continue; }
                        if (selected[0].SubItems[2].Text != homebankingList[j].Date) { j++; continue; }
                        if (selected[0].SubItems[3].Text != homebankingList[j].CVC) { j++; continue; }
                        if (selected[0].SubItems[4].Text != homebankingList[j].Phone) { j++; continue; }
                        if (selected[0].SubItems[5].Text != homebankingList[j].Notes) { j++; continue; }

                        homebankingList.RemoveAt(j);
                        HomebankingListView.Items.RemoveAt(j);
                        i++;
                    }
                }

                if (isLicensesShow)
                {
                    var selected = new MaterialListView.SelectedListViewItemCollection(LicensesListView);

                    int i = 0, j = 0, selCount = selected.Count;
                    while (i != selCount)
                    {
                        if (selected[0].SubItems[0].Text != licensesList[j].Name) { j++; continue; }
                        if (selected[0].SubItems[1].Text != licensesList[j].Key) { j++; continue; }
                        if (selected[0].SubItems[2].Text != licensesList[j].Notes) { j++; continue; }

                        licensesList.RemoveAt(j);
                        LicensesListView.Items.RemoveAt(j);
                        i++;
                    }
                }

                changes++;
            }
            catch (Exception e)
            {
                NewMessageBox messageBox = new NewMessageBox(UnknownErrorMB + e.Message, ErrorHMB);
                messageBox.ShowDialog();
            }
        }

        /// <summary>
        /// Create new database
        /// </summary>
        private void New()
        {
            ClearAll();
        }

        /// <summary>
        /// Save database to file
        /// </summary>
        private void Save()
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Title = "Save database";
                    sfd.Filter = "Passave Database (*.psv)|*.psv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string saved = "";

                        if (SettingsForm.language == Language.English)
                            saved += "ENGLISH\n";
                        if (SettingsForm.language == Language.Russian)
                            saved += "RUSSIAN\n";

                        if (theme == Theme.Forest)
                            saved += "FOREST\n";
                        if (theme == Theme.Desert)
                            saved += "DESERT\n";
                        if (theme == Theme.Mountains)
                            saved += "MOUNTAINS\n";
                        if (theme == Theme.City)
                            saved += "CITY\n";
                        if (theme == Theme.Sunset)
                            saved += "SUNSET\n";

                        saved += "SOCIAL_NETWORK\n";
                        foreach (Entry item in socialNetworkList)
                        {
                            saved += item.Name + '\n';
                            saved += item.Login + '\n';
                            saved += item.Password + '\n';
                            saved += item.Phone + '\n';
                            saved += item.URL + '\n';
                            saved += item.Notes + '\n';
                        }

                        saved += "EMAIL\n";
                        foreach (Entry item in emailList)
                        {
                            saved += item.Name + '\n';
                            saved += item.Login + '\n';
                            saved += item.Password + '\n';
                            saved += item.Phone + '\n';
                            saved += item.URL + '\n';
                            saved += item.Notes + '\n';
                        }

                        saved += "HOMEBANKING\n";
                        foreach (BankEntry item in homebankingList)
                        {
                            saved += item.Name + '\n';
                            saved += item.CardNumber + '\n';
                            saved += item.Date + '\n';
                            saved += item.CVC + '\n';
                            saved += item.Phone + '\n';
                            saved += item.Notes + '\n';
                        }

                        saved += "LICENSES\n";
                        foreach (LicenseEntry item in licensesList)
                        {
                            saved += item.Name + '\n';
                            saved += item.Key + '\n';
                            saved += item.Notes + '\n';
                        }

                        saved += "OTHER\n";
                        foreach (Entry item in otherList)
                        {
                            saved += item.Name + '\n';
                            saved += item.Login + '\n';
                            saved += item.Password + '\n';
                            saved += item.Phone + '\n';
                            saved += item.URL + '\n';
                            saved += item.Notes + '\n';
                        }

                        bool isEncrypted = false;
                        byte[] encrypted = new byte[16];

                        if (!havePassword)
                        {
                            PasswordForm form = new PasswordForm();
                            string hash;
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                using (MD5 md5hash = MD5.Create())
                                {
                                    hash = GetMD5Hash(md5hash, password);
                                    byte[,] key = StringToByteBlock(hash);
                                    aes = new AES(key);
                                    encrypted = AES.Encrypt(saved);
                                    havePassword = true;
                                    isEncrypted = true;
                                }
                            }
                        }
                        else
                        {
                            string hash;
                            using (MD5 md5hash = MD5.Create())
                            {
                                hash = GetMD5Hash(md5hash, password);
                                byte[,] key = StringToByteBlock(hash);
                                aes = new AES(key);
                                encrypted = AES.Encrypt(saved);
                                havePassword = true;
                                isEncrypted = true;
                            }
                        }

                        if (isEncrypted)
                        {
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                for (int i = 0; i < encrypted.Length; i++)
                                {
                                    if (i != encrypted.Length - 1) sw.Write(Convert.ToString(encrypted[i], 16) + ' ');
                                    else sw.Write(Convert.ToString(encrypted[i], 16));
                                }
                            }
                        }
                    }
                }
                changes = 0;
            }
            catch (Exception e)
            {
                NewMessageBox messageBox = new NewMessageBox(UnknownErrorMB + e.Message, ErrorHMB);
                messageBox.ShowDialog();
            }
        }

        /// <summary>
        /// Open database from file
        /// </summary>
        private void OpenFromFile()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Save database";
                    ofd.Filter = "Passave Database (*.psv)|*.psv";

                    if (ofd.ShowDialog() == DialogResult.OK)
                        Open(ofd.FileName);
                }
            }
            catch (Exception e)
            {
                NewMessageBox messageBox = new NewMessageBox("Unknown error: " + e.Message, "ERROR");
                messageBox.ShowDialog();
            }
        }

        /// <summary>
        /// Open database from system
        /// </summary>
        /// <param name="file"></param>
        private void Open(string file)
        {
            string rd = "";
            bool isDecrypted = false;
            string decrypted = "";
            using (StreamReader sr = new StreamReader(file))
            {
                PasswordForm form = new PasswordForm();
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    using (MD5 md5hash = MD5.Create())
                    {
                        rd = sr.ReadLine();
                        string[] temp = rd.Split();
                        byte[] rdb = new byte[temp.Length];
                        for (int i = 0; i < temp.Length; i++)
                            rdb[i] = Convert.ToByte(temp[i], 16);

                        string hash = GetMD5Hash(md5hash, password);
                        byte[,] key = StringToByteBlock(hash);
                        aes = new AES(key);

                        decrypted = AES.Decrypt(rdb);
                        isDecrypted = true;
                    }
                }
                else if (dr == DialogResult.Yes)
                {
                    rd = sr.ReadLine();
                    string[] temp = rd.Split();
                    byte[] rdb = new byte[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                        rdb[i] = Convert.ToByte(temp[i], 16);

                    aes = new AES(PasswordForm.secureKey);
                    decrypted = AES.Decrypt(rdb);
                    isDecrypted = true;
                }
            }

            if (isDecrypted)
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.Write(decrypted);
                }

                using (StreamReader sr = new StreamReader(file))
                {
                    havePassword = true;
                    try
                    {
                        Entry tempEntry = new Entry();
                        BankEntry tempBankEntry = new BankEntry();
                        LicenseEntry tempLicenseEntry = new LicenseEntry();

                        bool isFirst = true;
                        string readed = sr.ReadLine();
                        if (readed != "ENGLISH" && readed != "RUSSIAN")
                        {
                            NewMessageBox messageBox = new NewMessageBox(WrongPasswordMB, ErrorHMB, MessageBoxButtons.OK);
                            messageBox.ShowDialog();
                            ClearAll();
                        }
                        else
                        {
                            if (readed == "ENGLISH")
                                SettingsForm.language = Language.English;
                            if (readed == "RUSSIAN")
                                SettingsForm.language = Language.Russian;

                            readed = sr.ReadLine();

                            if (readed == "FOREST")
                            {
                                theme = Theme.Forest;
                                MenuPanel.BackgroundImage = Properties.Resources.menuimage_forest;
                            }
                            if (readed == "DESERT")
                            {
                                theme = Theme.Desert;
                                MenuPanel.BackgroundImage = Properties.Resources.menuimage_desert;
                            }
                            if (readed == "MOUNTAINS")
                            {
                                theme = Theme.Mountains;
                                MenuPanel.BackgroundImage = Properties.Resources.menuimage_mountains;
                            }
                            if (readed == "CITY")
                            {
                                theme = Theme.City;
                                MenuPanel.BackgroundImage = Properties.Resources.menuimage_city;
                            }
                            if (readed == "SUNSET")
                            {
                                theme = Theme.Sunset;
                                MenuPanel.BackgroundImage = Properties.Resources.menuimage_sunset;
                            }

                            readed = sr.ReadLine();
                            while (readed != "EMAIL")
                            {
                                if (isFirst) readed = sr.ReadLine();
                                if (readed == "EMAIL") break;
                                tempEntry.Name = readed;

                                readed = sr.ReadLine();
                                tempEntry.Login = readed;

                                readed = sr.ReadLine();
                                tempEntry.Password = readed;

                                readed = sr.ReadLine();
                                tempEntry.Phone = readed;

                                readed = sr.ReadLine();
                                tempEntry.URL = readed;

                                readed = sr.ReadLine();
                                tempEntry.Notes = readed;

                                socialNetworkList.Add(tempEntry);
                                readed = sr.ReadLine();
                                isFirst = false;
                                tempEntry = new Entry();
                            }

                            isFirst = true;
                            while (readed != "HOMEBANKING")
                            {
                                if (isFirst) readed = sr.ReadLine();
                                if (readed == "HOMEBANKING") break;
                                tempEntry.Name = readed;

                                readed = sr.ReadLine();
                                tempEntry.Login = readed;

                                readed = sr.ReadLine();
                                tempEntry.Password = readed;

                                readed = sr.ReadLine();
                                tempEntry.Phone = readed;

                                readed = sr.ReadLine();
                                tempEntry.URL = readed;

                                readed = sr.ReadLine();
                                tempEntry.Notes = readed;

                                emailList.Add(tempEntry);
                                readed = sr.ReadLine();
                                isFirst = false;
                                tempEntry = new Entry();
                            }

                            isFirst = true;
                            while (readed != "LICENSES")
                            {
                                if (isFirst) readed = sr.ReadLine();
                                if (readed == "LICENSES") break;
                                tempBankEntry.Name = readed;

                                readed = sr.ReadLine();
                                tempBankEntry.CardNumber = readed;

                                readed = sr.ReadLine();
                                tempBankEntry.Date = readed;

                                readed = sr.ReadLine();
                                tempBankEntry.CVC = readed;

                                readed = sr.ReadLine();
                                tempBankEntry.Phone = readed;

                                readed = sr.ReadLine();
                                tempBankEntry.Notes = readed;

                                homebankingList.Add(tempBankEntry);
                                readed = sr.ReadLine();
                                isFirst = false;
                                tempBankEntry = new BankEntry();
                            }

                            isFirst = true;
                            while (readed != "OTHER")
                            {
                                if (isFirst) readed = sr.ReadLine();
                                if (readed == "OTHER") break;
                                tempLicenseEntry.Name = readed;

                                readed = sr.ReadLine();
                                tempLicenseEntry.Key = readed;

                                readed = sr.ReadLine();
                                tempLicenseEntry.Notes = readed;

                                licensesList.Add(tempLicenseEntry);
                                readed = sr.ReadLine();
                                isFirst = false;
                                tempLicenseEntry = new LicenseEntry();
                            }

                            isFirst = true;
                            while (!sr.EndOfStream)
                            {
                                if (isFirst) readed = sr.ReadLine();
                                tempEntry.Name = readed;

                                readed = sr.ReadLine();
                                tempEntry.Login = readed;

                                readed = sr.ReadLine();
                                tempEntry.Password = readed;

                                readed = sr.ReadLine();
                                tempEntry.Phone = readed;

                                readed = sr.ReadLine();
                                tempEntry.URL = readed;

                                readed = sr.ReadLine();
                                tempEntry.Notes = readed;

                                otherList.Add(tempEntry);
                                readed = sr.ReadLine();
                                isFirst = false;
                                tempEntry = new Entry();
                            }

                            FullListView();
                            SetLanguage();
                        }
                    }
                    catch (Exception ex)
                    {
                        NewMessageBox messageBox = new NewMessageBox(UnknownErrorMB + ex.Message, ErrorHMB);
                        messageBox.ShowDialog();
                        ClearAll();
                    }
                }

                using (StreamWriter sw = new StreamWriter(file))
                {
                    sw.Write(rd);
                }
            }
        }

        /// <summary>
        /// Search entry. Searched string - SearchTextBox.Text
        /// </summary>
        private void Search()
        {
            if (SearchTextBox.Text == "")
            {
                SNListView.Items.Clear();
                EmailListView.Items.Clear();
                HomebankingListView.Items.Clear();
                LicensesListView.Items.Clear();
                OtherListView.Items.Clear();

                FullListView();
            }
            else
            {
                if (isSNShow)
                {
                    SNListView.Items.Clear();

                    foreach (Entry entry in socialNetworkList)
                    {
                        if (entry.Name.Contains(SearchTextBox.Text) || entry.Login.Contains(SearchTextBox.Text) || entry.Phone.Contains(SearchTextBox.Text)
                            || entry.URL.Contains(SearchTextBox.Text) || entry.Notes.Contains(SearchTextBox.Text))
                        {
                            ListViewItem lvi = new ListViewItem(entry.Name);
                            lvi.SubItems.Add(entry.Login);
                            lvi.SubItems.Add("••••••••••");
                            lvi.SubItems.Add(entry.Phone);
                            lvi.SubItems.Add(entry.URL);
                            lvi.SubItems.Add(entry.Notes);

                            SNListView.Items.Add(lvi);
                        }
                    }
                }

                if (isEmailShow)
                {
                    EmailListView.Items.Clear();

                    foreach (Entry entry in emailList)
                    {
                        if (entry.Name.Contains(SearchTextBox.Text) || entry.Login.Contains(SearchTextBox.Text) || entry.Phone.Contains(SearchTextBox.Text)
                            || entry.URL.Contains(SearchTextBox.Text) || entry.Notes.Contains(SearchTextBox.Text))
                        {
                            ListViewItem lvi = new ListViewItem(entry.Name);
                            lvi.SubItems.Add(entry.Login);
                            lvi.SubItems.Add("••••••••••");
                            lvi.SubItems.Add(entry.Phone);
                            lvi.SubItems.Add(entry.URL);
                            lvi.SubItems.Add(entry.Notes);

                            EmailListView.Items.Add(lvi);
                        }
                    }
                }

                if (isOtherShow)
                {
                    OtherListView.Items.Clear();

                    foreach (Entry entry in otherList)
                    {
                        if (entry.Name.Contains(SearchTextBox.Text) || entry.Login.Contains(SearchTextBox.Text) || entry.Phone.Contains(SearchTextBox.Text)
                            || entry.URL.Contains(SearchTextBox.Text) || entry.Notes.Contains(SearchTextBox.Text))
                        {
                            ListViewItem lvi = new ListViewItem(entry.Name);
                            lvi.SubItems.Add(entry.Login);
                            lvi.SubItems.Add("••••••••••");
                            lvi.SubItems.Add(entry.Phone);
                            lvi.SubItems.Add(entry.URL);
                            lvi.SubItems.Add(entry.Notes);

                            OtherListView.Items.Add(lvi);
                        }
                    }
                }

                if (isHomebankingShow)
                {
                    HomebankingListView.Items.Clear();

                    foreach (BankEntry entry in homebankingList)
                    {
                        if (entry.Name.Contains(SearchTextBox.Text) || entry.CardNumber.Contains(SearchTextBox.Text)
                            || entry.Date.Contains(SearchTextBox.Text) || entry.Phone.Contains(SearchTextBox.Text) || entry.Notes.Contains(SearchTextBox.Text))
                        {
                            ListViewItem lvi = new ListViewItem(entry.Name);
                            lvi.SubItems.Add(entry.CardNumber);
                            lvi.SubItems.Add(entry.Date);
                            lvi.SubItems.Add("•••");
                            lvi.SubItems.Add(entry.Phone);
                            lvi.SubItems.Add(entry.Notes);

                            HomebankingListView.Items.Add(lvi);
                        }
                    }
                }

                if (isLicensesShow)
                {
                    LicensesListView.Items.Clear();

                    foreach (LicenseEntry entry in licensesList)
                    {
                        if (entry.Name.Contains(SearchTextBox.Text) || entry.Key.Contains(SearchTextBox.Text) || entry.Notes.Contains(SearchTextBox.Text))
                        {
                            ListViewItem lvi = new ListViewItem(entry.Name);
                            lvi.SubItems.Add(entry.Key);
                            lvi.SubItems.Add(entry.Notes);

                            LicensesListView.Items.Add(lvi);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Full all tables from lists
        /// </summary>
        private void FullListView()
        {
            for (int i = 0; i < socialNetworkList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(socialNetworkList[i].Name);
                lvi.SubItems.Add(socialNetworkList[i].Login);
                lvi.SubItems.Add("••••••••••");
                lvi.SubItems.Add(socialNetworkList[i].Phone);
                lvi.SubItems.Add(socialNetworkList[i].URL);
                lvi.SubItems.Add(socialNetworkList[i].Notes);

                SNListView.Items.Add(lvi);
            }

            for (int i = 0; i < emailList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(emailList[i].Name);
                lvi.SubItems.Add(emailList[i].Login);
                lvi.SubItems.Add("••••••••••");
                lvi.SubItems.Add(emailList[i].Phone);
                lvi.SubItems.Add(emailList[i].URL);
                lvi.SubItems.Add(emailList[i].Notes);

                EmailListView.Items.Add(lvi);
            }

            for (int i = 0; i < homebankingList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(homebankingList[i].Name);
                lvi.SubItems.Add(homebankingList[i].CardNumber);
                lvi.SubItems.Add(homebankingList[i].Date);
                lvi.SubItems.Add("•••");
                lvi.SubItems.Add(homebankingList[i].Phone);
                lvi.SubItems.Add(homebankingList[i].Notes);

                HomebankingListView.Items.Add(lvi);
            }

            for (int i = 0; i < licensesList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(licensesList[i].Name);
                lvi.SubItems.Add(licensesList[i].Key);
                lvi.SubItems.Add(licensesList[i].Notes);

                LicensesListView.Items.Add(lvi);
            }

            for (int i = 0; i < otherList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(otherList[i].Name);
                lvi.SubItems.Add(otherList[i].Login);
                lvi.SubItems.Add("••••••••••");
                lvi.SubItems.Add(otherList[i].Phone);
                lvi.SubItems.Add(otherList[i].URL);
                lvi.SubItems.Add(otherList[i].Notes);

                OtherListView.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Clear all data
        /// </summary>
        private void ClearAll()
        {
            SNListView.Items.Clear();
            EmailListView.Items.Clear();
            HomebankingListView.Items.Clear();
            LicensesListView.Items.Clear();
            OtherListView.Items.Clear();

            socialNetworkList.Clear();
            emailList.Clear();
            homebankingList.Clear();
            licensesList.Clear();
            otherList.Clear();

            havePassword = false;
            changes = 0;
        }

        /// <summary>
        /// Set form language
        /// </summary>
        private void SetLanguage()
        {
            if (SettingsForm.language == Language.English)
            {
                if (isSNShow)
                {
                    SNButton.Image = Properties.Resources.sn_button_activated;
                    EmailButton.Image = Properties.Resources.email_button_default;
                    HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.licenses_button_default;
                    OtherButton.Image = Properties.Resources.other_button_default;
                }

                if (isEmailShow)
                {
                    SNButton.Image = Properties.Resources.sn_button_default;
                    EmailButton.Image = Properties.Resources.email_button_activated;
                    HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.licenses_button_default;
                    OtherButton.Image = Properties.Resources.other_button_default;
                }

                if (isHomebankingShow)
                {
                    SNButton.Image = Properties.Resources.sn_button_default;
                    EmailButton.Image = Properties.Resources.email_button_default;
                    HomebankingButton.Image = Properties.Resources.homebanking_button_activated;
                    LicensesButton.Image = Properties.Resources.licenses_button_default;
                    OtherButton.Image = Properties.Resources.other_button_default;
                }

                if (isLicensesShow)
                {
                    SNButton.Image = Properties.Resources.sn_button_default;
                    EmailButton.Image = Properties.Resources.email_button_default;
                    HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.licenses_button_activated;
                    OtherButton.Image = Properties.Resources.other_button_default;
                }

                if (isOtherShow)
                {
                    SNButton.Image = Properties.Resources.sn_button_default;
                    EmailButton.Image = Properties.Resources.email_button_default;
                    HomebankingButton.Image = Properties.Resources.homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.licenses_button_default;
                    OtherButton.Image = Properties.Resources.other_button_activated;
                }

                SettingsButton.Image = Properties.Resources.settings_button_default;

                SNListView.Columns[0].Text = Eng.NameListViewHeader;
                SNListView.Columns[1].Text = Eng.LoginListViewHeader;
                SNListView.Columns[2].Text = Eng.PasswordListViewHeader;
                SNListView.Columns[3].Text = Eng.PhoneListViewHeader;
                SNListView.Columns[4].Text = Eng.UrlListViewHeader;
                SNListView.Columns[5].Text = Eng.NotesListViewHeader;

                EmailListView.Columns[0].Text = Eng.NameListViewHeader;
                EmailListView.Columns[1].Text = Eng.LoginListViewHeader;
                EmailListView.Columns[2].Text = Eng.PasswordListViewHeader;
                EmailListView.Columns[3].Text = Eng.PhoneListViewHeader;
                EmailListView.Columns[4].Text = Eng.UrlListViewHeader;
                EmailListView.Columns[5].Text = Eng.NotesListViewHeader;

                OtherListView.Columns[0].Text = Eng.NameListViewHeader;
                OtherListView.Columns[1].Text = Eng.LoginListViewHeader;
                OtherListView.Columns[2].Text = Eng.PasswordListViewHeader;
                OtherListView.Columns[3].Text = Eng.PhoneListViewHeader;
                OtherListView.Columns[4].Text = Eng.UrlListViewHeader;
                OtherListView.Columns[5].Text = Eng.NotesListViewHeader;

                HomebankingListView.Columns[0].Text = Eng.NameListViewHeader;
                HomebankingListView.Columns[1].Text = Eng.CardNumberListViewHeader;
                HomebankingListView.Columns[2].Text = Eng.DateListViewHeader;
                HomebankingListView.Columns[3].Text = Eng.CvcListViewHeader;
                HomebankingListView.Columns[4].Text = Eng.PhoneListViewHeader;
                HomebankingListView.Columns[5].Text = Eng.NotesListViewHeader;

                LicensesListView.Columns[0].Text = Eng.NameListViewHeader;
                LicensesListView.Columns[1].Text = Eng.KeyListViewHeader;
                LicensesListView.Columns[2].Text = Eng.NotesListViewHeader;

                SearchTextBox.Hint = Eng.SearchHint;

                AddEntryButton.Text = Eng.AddEntryCM;
                AddCardButton.Text = Eng.AddEntryCM;
                AddLicenseButton.Text = Eng.AddEntryCM;
                EditEntryButton.Text = Eng.EditEntryCM;
                EditCardButton.Text = Eng.EditEntryCM;
                EditLicenseButton.Text = Eng.EditEntryCM;
                DeleteEntryButton.Text = Eng.DeleteEntryCM;
                CopyLoginButton.Text = Eng.CopyLoginCM;
                CopyPasswordButton.Text = Eng.CopyPasswordCM;
                CopyCardButton.Text = Eng.CopyCardNumberCM;
                CopyCVCButton.Text = Eng.CopyCvcCM;
                CopyKeyButton.Text = Eng.CopyKeyCM;

                SaveChangesMB = Eng.SaveChangesMB;
                AttentionHMB = Eng.AttentionHeader;
                ErrorHMB = Eng.ErrorHeader;
                UnknownErrorMB = Eng.UnknownErrorMB;
                WrongPasswordMB = Eng.WrongPasswordMB;
            }

            if (SettingsForm.language == Language.Russian)
            {
                if (isSNShow)
                {
                    SNButton.Image = Properties.Resources.rus_sn_button_activated;
                    EmailButton.Image = Properties.Resources.rus_email_button_default;
                    HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                    OtherButton.Image = Properties.Resources.rus_other_button_default;
                }

                if (isEmailShow)
                {
                    SNButton.Image = Properties.Resources.rus_sn_button_default;
                    EmailButton.Image = Properties.Resources.rus_email_button_activated;
                    HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                    OtherButton.Image = Properties.Resources.rus_other_button_default;
                }

                if (isHomebankingShow)
                {
                    SNButton.Image = Properties.Resources.rus_sn_button_default;
                    EmailButton.Image = Properties.Resources.rus_email_button_default;
                    HomebankingButton.Image = Properties.Resources.rus_homebanking_button_activated;
                    LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                    OtherButton.Image = Properties.Resources.rus_other_button_default;
                }

                if (isLicensesShow)
                {
                    SNButton.Image = Properties.Resources.rus_sn_button_default;
                    EmailButton.Image = Properties.Resources.rus_email_button_default;
                    HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.rus_licenses_button_activated;
                    OtherButton.Image = Properties.Resources.rus_other_button_default;
                }

                if (isOtherShow)
                {
                    SNButton.Image = Properties.Resources.rus_sn_button_default;
                    EmailButton.Image = Properties.Resources.rus_email_button_default;
                    HomebankingButton.Image = Properties.Resources.rus_homebanking_button_default;
                    LicensesButton.Image = Properties.Resources.rus_licenses_button_default;
                    OtherButton.Image = Properties.Resources.rus_other_button_activated;
                }

                SettingsButton.Image = Properties.Resources.rus_settings_button_default;

                SNListView.Columns[0].Text = Rus.NameListViewHeader;
                SNListView.Columns[1].Text = Rus.LoginListViewHeader;
                SNListView.Columns[2].Text = Rus.PasswordListViewHeader;
                SNListView.Columns[3].Text = Rus.PhoneListViewHeader;
                SNListView.Columns[4].Text = Rus.UrlListViewHeader;
                SNListView.Columns[5].Text = Rus.NotesListViewHeader;

                EmailListView.Columns[0].Text = Rus.NameListViewHeader;
                EmailListView.Columns[1].Text = Rus.LoginListViewHeader;
                EmailListView.Columns[2].Text = Rus.PasswordListViewHeader;
                EmailListView.Columns[3].Text = Rus.PhoneListViewHeader;
                EmailListView.Columns[4].Text = Rus.UrlListViewHeader;
                EmailListView.Columns[5].Text = Rus.NotesListViewHeader;

                OtherListView.Columns[0].Text = Rus.NameListViewHeader;
                OtherListView.Columns[1].Text = Rus.LoginListViewHeader;
                OtherListView.Columns[2].Text = Rus.PasswordListViewHeader;
                OtherListView.Columns[3].Text = Rus.PhoneListViewHeader;
                OtherListView.Columns[4].Text = Rus.UrlListViewHeader;
                OtherListView.Columns[5].Text = Rus.NotesListViewHeader;

                HomebankingListView.Columns[0].Text = Rus.NameListViewHeader;
                HomebankingListView.Columns[1].Text = Rus.CardNumberListViewHeader;
                HomebankingListView.Columns[2].Text = Rus.DateListViewHeader;
                HomebankingListView.Columns[3].Text = Rus.CvcListViewHeader;
                HomebankingListView.Columns[4].Text = Rus.PhoneListViewHeader;
                HomebankingListView.Columns[5].Text = Rus.NotesListViewHeader;

                LicensesListView.Columns[0].Text = Rus.NameListViewHeader;
                LicensesListView.Columns[1].Text = Rus.KeyListViewHeader;
                LicensesListView.Columns[2].Text = Rus.NotesListViewHeader;

                SearchTextBox.Hint = Rus.SearchHint;

                AddEntryButton.Text = Rus.AddEntryCM;
                AddCardButton.Text = Rus.AddEntryCM;
                AddLicenseButton.Text = Rus.AddEntryCM;
                EditEntryButton.Text = Rus.EditEntryCM;
                EditCardButton.Text = Rus.EditEntryCM;
                EditLicenseButton.Text = Rus.EditEntryCM;
                DeleteEntryButton.Text = Rus.DeleteEntryCM;
                CopyLoginButton.Text = Rus.CopyLoginCM;
                CopyPasswordButton.Text = Rus.CopyPasswordCM;
                CopyCardButton.Text = Rus.CopyCardNumberCM;
                CopyCVCButton.Text = Rus.CopyCvcCM;
                CopyKeyButton.Text = Rus.CopyKeyCM;

                SaveChangesMB = Rus.SaveChangesMB;
                AttentionHMB = Rus.AttentionHeader;
                ErrorHMB = Rus.ErrorHeader;
                UnknownErrorMB = Rus.UnknownErrorMB;
                WrongPasswordMB = Rus.WrongPasswordMB;
            }
        }

        /// <summary>
        /// Convert string to hash (16 bytes). For password
        /// </summary>
        /// <param name="md5Hash"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetMD5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        /// <summary>
        /// Convert hash string to byte block
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static byte[,] StringToByteBlock(string source)
        {
            int count = 1;
            int len = source.Length;
            for (int i = 1; i < len; i += 2)
            {
                if (i != len - 1)
                {
                    source = source.Insert(i + count, " ");
                    count++;
                }
            }

            string[] temp = source.Split();
            byte[] res = new byte[temp.Length];

            for (int i = 0; i < temp.Length; i++)
                res[i] = Convert.ToByte(temp[i], 16);

            int index = 0;
            byte[,] block = new byte[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    block[i, j] = res[index];
                    index++;
                }

            return block;
        }

        #endregion
    }

    /// <summary>
    /// For add/edit form
    /// </summary>
    public enum Mode
    {
        Add, Edit
    }

    /// <summary>
    /// UI theme
    /// </summary>
    public enum Theme
    {
        Forest, Desert, Mountains, City, Sunset
    }

    /// <summary>
    /// App language
    /// </summary>
    public enum Language
    {
        Russian, English
    }
}
