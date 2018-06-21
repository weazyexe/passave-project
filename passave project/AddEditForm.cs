using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using Passave.International;

namespace Passave
{
    public partial class AddEditForm : Form
    {
        public static Entry addEntry = new Entry();
        public static LicenseEntry addLicenseEntry = new LicenseEntry();
        public static BankEntry addHomebankingEntry = new BankEntry();
        Mode mode;

        string PasswordNotEqualsMB, EmptyNameLoginMB, NameCardNumberDateCvcMB, NotCorrectCvcMB, NotCorrectDateMB, EmptyNameKeyMB, AttentionHMB;

        bool first = false, second = false, third = false, four = false;
        int cardLength = 0;

        public AddEditForm(Mode _mode)
        {
            mode = _mode;
            InitializeComponent();
            MenuPanel.BackColor = Color.FromArgb(56, 145, 213);

            if (MainForm.theme == Theme.Forest)
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_forest;
            if (MainForm.theme == Theme.Desert)
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_desert;
            if (MainForm.theme == Theme.Mountains)
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_mountains;
            if (MainForm.theme == Theme.City)
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_city;
            if (MainForm.theme == Theme.Sunset)
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_sunset;
        }

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

        private void BorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            BorderPanel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_activated;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_default;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderLabel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NewMessageBox messageBox;
            if (PasswordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                messageBox = new NewMessageBox(PasswordNotEqualsMB, AttentionHMB);
                messageBox.ShowDialog();
            }
            else 
            {
                if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                {
                    if (NameTextBox.Text != "" && PasswordTextBox.Text != "" && LoginTextBox.Text != "")
                    {
                        addEntry = new Entry(NameTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text, PhoneTextBox.Text, UrlTextBox.Text, NotesTextBox.Text);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (addEntry.Name == NameTextBox.Text && addEntry.Login == LoginTextBox.Text && addEntry.Password == PasswordTextBox.Text &&
                        addEntry.Phone == PhoneTextBox.Text && addEntry.URL == UrlTextBox.Text && addEntry.Notes == NotesTextBox.Text)
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        messageBox = new NewMessageBox(EmptyNameLoginMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                }

                if (MainForm.isHomebankingShow)
                {
                    if (NameTextBox.Text == "" || CardNumberTextBox.Text == "" || DateTextBox.Text == "" || CvcTextBox.Text == "")
                    {
                        messageBox = new NewMessageBox(NameCardNumberDateCvcMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                    else if (CvcTextBox.Text.Length != 3)
                    {
                        messageBox = new NewMessageBox(NotCorrectCvcMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                    else if (!char.IsDigit(CvcTextBox.Text[0]) && !char.IsDigit(CvcTextBox.Text[1]) && !char.IsDigit(CvcTextBox.Text[2]))
                    {
                        messageBox = new NewMessageBox(NotCorrectCvcMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                    else if (DateTextBox.Text.Length != 5)
                    {
                        messageBox = new NewMessageBox(NotCorrectDateMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                    else if (!char.IsDigit(DateTextBox.Text[0]) && !char.IsDigit(DateTextBox.Text[1]) && !char.IsDigit(DateTextBox.Text[3]) && !char.IsDigit(DateTextBox.Text[4]))
                    {
                        messageBox = new NewMessageBox(NotCorrectDateMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                    else if (addHomebankingEntry.Name == NameTextBox.Text && addHomebankingEntry.CardNumber == CardNumberTextBox.Text && addHomebankingEntry.Date == DateTextBox.Text &&
                        addHomebankingEntry.CVC == CvcTextBox.Text && addHomebankingEntry.Phone == PhoneTextBox.Text && addHomebankingEntry.Notes == NotesTextBox.Text)
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        addHomebankingEntry = new BankEntry(NameTextBox.Text, CardNumberTextBox.Text, DateTextBox.Text, CvcTextBox.Text, PhoneTextBox.Text, NotesTextBox.Text);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                if (MainForm.isLicensesShow)
                {
                    if (NameTextBox.Text != "" || KeyTextBox.Text != "")
                    {
                        addLicenseEntry = new LicenseEntry(NameTextBox.Text, KeyTextBox.Text, NotesTextBox.Text);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (addLicenseEntry.Name == NameTextBox.Text && addLicenseEntry.Key == KeyTextBox.Text && addLicenseEntry.Notes == NotesTextBox.Text)
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        messageBox = new NewMessageBox(EmptyNameKeyMB, AttentionHMB);
                        messageBox.ShowDialog();
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                if (CardNumberTextBox.Text.Length == 0) cardLength = 0;
                else cardLength--;

                if (cardLength < 16) four = false;
                if (cardLength < 12) third = false;
                if (cardLength < 8) second = false;
                if (cardLength < 3) first = false;
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                HeaderLabel.Text = "ADD ENTRY";
                AddButton.Text = "Add";
            }
            else
            {
                HeaderLabel.Text = "EDIT ENTRY";
                AddButton.Text = "Edit";

                if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                {
                    NameTextBox.Text = addEntry.Name;
                    LoginTextBox.Text = addEntry.Login;
                    PasswordTextBox.Text = addEntry.Password;
                    RepeatPasswordTextBox.Text = addEntry.Password;
                    PhoneTextBox.Text = addEntry.Phone;
                    UrlTextBox.Text = addEntry.URL;
                    NotesTextBox.Text = addEntry.Notes;
                }

                if (MainForm.isHomebankingShow)
                {
                    NameTextBox.Text = addHomebankingEntry.Name;
                    CardNumberTextBox.Text = addHomebankingEntry.CardNumber;
                    DateTextBox.Text = addHomebankingEntry.Date;
                    CvcTextBox.Text = addHomebankingEntry.CVC;
                    PhoneTextBox.Text = addHomebankingEntry.Phone;
                    NotesTextBox.Text = addHomebankingEntry.Notes;
                }

                if (MainForm.isLicensesShow)
                {
                    NameTextBox.Text = addLicenseEntry.Name;
                    KeyTextBox.Text = addLicenseEntry.Key;
                    NotesTextBox.Text = addLicenseEntry.Notes;
                }
            }

            if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
            {
                Size = new Size(315, 500);

                CloseButton.Location = new Point(271, 15);

                CardNumberTextBox.Hide();
                CvcTextBox.Hide();
                DateTextBox.Hide();

                LoginTextBox.Show();
                PasswordTextBox.Show();
                RepeatPasswordTextBox.Show();

                KeyTextBox.Hide();

                PhoneTextBox.Location = new Point(39, 267);
                NotesTextBox.Location = new Point(39, 367);
                AddButton.Location = new Point(254, 449);
                CancelButton.Location = new Point(173, 449);

                NameTextBox.TabIndex = 0;
                LoginTextBox.TabIndex = 1;
                PasswordTextBox.TabIndex = 2;
                RepeatPasswordTextBox.TabIndex = 3;
                PhoneTextBox.TabIndex = 4;
                UrlTextBox.TabIndex = 5;
                NotesTextBox.TabIndex = 6;

                CardNumberTextBox.TabIndex = 7;
                CvcTextBox.TabIndex = 8;
                DateTextBox.TabIndex = 9;
                KeyTextBox.TabIndex = 10;

            }
            else if (MainForm.isHomebankingShow)
            {
                Size = new Size(535, 311);

                CloseButton.Location = new Point(491, 12);

                LoginTextBox.Hide();
                PasswordTextBox.Hide();
                RepeatPasswordTextBox.Hide();

                CardNumberTextBox.Show();
                CvcTextBox.Show();
                DateTextBox.Show();

                KeyTextBox.Hide();

                PhoneTextBox.Location = new Point(287, 167);
                NotesTextBox.Location = new Point(39, 217);
                AddButton.Location = new Point(475, 260);
                CancelButton.Location = new Point(394, 260);

                NameTextBox.TabIndex = 0;
                LoginTextBox.TabIndex = 6;
                PasswordTextBox.TabIndex = 7;
                RepeatPasswordTextBox.TabIndex = 8;
                PhoneTextBox.TabIndex = 4;
                UrlTextBox.TabIndex = 9;
                NotesTextBox.TabIndex = 5;

                CardNumberTextBox.TabIndex = 1;
                CvcTextBox.TabIndex = 2;
                DateTextBox.TabIndex = 3;
                KeyTextBox.TabIndex = 10;

                SetLanguage();
            }
            else
            {
                Size = new Size(537, 255);

                CloseButton.Location = new Point(492, 12);

                LoginTextBox.Hide();
                PasswordTextBox.Hide();
                RepeatPasswordTextBox.Hide();

                CardNumberTextBox.Hide();
                CvcTextBox.Hide();
                DateTextBox.Hide();

                KeyTextBox.Show();

                PhoneTextBox.Hide();
                NotesTextBox.Location = new Point(39, 167);
                AddButton.Location = new Point(476, 204);
                CancelButton.Location = new Point(395, 204);

                NameTextBox.TabIndex = 0;
                LoginTextBox.TabIndex = 3;
                PasswordTextBox.TabIndex = 4;
                RepeatPasswordTextBox.TabIndex = 5;
                PhoneTextBox.TabIndex = 6;
                UrlTextBox.TabIndex = 7;
                NotesTextBox.TabIndex = 2;

                CardNumberTextBox.TabIndex = 8;
                CvcTextBox.TabIndex = 9;
                DateTextBox.TabIndex = 10;
                KeyTextBox.TabIndex = 1;
            }

            SetLanguage();
        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DateTextBox.Text.Length == 2)
            {
                DateTextBox.Text += '/';
                DateTextBox.SelectionStart = DateTextBox.Text.Length;
            }
        }

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex firstRegEx = new Regex(@"^\d{4}$"), secRegEx = new Regex(@"^\d{4} \d{4}"), thirdRegEx = new Regex(@"^\d{4} \d{4} \d{4}$"), fourRegEx = new Regex(@"^\d{4} \d{4} \d{4} \d{4}$");

            if (firstRegEx.IsMatch(CardNumberTextBox.Text) && !first)
            {
                first = true;
                cardLength = CardNumberTextBox.Text.Length;
                CardNumberTextBox.Text = CardNumberTextBox.Text + " ";
                CardNumberTextBox.SelectionStart = CardNumberTextBox.Text.Length;
            }

            if (secRegEx.IsMatch(CardNumberTextBox.Text) && !second)
            {
                second = true;
                cardLength = CardNumberTextBox.Text.Length;
                CardNumberTextBox.Text = CardNumberTextBox.Text + " ";
                CardNumberTextBox.SelectionStart = CardNumberTextBox.Text.Length;
            }

            if (thirdRegEx.IsMatch(CardNumberTextBox.Text) && !third)
            {
                third = true;
                cardLength = CardNumberTextBox.Text.Length;
                CardNumberTextBox.Text = CardNumberTextBox.Text + " ";
                CardNumberTextBox.SelectionStart = CardNumberTextBox.Text.Length;
            }

            if (fourRegEx.IsMatch(CardNumberTextBox.Text) && !four)
            {
                four = true;
                cardLength = CardNumberTextBox.Text.Length;
                CardNumberTextBox.SelectionStart = CardNumberTextBox.Text.Length;
            }
        }

        private void SetLanguage()
        {
            if (SettingsForm.language == Language.English)
            {
                if (mode == Mode.Add)
                {
                    HeaderLabel.Text = Eng.AddHeader;
                    AddButton.Text = Eng.AddButton;
                }
                else
                {
                    HeaderLabel.Text = Eng.EditHeader;
                    AddButton.Text = Eng.EditButton;
                }

                AttentionHMB = Eng.AttentionHeader;

                if (mode == Mode.Add)
                {
                    if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                    {
                        AddButton.Location = new Point(254, 449);
                        CancelButton.Location = new Point(173, 449);
                    }
                    else if (MainForm.isHomebankingShow)
                    {
                        AddButton.Location = new Point(475, 260);
                        CancelButton.Location = new Point(394, 260);
                    }
                    else
                    {
                        AddButton.Location = new Point(476, 204);
                        CancelButton.Location = new Point(395, 204);
                    }
                }

                if (mode == Mode.Edit)
                {
                    if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                    {
                        AddButton.Location = new Point(254, 449);
                        CancelButton.Location = new Point(173, 449);
                    }
                    else if (MainForm.isHomebankingShow)
                    {
                        AddButton.Location = new Point(445, 260);
                        CancelButton.Location = new Point(364, 260);
                    }
                    else
                    {
                        AddButton.Location = new Point(476, 204);
                        CancelButton.Location = new Point(395, 204);
                    }
                }

                NameTextBox.Hint = Eng.NameHint;
                LoginTextBox.Hint = Eng.LoginHint;
                PasswordTextBox.Hint = Eng.PasswordHint;
                RepeatPasswordTextBox.Hint = Eng.ConfirmPasswordHint;
                PhoneTextBox.Hint = Eng.PhoneHint;
                UrlTextBox.Hint = Eng.UrlHint;
                NotesTextBox.Hint = Eng.NotesHint;
                CardNumberTextBox.Hint = Eng.CardNumberHint;
                DateTextBox.Hint = Eng.DateHint;
                CvcTextBox.Hint = Eng.CvcHint;
                KeyTextBox.Hint = Eng.KeyHint;

                CancelButton.Text = Eng.CancelButton;

                PasswordNotEqualsMB = Eng.PasswordNotEqualsMB;
                EmptyNameLoginMB = Eng.EmptyNameLoginMB;
                NameCardNumberDateCvcMB = Eng.EmptyCardDateCvcMB;
                NotCorrectCvcMB = Eng.NotCorrectCvcMB;
                NotCorrectDateMB = Eng.NotCorrectDateMB;
                EmptyNameKeyMB = Eng.EmptyNameKeyMB;
            }
            
            if (SettingsForm.language == Language.Russian)
            {
                if (mode == Mode.Add)
                {
                    HeaderLabel.Text = Rus.AddHeader;
                    AddButton.Text = Rus.AddButton;

                    AddButton.Location = new Point(210, 449);
                    CancelButton.Location = new Point(129, 449);
                }
                else
                {
                    HeaderLabel.Text = Rus.EditHeader;
                    AddButton.Text = Rus.EditButton;

                    AddButton.Location = new Point(168, 449);
                    CancelButton.Location = new Point(87, 449);
                }

                if (mode == Mode.Add)
                {
                    if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                    {
                        AddButton.Location = new Point(254, 449);
                        CancelButton.Location = new Point(173, 449);
                    }
                    else if (MainForm.isHomebankingShow)
                    {
                        AddButton.Location = new Point(435, 260);
                        CancelButton.Location = new Point(354, 260);
                    }
                    else
                    {
                        AddButton.Location = new Point(436, 204);
                        CancelButton.Location = new Point(355, 204);
                    }
                }

                if (mode == Mode.Edit)
                {
                    if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                    {
                        AddButton.Location = new Point(254, 449);
                        CancelButton.Location = new Point(173, 449);
                    }
                    else if (MainForm.isHomebankingShow)
                    {
                        AddButton.Location = new Point(385, 260);
                        CancelButton.Location = new Point(304, 260);
                    }
                    else
                    {
                        AddButton.Location = new Point(416, 204);
                        CancelButton.Location = new Point(335, 204);
                    }
                }

                AttentionHMB = Rus.AttentionHeader;

                NameTextBox.Hint = Rus.NameHint;
                LoginTextBox.Hint = Rus.LoginHint;
                PasswordTextBox.Hint = Rus.PasswordHint;
                RepeatPasswordTextBox.Hint = Rus.ConfirmPasswordHint;
                PhoneTextBox.Hint = Rus.PhoneHint;
                UrlTextBox.Hint = Rus.UrlHint;
                NotesTextBox.Hint = Rus.NotesHint;
                CardNumberTextBox.Hint = Rus.CardNumberHint;
                DateTextBox.Hint = Rus.DateHint;
                CvcTextBox.Hint = Rus.CvcHint;
                KeyTextBox.Hint = Rus.KeyHint;

                CancelButton.Text = Rus.CancelButton;

                PasswordNotEqualsMB = Rus.PasswordNotEqualsMB;
                EmptyNameLoginMB = Rus.EmptyNameLoginMB;
                NameCardNumberDateCvcMB = Rus.EmptyCardDateCvcMB;
                NotCorrectCvcMB = Rus.NotCorrectCvcMB;
                NotCorrectDateMB = Rus.NotCorrectDateMB;
                EmptyNameKeyMB = Rus.EmptyNameKeyMB;
            }
        }
    }
}
