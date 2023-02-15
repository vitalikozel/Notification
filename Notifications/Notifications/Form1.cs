using Notifications.Controllers.Authuntification;
using Notifications.Domain.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notifications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InputLogin_Click(object sender, EventArgs e)
        {
            InputLogin.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            InputPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();

            User userToLogin = new User();

            userToLogin.Name = InputLogin.Text;
            userToLogin.Password = InputPassword.Text;

            if (login.IsEnteredCurrectData(userToLogin))
            {
                LoginUser.Text = $"Hi {userToLogin.Name}!";
            }
            else
            {
                LoginUser.Text = $"Error data!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationNewUser registration = new RegistrationNewUser();

            User userToRegister = new User();

            userToRegister.Name = InputLogin.Text;
            userToRegister.Password = InputPassword.Text;

            registration.Registration(userToRegister);
        }
    }
}
