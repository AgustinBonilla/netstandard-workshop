using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetDuckDuckGoSearch
{
    public partial class ApiResult
    {
        [JsonProperty("DefinitionSource")]
        public string DefinitionSource { get; set; }

        [JsonProperty("AbstractURL")]
        public string AbstractURL { get; set; }

        [JsonProperty("AbstractSource")]
        public string AbstractSource { get; set; }

        [JsonProperty("Abstract")]
        public string Abstract { get; set; }

        [JsonProperty("AbstractText")]
        public string AbstractText { get; set; }

        [JsonProperty("AnswerType")]
        public string AnswerType { get; set; }

        [JsonProperty("Answer")]
        public string Answer { get; set; }

        [JsonProperty("Definition")]
        public string Definition { get; set; }

        [JsonProperty("Image")]
        public string Image { get; set; }

        [JsonProperty("Entity")]
        public string Entity { get; set; }

        [JsonProperty("DefinitionURL")]
        public string DefinitionURL { get; set; }

        [JsonProperty("Heading")]
        public string Heading { get; set; }

        [JsonProperty("ImageIsLogo")]
        public long ImageIsLogo { get; set; }

        [JsonProperty("ImageHeight")]
        public long ImageHeight { get; set; }

        [JsonProperty("ImageWidth")]
        public long ImageWidth { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Redirect")]
        public string Redirect { get; set; }
    }


    public class NetDuckDuckGoSearchClient
    {
        public string ApiUrl {get; set;} = "https://duckduckgo-duckduckgo-zero-click-info.p.mashape.com/?format=json&no_html=1&no_redirect=1&q={0}&skip_disambig=1";

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
