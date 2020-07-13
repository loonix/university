using Codr.Core.Classes;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Codr.Forms
{
    public partial class Login : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // all fields are required
            if (textBoxRegName.Text == "" || textBoxRegUsername.Text == "" || TextBoxRegPassw.Text == "" || TextBoxRegPasswConf.Text == "")
            {
                MessageBox.Show("All fields are required!", "CODr | Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // in case passwords do not match throw error
            if (TextBoxRegPassw.Text != TextBoxRegPasswConf.Text)
            {
                MessageBox.Show("The passwords do not match!", "CODr | Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool userLogin = ClassLogin.Register(textBoxRegName.Text, textBoxRegUsername.Text, TextBoxRegPassw.Text);
            if (userLogin)
            {
                tabControl1.SelectedTab = loginTab; // redirects user to login with new credentials
            }
            else
            {
                MessageBox.Show("Unable to create an account!", "CODr | Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearRegisterFields(); // clears fields
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // username and password are required
            if (TextBoxLoginPassword.Text == "" || textBoxLoginUsername.Text == "")
            {
                MessageBox.Show("Username and password fields are required!", "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool userLogin = ClassLogin.SignIn(textBoxLoginUsername.Text, TextBoxLoginPassword.Text);
            if (userLogin)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("The username or password are incorrect!", "CODr | Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearLoginFields();
        }

        /// <summary>
        /// Clears all login tab fields
        /// </summary>
        private void ClearLoginFields()
        {
            TextBoxLoginPassword.Clear();
            textBoxLoginUsername.Clear();
        }

        /// <summary>
        /// Clears all register tab fields
        /// </summary>
        private void ClearRegisterFields()
        {
            textBoxRegName.Clear();
            textBoxRegUsername.Clear();
            TextBoxRegPassw.Clear();
            TextBoxRegPasswConf.Clear();
        }

        private void TextBoxLoginPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
