using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetIpBlacklist
{

    public class Content
    {
        public int Blacklisted { get; set; }
    }

    public class ApiResult
    {
        public string Status { get; set; }
        public Content Content { get; set; }
    }

    public class NetIpBlacklistClient
    {
        public string ApiUrl {get; set;} = "https://tony11-blacklist-ip-v1.p.mashape.com/ipv4/{0}";

        public string ApiKey {get; set;}

        public async Task<ApiResult> GetData(string parameter)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("X-Mashape-Key", ApiKey);

                var response = await client.GetAsync(string.Format(ApiUrl, parameter));
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ApiResult>(json);
                }
            }

            return result;
        }
    }
}
