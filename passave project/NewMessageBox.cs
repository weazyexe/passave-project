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
    public partial class NewMessageBox : Form
    {
        MessageBoxButtons mbb = MessageBoxButtons.OK;

        public NewMessageBox(string message, string header = "ATTENTION", MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            InitializeComponent();
            HeaderLabel.Text = header;
            MessageTextBox.Text = message;
            mbb = buttons;
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
