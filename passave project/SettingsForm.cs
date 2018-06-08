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
    public partial class SettingsForm : Form
    {
        public static bool isUIShow = true, isSecureShow = false, isAboutShow = false;
        public static Language language = Language.English;
        static Color sand = Color.FromArgb(193, 181, 125), green = Color.FromArgb(99, 124, 89), blue = Color.FromArgb(103, 138, 165), pink = Color.FromArgb(206, 106, 142), black = Color.FromArgb(42, 42, 42), white = Color.FromArgb(255, 255, 255);
        static Color currentColor = sand;

        int theseChanges = MainForm.changes;
        Language thisLanguage = language;
        Theme thisTheme = MainForm.theme;
        Color thisCurrentColor = currentColor;

        public SettingsForm()
        {
            InitializeComponent();

            if (MainForm.theme == Theme.Forest)
            {
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_forest;
                ForestButton.Image = Properties.Resources.menuimage_forest_activated;
                currentColor = green;
            }
            if (MainForm.theme == Theme.Desert)
            {
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_desert;
                DesertButton.Image = Properties.Resources.menuimage_desert_activated;
                currentColor = sand;
            }
            if (MainForm.theme == Theme.Mountains)
            {
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_mountains;
                MountainsButton.Image = Properties.Resources.menuimage_mountains_activated;
                currentColor = blue;
            }
            if (MainForm.theme == Theme.City)
            {
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_city;
                CityButton.Image = Properties.Resources.menuimage_city_activated;
                currentColor = black;
            }
            if (MainForm.theme == Theme.Sunset)
            {
                MenuPanel.BackgroundImage = Properties.Resources.menuimage_sunset;
                SunsetButton.Image = Properties.Resources.menuimage_sunset_activated;
                currentColor = pink;
            }

            if (language == Language.English)
            {
                EnglishButton.ForeColor = white;
                EnglishButton.BackColor = currentColor;
                EnglishButton.FlatAppearance.BorderColor = currentColor;
                RussianButton.ForeColor = currentColor;
                RussianButton.BackColor = SystemColors.Control;
                RussianButton.FlatAppearance.BorderColor = currentColor;
            }

            if (language == Language.Russian)
            {
                EnglishButton.ForeColor = currentColor;
                EnglishButton.BackColor = SystemColors.Control;
                EnglishButton.FlatAppearance.BorderColor = currentColor;
                RussianButton.ForeColor = white;
                RussianButton.BackColor = currentColor;
                RussianButton.FlatAppearance.BorderColor = currentColor;
            }

            UIButton.Image = Properties.Resources.ui_button_activated;
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

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_default;
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_button_activated;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            MainForm.changes = theseChanges;
            currentColor = thisCurrentColor;
            language = thisLanguage;
            MainForm.theme = thisTheme;
            Close();
        }

        private void UIButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isUIShow)
                UIButton.Image = Properties.Resources.ui_button_default;
        }

        private void UIButton_MouseMove(object sender, MouseEventArgs e)
        {
            UIButton.Image = Properties.Resources.ui_button_activated;
        }

        private void SecureButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isSecureShow)
                SecureButton.Image = Properties.Resources.secure_button_default;
        }

        private void SecureButton_MouseMove(object sender, MouseEventArgs e)
        {
            SecureButton.Image = Properties.Resources.secure_button_activated;
        }

        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            if (!isAboutShow)
                AboutButton.Image = Properties.Resources.about_button_default;
        }

        private void AboutButton_MouseMove(object sender, MouseEventArgs e)
        {
            AboutButton.Image = Properties.Resources.about_button_activated;
        }

        private void ForestButton_MouseLeave(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Forest)
                ForestButton.Image = Properties.Resources.menuimage_forest;
        }

        private void ForestButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainForm.theme != Theme.Forest)
                ForestButton.Image = Properties.Resources.menuimage_forest_move;
        }

        private void DesertButton_MouseLeave(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Desert)
                DesertButton.Image = Properties.Resources.menuimage_desert;
        }

        private void DesertButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainForm.theme != Theme.Desert)
                DesertButton.Image = Properties.Resources.menuimage_desert_move;
        }

        private void MountainsButton_MouseLeave(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Mountains)
                MountainsButton.Image = Properties.Resources.menuimage_mountains;
        }

        private void MountainsButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainForm.theme != Theme.Mountains)
                MountainsButton.Image = Properties.Resources.menuimage_mountains_move;
        }

        private void CityButton_MouseLeave(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.City)
                CityButton.Image = Properties.Resources.menuimage_city;
        }

        private void CityButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainForm.theme != Theme.City)
                CityButton.Image = Properties.Resources.menuimage_city_move;
        }

        private void SunsetButton_MouseLeave(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Sunset)
                SunsetButton.Image = Properties.Resources.menuimage_sunset;
        }

        private void SunsetButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (MainForm.theme != Theme.Sunset)
                SunsetButton.Image = Properties.Resources.menuimage_sunset_move;
        }


        private void ForestButton_Click(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Forest) MainForm.changes++;
            MainForm.theme = Theme.Forest;

            ForestButton.Image = Properties.Resources.menuimage_forest_activated;
            DesertButton.Image = Properties.Resources.menuimage_desert;
            MountainsButton.Image = Properties.Resources.menuimage_mountains;
            CityButton.Image = Properties.Resources.menuimage_city;
            SunsetButton.Image = Properties.Resources.menuimage_sunset;

            currentColor = green;
        }

        private void DesertButton_Click(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Desert) MainForm.changes++;
            MainForm.theme = Theme.Desert;
            ForestButton.Image = Properties.Resources.menuimage_forest;
            DesertButton.Image = Properties.Resources.menuimage_desert_activated;
            MountainsButton.Image = Properties.Resources.menuimage_mountains;
            CityButton.Image = Properties.Resources.menuimage_city;
            SunsetButton.Image = Properties.Resources.menuimage_sunset;

            currentColor = sand;
        }

        private void MountainsButton_Click(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Mountains) MainForm.changes++;
            MainForm.theme = Theme.Mountains;
            ForestButton.Image = Properties.Resources.menuimage_forest;
            DesertButton.Image = Properties.Resources.menuimage_desert;
            MountainsButton.Image = Properties.Resources.menuimage_mountains_activated;
            CityButton.Image = Properties.Resources.menuimage_city;
            SunsetButton.Image = Properties.Resources.menuimage_sunset;

            currentColor = blue;
        }

        private void CityButton_Click(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.City) MainForm.changes++;
            MainForm.theme = Theme.City;
            ForestButton.Image = Properties.Resources.menuimage_forest;
            DesertButton.Image = Properties.Resources.menuimage_desert;
            MountainsButton.Image = Properties.Resources.menuimage_mountains;
            CityButton.Image = Properties.Resources.menuimage_city_activated;
            SunsetButton.Image = Properties.Resources.menuimage_sunset;

            currentColor = black;
        }

        private void SunsetButton_Click(object sender, EventArgs e)
        {
            if (MainForm.theme != Theme.Sunset) MainForm.changes++;
            MainForm.theme = Theme.Sunset;
            ForestButton.Image = Properties.Resources.menuimage_forest;
            DesertButton.Image = Properties.Resources.menuimage_desert;
            MountainsButton.Image = Properties.Resources.menuimage_mountains;
            CityButton.Image = Properties.Resources.menuimage_city;
            SunsetButton.Image = Properties.Resources.menuimage_sunset_activated;

            currentColor = pink;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }


        private void UIButton_Click(object sender, EventArgs e)
        {
            isUIShow = true;
            isSecureShow = false;
            isAboutShow = false;

            UIButton.Image = Properties.Resources.ui_button_activated;
            SecureButton.Image = Properties.Resources.secure_button_default;
            AboutButton.Image = Properties.Resources.about_button_default;

            UiSettingsShow();
        }

        private void SecureButton_Click(object sender, EventArgs e)
        {
            isUIShow = false;
            isSecureShow = true;
            isAboutShow = false;

            UIButton.Image = Properties.Resources.ui_button_default;
            SecureButton.Image = Properties.Resources.secure_button_activated;
            AboutButton.Image = Properties.Resources.about_button_default;

            UiSettingsHide();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            isUIShow = false;
            isSecureShow = false;
            isAboutShow = true;

            UIButton.Image = Properties.Resources.ui_button_default;
            SecureButton.Image = Properties.Resources.secure_button_default;
            AboutButton.Image = Properties.Resources.about_button_activated;

            UiSettingsHide();
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainForm.changes = theseChanges;
            currentColor = thisCurrentColor;
            language = thisLanguage;
            MainForm.theme = thisTheme;
            Close();
        }


        private void EnglishButton_Click(object sender, EventArgs e)
        {
            language = Language.English;
            EnglishButton.ForeColor = white;
            EnglishButton.BackColor = currentColor;
            RussianButton.ForeColor = currentColor;
            RussianButton.BackColor = SystemColors.Control;
        }

        private void RussianButton_Click(object sender, EventArgs e)
        {
            language = Language.Russian;
            EnglishButton.ForeColor = currentColor;
            EnglishButton.BackColor = SystemColors.Control;
            RussianButton.ForeColor = white;
            RussianButton.BackColor = currentColor;
        }


        private void UiSettingsHide()
        {
            ThemeLabel.Hide();
            ForestButton.Hide();
            DesertButton.Hide();
            MountainsButton.Hide();
            CityButton.Hide();
            SunsetButton.Hide();

            mDivider1.Hide();
            LanguageLabel.Hide();
            RussianButton.Hide();
            EnglishButton.Hide();
        }

        private void UiSettingsShow()
        {
            ThemeLabel.Show();
            ForestButton.Show();
            DesertButton.Show();
            MountainsButton.Show();
            CityButton.Show();
            SunsetButton.Show();

            mDivider1.Show();
            LanguageLabel.Show();
            RussianButton.Show();
            EnglishButton.Show();
        }
    }
}
