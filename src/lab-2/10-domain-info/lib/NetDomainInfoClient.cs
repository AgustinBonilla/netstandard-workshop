using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace NetDomainInfo
{

    public class Domain
    {
        public List<string> mx { get; set; }
        public List<object> blacklist { get; set; }
        public List<object> blacklist_ns { get; set; }
        public List<object> blacklist_mx { get; set; }
        public List<string> ns { get; set; }
        public int score { get; set; }
    }

    public class Geo
    {
        public string city { get; set; }
        public string postal { get; set; }
        public string region { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string continent { get; set; }
        public string hostname { get; set; }
        public string address { get; set; }
        public string country { get; set; }
    }

    public class Ip
    {
        public Geo geo { get; set; }
        public List<object> blacklist { get; set; }
        public int score { get; set; }
        public bool is_quarantined { get; set; }
    }

    public class Geo2
    {
    }

    public class SourceIp
    {
        public Geo2 geo { get; set; }
        public List<object> blacklist { get; set; }
        public int score { get; set; }
        public bool is_quarantined { get; set; }
    }

    public class Response
    {
        public Domain domain { get; set; }
        public Ip ip { get; set; }
        public SourceIp source_ip { get; set; }
        public int score { get; set; }
    }

    public class ApiResult
    {
        public Response response { get; set; }
        public string type { get; set; }
    }

    public class NetDomainInfoClient
    {
        public string ApiUrl { get; set; } = "https://moocher-io-domain-reputation-v1.p.mashape.com/";

        public string ApiKey { get; set; }

        public async Task<ApiResult> GetData(string parameter)
        {
            var result = new ApiResult();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Mashape-Key", ApiKey);//ApiKey header

                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders
                      .Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

                var request = new HttpRequestMessage(HttpMethod.Post, "relativeAddress")
                {
                    RequestUri = new Uri(ApiUrl + parameter),
                    Method = HttpMethod.Get,
                    Content = new StringContent("", Encoding.UTF8, "application/json")//CONTENT-TYPE header
                };

                var json = string.Empty;
                await client.SendAsync(request)
                      .ContinueWith(responseTask =>
                      {
                          json = responseTask.Result.Content.ReadAsStringAsync().Result;
                          result = JsonConvert.DeserializeObject<ApiResult>(json);

                      });

            }

            return result;
        }
    }
}
