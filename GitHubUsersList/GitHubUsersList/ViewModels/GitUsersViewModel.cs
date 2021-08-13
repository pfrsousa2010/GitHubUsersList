using GitHubUsersList.AccessService;
using GitHubUsersList.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GitHubUsersList.ViewModels
{
    public class GitUsersViewModel : BaseViewModel
    {
        public ObservableRangeCollection<GitHubUser> Items { get; }

        public GitUsersViewModel()
        {
            Items = new ObservableRangeCollection<GitHubUser>();
        }

        public async void OnLoad()
        {
            var gitUsers = await Source.GetGitUsersList();

            if (gitUsers?.Count > 0)
                Items.ReplaceRange(gitUsers);
            else
                Items.Clear();
        }
    }
}
