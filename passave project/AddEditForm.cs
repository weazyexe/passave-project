using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passave
{
    public partial class AddEditForm : Form
    {
        public static Entry addEntry = new Entry();
        public static LicenseEntry addLicenseEntry = new LicenseEntry();
        public static BankEntry addHomebankingEntry = new BankEntry();
        Mode mode;

        public AddEditForm(Mode _mode)
        {
            mode = _mode;
            InitializeComponent();
            ThemePanel.BackColor = Color.FromArgb(56, 145, 213);
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
                messageBox = new NewMessageBox("Passwords not equals!");
                messageBox.ShowDialog();
            }
            else 
            {
                if (MainForm.isSNShow || MainForm.isEmailShow || MainForm.isOtherShow)
                {
                    if (NameTextBox.Text != "" || PasswordTextBox.Text != "" || LoginTextBox.Text != "")
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
                        messageBox = new NewMessageBox("Name, login and password field can't be empty!");
                        messageBox.ShowDialog();
                    }
                }

                if (MainForm.isHomebankingShow)
                {
                    if (NameTextBox.Text == "" || CardNumberTextBox.Text == "" || DateTextBox.Text == "" || CvcTextBox.Text == "")
                    {
                        messageBox = new NewMessageBox("Name, card number, date and CVC field can't be empty!");
                        messageBox.ShowDialog();
                    }
                    else if (CvcTextBox.Text.Length != 3)
                    {
                        messageBox = new NewMessageBox("CVC is not correct!");
                        messageBox.ShowDialog();
                    }
                    else if (!char.IsDigit(CvcTextBox.Text[0]) && !char.IsDigit(CvcTextBox.Text[1]) && !char.IsDigit(CvcTextBox.Text[2]))
                    {
                        messageBox = new NewMessageBox("CVC is not correct!");
                        messageBox.ShowDialog();
                    }
                    else if (DateTextBox.Text.Length != 5)
                    {
                        messageBox = new NewMessageBox("Date is not correct!");
                        messageBox.ShowDialog();
                    }
                    else if (!char.IsDigit(DateTextBox.Text[0]) && !char.IsDigit(DateTextBox.Text[1]) && !char.IsDigit(DateTextBox.Text[3]) && !char.IsDigit(DateTextBox.Text[4]))
                    {
                        messageBox = new NewMessageBox("Date is not correct!");
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
                        messageBox = new NewMessageBox("Name and key field can't be empty!");
                        messageBox.ShowDialog();
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DateTextBox.Text.Length == 2)
            {
                DateTextBox.Text += '/';
                DateTextBox.SelectionStart = DateTextBox.Text.Length;
            }
        }
    }
}
