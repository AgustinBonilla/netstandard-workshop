using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetMetaweather
{

    public class ApiResult
    {
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
    }

    public class ConsolidatedWeather
    {
        public object id { get; set; }
        public string weather_state_name { get; set; }
        public string weather_state_abbr { get; set; }
        public string wind_direction_compass { get; set; }
        public DateTime created { get; set; }
        public string applicable_date { get; set; }
        public double min_temp { get; set; }
        public double max_temp { get; set; }
        public double the_temp { get; set; }
        public double wind_speed { get; set; }
        public double wind_direction { get; set; }
        public double air_pressure { get; set; }
        public int humidity { get; set; }
        public double? visibility { get; set; }
        public int predictability { get; set; }
    }

    public class Parent
    {
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
    }

    public class Source
    {
        public string title { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public int crawl_rate { get; set; }
    }

    public class WeatherResult
    {
        public List<ConsolidatedWeather> consolidated_weather { get; set; }
        public DateTime time { get; set; }
        public DateTime sun_rise { get; set; }
        public DateTime sun_set { get; set; }
        public string timezone_name { get; set; }
        public Parent parent { get; set; }
        public List<Source> sources { get; set; }
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
        public string timezone { get; set; }
    }
    
    public class NetMetaweatherClient
    {
        public string ApiUrl {get; set;} = "https://www.metaweather.com/api/location";

        public async Task<ApiResult[]> GetCities(string cityName)
        {
            ApiResult[] result = null;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(ApiUrl + "/search/?query=" + cityName);
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<ApiResult[]>(json);
                }
            }

            return result;
        }

        public async Task<WeatherResult> GetWeather(string cityId)
        {
            var result = new WeatherResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(ApiUrl + "/" + cityId);
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<WeatherResult>(json);
                }
            }

            return result;
        }
    }
}
