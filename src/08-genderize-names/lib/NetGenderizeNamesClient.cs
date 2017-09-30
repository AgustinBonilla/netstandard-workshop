using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetGenderizeNames
{

    public class ApiResult
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Probability { get; set; }
        public int Count { get; set; }
    }

    public class NetGenderizeNamesClient
    {
        public string ApiUrl {get; set;} = "https://api.genderize.io/?name={0}";

        public string ApiKey {get; set;}

        public async Task<ApiResult> GetData(string parameter)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

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
