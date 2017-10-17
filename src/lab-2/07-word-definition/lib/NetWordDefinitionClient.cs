using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetWordDefinition
{

    public class ApiResult
    {
        public string Definition { get; set; }
        public object Error { get; set; }
        public string Word { get; set; }
    }

    public class NetWordDefinitionClient
    {
        public string ApiUrl {get; set;} = "https://aplet123-wordnet-search-v1.p.mashape.com/master?word={0}";

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
