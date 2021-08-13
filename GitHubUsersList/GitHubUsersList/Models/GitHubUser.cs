using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace GitHubUsersList.Models
{
    public class GitHubUser : ObservableObject
    {
        #region fields
        string login;
        int id;
        string profilePicture;
        string htmlUrl;
        string followers;
        #endregion

        [JsonPropertyName("login")]
        public string Login
        {
            get => login;
            set => SetProperty(ref login, value);
        }

        [Key]
        [JsonPropertyName("id")]
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }        

        [JsonPropertyName("avatar_url")]
        public string ProfilePicture
        {
            get => profilePicture;
            set => SetProperty(ref profilePicture, value);
        }

        [JsonPropertyName("html_url")]
        public string HtmlUrl
        {
            get => htmlUrl;
            set => SetProperty(ref htmlUrl, value);
        }

        [JsonPropertyName("followers_url")]
        public string Followers
        {
            get => followers;
            set => SetProperty(ref followers, value);
        }
    }
}
