using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Passave
{
    public partial class MainForm : Form
    {
        List<Entry> socialNetworkList = new List<Entry>();
        List<Entry> emailList = new List<Entry>();
        List<BankEntry> homebankingList = new List<BankEntry>();
        List<LicenseEntry> licensesList = new List<LicenseEntry>();
        List<Entry> otherList = new List<Entry>();

        public static bool isSNShow = true, isEmailShow = false, isHomebankingShow = false, isLicensesShow = false, isOtherShow = false;

        public MainForm()
        {
            InitializeComponent();

            SNButton.Image = Properties.Resources.sn_button_activated;

            SNListView.Show();
            EmailListView.Hide();
            HomebankingListView.Hide();
            LicensesListView.Hide();
            OtherListView.Hide();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //// 1 - bar (name), 2 - upper bar, 3 - ?, 4 - primary color tabpage, 5 - text color (theme)
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Green400, Accent.Blue400, TextShade.BLACK);
        }

        #region GUI

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void SNButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isSNShow)
                SNButton.Image = Properties.Resources.sn_button_default;
        }

        private void SNButton_MouseMove(object sender, MouseEventArgs e)
        {
            SNButton.Image = Properties.Resources.sn_button_activated;
        }

        private void EmailButton_MouseMove(object sender, MouseEventArgs e)
        {
            EmailButton.Image = Properties.Resources.email_button_activated;
        }

        private void EmailButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isEmailShow)
                EmailButton.Image = Properties.Resources.email_button_default;
        }

        private void HomebankingButton_MouseMove(object sender, MouseEventArgs e)
        {
            HomebankingButton.Image = Properties.Resources.homebanking_button_activated;
        }

        private void HomebankingButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isHomebankingShow)
                HomebankingButton.Image = Properties.Resources.homebanking_button_default;
        }

        private void LicensesButton_MouseMove(object sender, MouseEventArgs e)
        {
            LicensesButton.Image = Properties.Resources.licenses_button_activated;
        }

        private void LicensesButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isLicensesShow)
                LicensesButton.Image = Properties.Resources.licenses_button_default;
        }

        private void OtherButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isOtherShow)
                OtherButton.Image = Properties.Resources.other_button_default;
        }

        private void OtherButton_MouseMove(object sender, MouseEventArgs e)
        {
            OtherButton.Image = Properties.Resources.other_button_activated;
        }

        private void SettingsButton_MouseMove(object sender, MouseEventArgs e)
        {
            SettingsButton.Image = Properties.Resources.settings_button_activated;
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.Image = Properties.Resources.settings_button_default;
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

        private void SearchButton_MouseMove(object sender, MouseEventArgs e)
        {
            SearchButton.Image = Properties.Resources.search_button_activated;
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            SearchButton.Image = Properties.Resources.search_button_default;
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

            SNButton.Image = Properties.Resources.sn_button_activated;
            EmailButton.Image = Properties.Resources.email_button_default;
            HomebankingButton.Image = Properties.Resources.homebanking_button_default;
            LicensesButton.Image = Properties.Resources.licenses_button_default;
            OtherButton.Image = Properties.Resources.other_button_default;

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

            SNButton.Image = Properties.Resources.sn_button_default;
            EmailButton.Image = Properties.Resources.email_button_activated;
            HomebankingButton.Image = Properties.Resources.homebanking_button_default;
            LicensesButton.Image = Properties.Resources.licenses_button_default;
            OtherButton.Image = Properties.Resources.other_button_default;

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

            SNButton.Image = Properties.Resources.sn_button_default;
            EmailButton.Image = Properties.Resources.email_button_default;
            HomebankingButton.Image = Properties.Resources.homebanking_button_activated;
            LicensesButton.Image = Properties.Resources.licenses_button_default;
            OtherButton.Image = Properties.Resources.other_button_default;

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

            SNButton.Image = Properties.Resources.sn_button_default;
            EmailButton.Image = Properties.Resources.email_button_default;
            HomebankingButton.Image = Properties.Resources.homebanking_button_default;
            LicensesButton.Image = Properties.Resources.licenses_button_activated;
            OtherButton.Image = Properties.Resources.other_button_default;

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

            SNButton.Image = Properties.Resources.sn_button_default;
            EmailButton.Image = Properties.Resources.email_button_default;
            HomebankingButton.Image = Properties.Resources.homebanking_button_default;
            LicensesButton.Image = Properties.Resources.licenses_button_default;
            OtherButton.Image = Properties.Resources.other_button_activated;

            SNListView.Hide();
            EmailListView.Hide();
            HomebankingListView.Hide();
            LicensesListView.Hide();
            OtherListView.Show();
        }

        #endregion

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Add);
            if (form.ShowDialog() == DialogResult.OK)
                AddEntryToDatabase();
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Add);
            if (form.ShowDialog() == DialogResult.OK)
                AddEntryToDatabase();
        }

        private void AddLicenseButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Add);
            if (form.ShowDialog() == DialogResult.OK)
                AddEntryToDatabase();
        }

        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm(Mode.Edit);
            if (form.ShowDialog() == DialogResult.OK)
                EditEntryAtDatabase();
        }

        private void AddEntryToDatabase()
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
            }

            if (isHomebankingShow)
            {
                homebankingList.Add(AddEditForm.addHomebankingEntry);

                ListViewItem listViewItem = new ListViewItem(AddEditForm.addHomebankingEntry.Name);
                listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.CardNumber);
                listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.CVC);
                listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.Date);
                listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.Phone);
                listViewItem.SubItems.Add(AddEditForm.addHomebankingEntry.Notes);

                HomebankingListView.Items.Add(listViewItem);
            }

            if (isLicensesShow)
            {
                licensesList.Add(AddEditForm.addLicenseEntry);

                ListViewItem listViewItem = new ListViewItem(AddEditForm.addLicenseEntry.Name);
                listViewItem.SubItems.Add(AddEditForm.addLicenseEntry.Key);
                listViewItem.SubItems.Add(AddEditForm.addLicenseEntry.Notes);

                LicensesListView.Items.Add(listViewItem);
            }
        }

        private void EditEntryAtDatabase()
        {
            
        }
    }

    public enum Mode
    {
        Add, Edit
    }
}
