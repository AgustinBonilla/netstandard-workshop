using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetIextradingStocks
{
    public class ApiResult
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public double open { get; set; }
        public long openTime { get; set; }
        public double close { get; set; }
        public long closeTime { get; set; }
        public double latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public long latestUpdate { get; set; }
        public int latestVolume { get; set; }
        public double iexRealtimePrice { get; set; }
        public int iexRealtimeSize { get; set; }
        public long iexLastUpdated { get; set; }
        public double delayedPrice { get; set; }
        public long delayedPriceTime { get; set; }
        public double previousClose { get; set; }
        public double change { get; set; }
        public double changePercent { get; set; }
        public double iexMarketPercent { get; set; }
        public int iexVolume { get; set; }
        public int avgTotalVolume { get; set; }
        public int iexBidPrice { get; set; }
        public int iexBidSize { get; set; }
        public int iexAskPrice { get; set; }
        public int iexAskSize { get; set; }
        public long marketCap { get; set; }
        public double peRatio { get; set; }
        public double week52High { get; set; }
        public double week52Low { get; set; }
        public double ytdChange { get; set; }
    }

    public class NetIextradingStocksClient
    {
        public string ApiUrl {get; set;} = "https://api.iextrading.com/1.0/stock/{0}/quote";

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
