using GitHubUsersList.AccessService;
using GitHubUsersList.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GitHubUsersList.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region fields
        string login;
        string password;
        bool validation;
        User administrator;
        #endregion

        public string Login
        {
            get => login;
            set => SetProperty(ref login, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public bool Validation
        {
            get => validation;
            set => SetProperty(ref validation, value);
        }

        public User Admin
        {
            get => administrator;
            set => SetProperty(ref administrator, value);
        }

        public ICommand EnterCommand { get; }
        public ICommand GitUsers { get; set; }


        public LoginViewModel()
        {
            EnterCommand = new Command(Enter);
            Admin = Source.GetAdm();
        }

        private void Enter()
        {
            if (Admin.Login.ToLower() == Login?.ToLower() && Admin.Password == Password)
            {
                Validation = false;
                Login = null;
                Password = null;
                GitUsers?.Execute(null);
            }
            else
                Validation = true;
        }

    }
}
