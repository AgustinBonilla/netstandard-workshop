using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetCitySunset
{

    public class ApiResult
    {
        public DateTime Dawn { get; set; }
        public DateTime? Sunset { get; set; }
        public DateTime? Noon { get; set; }
        public DateTime? Sunrise { get; set; }
        public DateTime? Dusk { get; set; }
    }

    public class NetCitySunsetClient
    {
        public string ApiUrl {get; set;} = "https://sun.p.mashape.com/api/sun/?city={0}";

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
