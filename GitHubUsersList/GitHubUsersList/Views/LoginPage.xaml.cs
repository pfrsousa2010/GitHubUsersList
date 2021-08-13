using GitHubUsersList.ViewModels;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitHubUsersList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel ViewModel { get; }
        public LoginPage()
        {
            ViewModel = new LoginViewModel();
            ViewModel.GitUsers = new AsyncCommand(GoGitUsersList);
            BindingContext = ViewModel;
            InitializeComponent();
        }

        private async Task GoGitUsersList()
        {
            await Navigation.PushAsync(new GitUsersPageList());
        }
    }
}