using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetEarthquakes
{

    public class Metadata
    {
        public long generated { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string api { get; set; }
        public int count { get; set; }
    }

    public class Properties
    {
        public double mag { get; set; }
        public string place { get; set; }
        public long time { get; set; }
        public long updated { get; set; }
        public int tz { get; set; }
        public string url { get; set; }
        public string detail { get; set; }
        public int felt { get; set; }
        public double cdi { get; set; }
        public double mmi { get; set; }
        public object alert { get; set; }
        public string status { get; set; }
        public int tsunami { get; set; }
        public int sig { get; set; }
        public string net { get; set; }
        public string code { get; set; }
        public string ids { get; set; }
        public string sources { get; set; }
        public string types { get; set; }
        public object nst { get; set; }
        public double dmin { get; set; }
        public double rms { get; set; }
        public int gap { get; set; }
        public string magType { get; set; }
        public string type { get; set; }
        public string title { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
        public string id { get; set; }
    }

    public class ApiResult
    {
        public string type { get; set; }
        public Metadata metadata { get; set; }
        public List<Feature> features { get; set; }
    }

    public class NetEarthquakesClient
    {
        public string ApiUrl {get; set;} = "https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={0}&endtime={1}&minmagnitude={2}";

        public async Task<ApiResult> GetData(string fromDate, string toDate, string magnitude)
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(string.Format(ApiUrl, fromDate, toDate, magnitude ));
                
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
