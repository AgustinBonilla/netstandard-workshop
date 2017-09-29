using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ip2CountryNet
{
    public class Ip2CountryResponse
    {
        public string CountryCode { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryName { get; set; }
        public string CountryEmoji { get; set; }
    }

    public class Ip2CountryClient
    {
        public string ApiUrl {get; set;} = "https://api.ip2country.info/ip?{0}";
        public async Task<Ip2CountryResponse> GetData(string ip)
        {
            var result = new Ip2CountryResponse();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                
                var response = await client.GetAsync(string.Format(ApiUrl, ip));
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<Ip2CountryResponse>(json);
                }
            }

            return result;
        }

    }
}
