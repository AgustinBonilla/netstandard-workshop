using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetEmailValidator
{
    public class NetEmailValidatorResponse
    {
        public bool IsValid {get; set;}
    }

    public class NetEmailValidatorClient
    {
        public string ApiUrl {get; set;} = "https://pozzad-email-validator.p.mashape.com/emailvalidator/validateEmail/{0}";

        public string ApiKey {get; set;}

        public async Task<NetEmailValidatorResponse> GetData(string parameter)
        {
            var result = new NetEmailValidatorResponse();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("X-Mashape-Key", ApiKey);
                
                var response = await client.GetAsync(string.Format(ApiUrl, parameter));
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<NetEmailValidatorResponse>(json);
                }
            }

            return result;
        }
    }
}
