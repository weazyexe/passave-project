﻿using System;
using System.Drawing;
using System.Windows.Forms;

using Passave.International;

namespace Passave
{
    public partial class NewMessageBox : Form
    {
        MessageBoxButtons mbb = MessageBoxButtons.OK;

        public NewMessageBox(string message, string header = "ATTENTION", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            InitializeComponent();
            HeaderLabel.Text = header;
            MessageTextBox.Text = message;
            mbb = buttons;

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

            if (SettingsForm.language == Language.English)
            {
                YesButton.Text = Eng.YesButton;
                NoButton.Text = Eng.NoButton;
                CancelButton.Text = Eng.CancelButton;
            }

            if (SettingsForm.language == Language.Russian)
            {
                YesButton.Text = Rus.YesButton;
                NoButton.Text = Rus.NoButton;
                CancelButton.Text = Rus.CancelButton;
            }
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_activated;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_default;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewMessageBox_Load(object sender, EventArgs e)
        {
            if (mbb == MessageBoxButtons.OK)
            {
                OKButton.Show();
                CancelButton.Hide();
                YesButton.Hide();
                NoButton.Hide();
            }

            if (mbb == MessageBoxButtons.OKCancel)
            {
                OKButton.Show();
                CancelButton.Show();
                CancelButton.Location = new Point(175, 169);
                YesButton.Hide();
                NoButton.Hide();
            }

            if (mbb == MessageBoxButtons.YesNo)
            {
                OKButton.Hide();
                CancelButton.Hide();
                YesButton.Show();
                NoButton.Show();
            }

            if (mbb == MessageBoxButtons.YesNoCancel)
            {
                OKButton.Hide();
                CancelButton.Show();
                CancelButton.Location = new Point(120, 169);
                YesButton.Show();
                NoButton.Show();
            }
        }
    }
}
