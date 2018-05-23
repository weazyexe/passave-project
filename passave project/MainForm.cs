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
        public MainForm()
        {
            InitializeComponent();
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //// 1 - bar (name), 2 - upper bar, 3 - ?, 4 - primary color tabpage, 5 - text color (theme)
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Green100, Accent.Blue400, TextShade.BLACK);
        }

        private void SNButton_MouseLeave(object sender, EventArgs e)
        {
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
            EmailButton.Image = Properties.Resources.email_button_default;
        }

        private void HomebankingButton_MouseMove(object sender, MouseEventArgs e)
        {
            HomebankingButton.Image = Properties.Resources.homebanking_button_activated;
        }

        private void HomebankingButton_MouseLeave(object sender, EventArgs e)
        {
            HomebankingButton.Image = Properties.Resources.homebanking_button_default;
        }

        private void LicensesButton_MouseMove(object sender, MouseEventArgs e)
        {
            LicensesButton.Image = Properties.Resources.licenses_button_activated;
        }

        private void LicensesButton_MouseLeave(object sender, EventArgs e)
        {
            LicensesButton.Image = Properties.Resources.licenses_button_default;
        }

        private void OtherButton_MouseLeave(object sender, EventArgs e)
        {
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
    }
}
