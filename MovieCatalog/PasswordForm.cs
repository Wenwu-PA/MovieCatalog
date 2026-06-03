using System;
using System.Drawing;
using System.Windows.Forms;

namespace VideoLibrary
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            Size = new Size(450, 250);
            Text = "Вход для администратора";
        }

        private void BtnConfirmPwd_Click(object sender, EventArgs e)
        {
            if (PasswordManager.VerifyPassword(textBoxPwd.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}