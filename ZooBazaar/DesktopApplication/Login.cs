using Data;
using DesktopApplication.Adminstration.Employees;
using DesktopApplication.Scheduler.Animals;
using DesktopApplication.Scheduler.Employees;
using Logic;
using Logic.Classes.Accounts;
using Logic.Enums;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class LoginForm : Form
    {
        private ILoginManager login;
        private AccountTypes _accountTypes;

        public LoginForm(AccountTypes accountTypes)
        {
            InitializeComponent();

            login = new AccountsManager();
            _accountTypes = accountTypes;
  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            _accountTypes = AccountTypes.NoAccount;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _accountTypes = AccountTypes.NoAccount;
                MessageBox.Show("Please fill in all fields");
                return;
            }
            else
            {
                if (login.IsAdmin(username, password))
                {
                    _accountTypes = AccountTypes.Admin;
                    ALoginOptionsForm aLoginOptionsForm = new ALoginOptionsForm(_accountTypes);
                    aLoginOptionsForm.SetEmployeeButtonBackgroundCoulour();
                    aLoginOptionsForm.Show();
                    this.Hide();
                    return;
                }
                else if (login.IsScheduler(username, password))
                {
                    _accountTypes = AccountTypes.Scheduler;
                    SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(_accountTypes);
                    sLoginOptionsForm.SetBackGroundColourEmployeeButton();
                    sLoginOptionsForm.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    _accountTypes = AccountTypes.NoAccount;
                    MessageBox.Show("username and password does not match");
                    return;
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
