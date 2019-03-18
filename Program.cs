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
            var graphClient=AuthenticationHelper.GetAuthenticatedClient();
            var Users = graphClient.Users.Request().Top(400).GetAsync().Result;
            _ = JsonConvert.SerializeObject(Users);

            foreach (Microsoft.Graph.User item in Users)
            {
                Console.WriteLine(item.UserPrincipalName);

            }
            Console.WriteLine(Users.Count);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
