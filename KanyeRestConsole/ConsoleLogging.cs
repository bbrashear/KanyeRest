using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace KanyeRestConsole
{
    internal class ConsoleLogging
    {
        internal static void Chat(HttpClient client, string kanyeURL, string ronURL)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {ServiceCalls.GetKanyeQuote(client, kanyeURL)}");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine($"Ron: {ServiceCalls.GetRonQuote(client, ronURL)}");
                Thread.Sleep(2000);
            }
        }
    }
}
