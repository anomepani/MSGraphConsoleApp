using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGraphConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //      string[] Scopes = { "User.Read", "Mail.Send", "Files.ReadWrite" };
            //ConfidentialClientApplication cca = new ConfidentialClientApplication(
            //         "532a18b5-5c5b-4f97-846a-d8d4aff82537",
            //         "https://login.live.com/oauth20_desktop.srf",
            //         new ClientCredential("ipsuYCJ38_owfFSQR667[:-"),
            //         null,
            //         null);
            //    AuthenticationResult result = cca.AcquireTokenSilentAsync(Scopes, cca.GetAccountsAsync().Result.First()).Result;
            #region MSGraph with ClientSecret not working

            #endregion

            var graphClient=AuthenticationHelper.GetAuthenticatedClient();
            var Users = graphClient.Sites.Request().Top(400).GetAsync().Result;
            _ = JsonConvert.SerializeObject(Users);

            foreach (Microsoft.Graph.Site item in Users)
            {
                Console.WriteLine(item.Description);

            }
            Console.WriteLine(Users.Count);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
