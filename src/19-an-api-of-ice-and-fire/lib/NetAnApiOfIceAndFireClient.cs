using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetAnApiOfIceAndFire
{

    public class ApiResult
    {
        public string url { get; set; }
        public string name { get; set; }
        public string region { get; set; }
        public string coatOfArms { get; set; }
        public string words { get; set; }
        public List<string> titles { get; set; }
        public List<string> seats { get; set; }
        public string currentLord { get; set; }
        public string heir { get; set; }
        public string overlord { get; set; }
        public string founded { get; set; }
        public string founder { get; set; }
        public string diedOut { get; set; }
        public List<string> ancestralWeapons { get; set; }
        public List<object> cadetBranches { get; set; }
        public List<object> swornMembers { get; set; }
    }

    public class NetAnApiOfIceAndFireClient
    {
        public string ApiUrl {get; set;} = "https://anapioficeandfire.com/api/houses";

        public async Task<ApiResult[]> GetHouses()
        {
            ApiResult[] result = null;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(ApiUrl);
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ApiResult[]>(json);
                }
            }

            return result;
        }

        public async Task<ApiResult> GetHouse(string id)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(ApiUrl + "/" + id);
                
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
