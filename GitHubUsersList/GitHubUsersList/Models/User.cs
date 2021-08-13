using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GitHubUsersList.Models
{
    public class User : ObservableObject
    {
        #region fields
        string login;
        string password;
        Guid id;
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

        [Key]
        public Guid Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public User()
        {
            Id = Guid.NewGuid();
        }


    }
}
