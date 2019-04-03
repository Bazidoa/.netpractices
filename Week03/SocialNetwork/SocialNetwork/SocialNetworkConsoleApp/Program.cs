using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNeworkClassLibrary;

namespace SocialNetworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialNetwork socialNetwork = new SocialNetwork();
            socialNetwork.AddMember("Joe");
            socialNetwork.AddMember("John");
            socialNetwork.AddMember("Jane");
            socialNetwork.AddMember("Richard");
            socialNetwork.AddMember("Balapapa");
            socialNetwork.AddMember("Dorkusz");

            socialNetwork.Connect("Joe", "John");
            socialNetwork.Connect("John", "Joe");
            socialNetwork.Connect("Richard", "John");
            socialNetwork.Connect("John", "Richard");

            socialNetwork.Connect("Balapapa", "Dorkusz");
            socialNetwork.Connect("Dorkusz", "Balapapa");

            socialNetwork.Connect("Balapapa", "Joe");
            socialNetwork.Connect("Joe", "Balapapa");

            Console.WriteLine(socialNetwork.GetBidirectionalConnections());

            Console.ReadKey();
        }
    }
}
