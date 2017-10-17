using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetOnWater
{

    public class ApiResult
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public bool water { get; set; }
    }

    public class NetOnWaterClient
    {
        public string ApiUrl {get; set;} = "https://api.onwater.io/api/v1/results/{0},{1}";

        public string ApiKey {get; set;}

        public async Task<ApiResult> GetData(string lat, string lon)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(string.Format(ApiUrl, lat, lon));
                
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
