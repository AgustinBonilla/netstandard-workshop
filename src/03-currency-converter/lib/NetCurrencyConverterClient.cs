using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetCurrencyConverter
{
    public class ApiResult
    {
        public string From { get; set; }
        public string To { get; set; }

        [JsonProperty(PropertyName = "from_amount")]
        public int FromAmount { get; set; }

        [JsonProperty(PropertyName = "to_amount")]
        public double ToAmount { get; set; }
    }

    public class NetCurrencyConverterClient
    {
        public string ApiUrl {get; set;} = "https://currencyconverter.p.mashape.com/?from={0}&from_amount={1}&to={2}";

        public string ApiKey {get; set;}

        public async Task<ApiResult> GetData(string fromCurrency, string fromAmount, string toCurrency)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("X-Mashape-Key", ApiKey);

                var response = await client.GetAsync(string.Format(ApiUrl, fromCurrency, fromAmount, toCurrency));
                
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
