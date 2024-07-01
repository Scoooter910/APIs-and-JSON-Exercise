﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeUrl = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeUrl).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"{kanyeQuote}");

        }
        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            var ronResponse = client.GetStringAsync(ronUrl).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            Console.WriteLine($"{ronQuote}");
        }
    }
}
