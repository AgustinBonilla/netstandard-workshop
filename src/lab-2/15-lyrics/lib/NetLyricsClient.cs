using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetLyrics
{

    public class ApiResult
    {
        public string lyrics { get; set; }
    }

    public class NetLyricsClient
    {
        public string ApiUrl {get; set;} = "https://api.lyrics.ovh/v1/{0}/{1}";

        public async Task<ApiResult> GetData(string artist, string song)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(string.Format(ApiUrl, artist, song));
                
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
