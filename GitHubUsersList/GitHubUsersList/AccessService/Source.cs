using GitHubUsersList.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace GitHubUsersList.AccessService
{
    public static class Source
    {
        static HttpClient client = new HttpClient();

        public static async Task<IList<GitHubUser>> GetGitUsersList()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.github.com/users")
            };

            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<GitHubUser>>(jsonString);
                }
            }

            return null;
        }

        public static User GetAdm()
        {
            return new User { Login = "Admin", Password = "1234" };
        }
    }
}
