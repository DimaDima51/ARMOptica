using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMOptica
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            //вызываем метод авторизации и передаем введенные логин и пароль
            DBConnection.Authorization(txtLogin.Text, txtPassword.Text);
            if (DBConnection.User == null)
                MessageBox.Show("Неверный логин или пароль!");
            else
            {
                this.Hide();
                HeadForm CFCustomers = new HeadForm();
                CFCustomers.Show();
            }

        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connect()) //если соединение не установлено
            {
                this.Close(); //выход из программы
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            DBConnection.Close();
            Application.Exit();
        }

    }
}
