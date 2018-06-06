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
    // TODO: доступность нажатия кнопок в контекстном меню (при пустом списке или нет выделенных запретить удалить, редактировать, посмотреть, копировать всё)
    // если редактировать, то чтобы была выделена только одна запись
    // password char для CVC
    // желательно бы добавить пин код

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

        private void Add()
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

        private void Edit()
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
                    lvi.SubItems.Add(AddEditForm.addHomebankingEntry.CVC);
                    lvi.SubItems.Add(AddEditForm.addHomebankingEntry.Phone);
                    lvi.SubItems.Add(AddEditForm.addHomebankingEntry.Notes);

                    HomebankingListView.Items.RemoveAt(i);
                    HomebankingListView.Items.Insert(i, lvi);
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
                }
            }
        }

        private void Delete()
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
                    if (selected[0].SubItems[3].Text != homebankingList[j].Date) { j++; continue; }
                    if (selected[0].SubItems[4].Text != homebankingList[j].CVC) { j++; continue; }
                    if (selected[0].SubItems[5].Text != homebankingList[j].Phone) { j++; continue; }
                    if (selected[0].SubItems[6].Text != homebankingList[j].Notes) { j++; continue; }

                    homebankingList.RemoveAt(j);
                    HomebankingListView.Items.RemoveAt(j);
                    i++;
                }
            }

            if (isHomebankingShow)
            {
                var selected = new MaterialListView.SelectedListViewItemCollection(LicensesListView);

                int i = 0, j = 0, selCount = selected.Count;
                while (i != selCount)
                {
                    if (selected[0].SubItems[0].Text != licensesList[j].Name) { j++; continue; }
                    if (selected[0].SubItems[1].Text != licensesList[j].Key) { j++; continue; }
                    if (selected[0].SubItems[3].Text != licensesList[j].Notes) { j++; continue; }

                    licensesList.RemoveAt(j);
                    LicensesListView.Items.RemoveAt(j);
                    i++;
                }
            }
        }
    }

    public enum Mode
    {
        Add, Edit
    }
}
