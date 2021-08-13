using GitHubUsersList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GitHubUsersList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GitUsersPageList : ContentPage
    {
        public GitUsersViewModel ViewModel { get; }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public GitUsersPageList()
        {
            ViewModel = new GitUsersViewModel();
            BindingContext = ViewModel;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnLoad();
        }
    }
}