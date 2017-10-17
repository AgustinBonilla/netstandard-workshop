using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetBandsInTown
{

    public class Venue
    {
        public string name { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
    }

    public class ApiResult
    {
        public string id { get; set; }
        public string artist_event_id { get; set; }
        public string artist_id { get; set; }
        public string url { get; set; }
        public string on_sale_datetime { get; set; }
        public DateTime datetime { get; set; }
        public Venue venue { get; set; }
        public List<object> offers { get; set; }
        public List<string> lineup { get; set; }
    }

    public class NetBandsInTownClient
    {
        public string ApiUrl {get; set;} = "https://rest.bandsintown.com/artists/{0}/events?app_id=myapp";

        public async Task<ApiResult[]> GetData(string parameter)
        {
            ApiResult[] result = null;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(string.Format(ApiUrl, parameter));
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ApiResult[]>(json);
                }
            }

            return result;
        }
    }
}
