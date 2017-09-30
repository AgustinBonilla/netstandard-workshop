using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetOpenlibraryBooks
{

    public class NetOpenlibraryBooksClient
    {
        public string ApiUrl { get; set; } = "https://openlibrary.org/api/books?bibkeys=ISBN:{0}&jscmd=data&format=json";

        public async Task<string> GetData(string parameter)
        {
            var result = "";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(string.Format(ApiUrl, parameter));

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = GetStringBetween(json, "\"title\": \"", "\",");
                }
            }

            return result;
        }

        private string GetStringBetween(string token, string first, string second)
        {
            if (!token.Contains(first)) return "";

            var afterFirst = token.Split(new[] { first }, StringSplitOptions.None)[1];

            if (!afterFirst.Contains(second)) return "";

            var result = afterFirst.Split(new[] { second }, StringSplitOptions.None)[0];

            return result;
        }
    }
}
