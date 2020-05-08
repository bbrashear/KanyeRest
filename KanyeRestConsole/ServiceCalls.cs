using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeRestConsole
{
    static class ServiceCalls
    {
        public static string GetKanyeQuote(HttpClient client, string url)
        {
            var kanyeResponse = client.GetStringAsync(url).Result;
            return JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        }

        public static string GetRonQuote(HttpClient client, string url)
        {
            var ronResponse = client.GetStringAsync(url).Result;
            return JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        }
    }
}
