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
        public SettingsForm()
        {
            InitializeComponent();
        }

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
            Close();
        }

        private void UIButton_MouseLeave(object sender, EventArgs e)
        {
            UIButton.Image = Properties.Resources.ui_button_default;
        }

        private void UIButton_MouseMove(object sender, MouseEventArgs e)
        {
            UIButton.Image = Properties.Resources.ui_button_activated;
        }

        private void SecureButton_MouseLeave(object sender, EventArgs e)
        {
            SecureButton.Image = Properties.Resources.secure_button_default;
        }

        private void SecureButton_MouseMove(object sender, MouseEventArgs e)
        {
            SecureButton.Image = Properties.Resources.secure_button_activated;
        }

        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            AboutButton.Image = Properties.Resources.about_button_default;
        }

        private void AboutButton_MouseMove(object sender, MouseEventArgs e)
        {
            AboutButton.Image = Properties.Resources.about_button_activated;
        }
    }
}
