using Microsoft.Owin.Hosting;
using System;

namespace SignalR_Chat_SelfHost_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx 
            // for more information.
            string url = "http://localhost:8080";
            using (WebApp.Start(url))
            {
                Console.WriteLine("SignalR Server running on {0}", url);
                Console.ReadLine();
            }
        }

        public static void LogReceivedMessages(string name, string message)
        {
            Console.WriteLine("Message received => [{0}: {1}] ", name, message);
        }
    }
}
