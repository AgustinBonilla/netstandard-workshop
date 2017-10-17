using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetCityBikes
{

    public class Location
    {
        public string city { get; set; }
        public string country { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Extra
    {
        public string number { get; set; }
        public int slots { get; set; }
        public int uid { get; set; }
    }

    public class Station
    {
        public int empty_slots { get; set; }
        public Extra extra { get; set; }
        public int free_bikes { get; set; }
        public string id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
        public DateTime timestamp { get; set; }
    }

    public class Network
    {
        public string href { get; set; }
        public string id { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public List<Station> stations { get; set; }
        public License license { get; set; }
    }

    public class ApiResult
    {
        public List<Network> networks { get; set; }
    }

    public class NetworkResult
    {
        public Network network { get; set; }
    }

    public class NetCityBikesClient
    {
        public string ApiUrl {get; set;} = "http://api.citybik.es/v2/networks";

        public async Task<ApiResult> GetNetworks()
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(ApiUrl);
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ApiResult>(json);
                }
            }

            return result;
        }

        public async Task<NetworkResult> GetNetwork(string id)
        {
            var result = new NetworkResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(ApiUrl + "/" + id);
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<NetworkResult>(json);
                }
            }

            return result;
        }
    }
}
