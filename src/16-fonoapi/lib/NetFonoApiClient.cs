using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetFonoapi
{

    public class ApiResult
    {
        public string DeviceName { get; set; }
        public string Brand { get; set; }
        public string technology { get; set; }
        public string gprs { get; set; }
        public string edge { get; set; }
        public string announced { get; set; }
        public string status { get; set; }
        public string dimensions { get; set; }
        public string weight { get; set; }
        public string sim { get; set; }
        public string type { get; set; }
        public string size { get; set; }
        public string resolution { get; set; }
        public string card_slot { get; set; }
        public string alert_types { get; set; }
        public string sound_c { get; set; }
        public string wlan { get; set; }
        public string bluetooth { get; set; }
        public string gps { get; set; }
        public string radio { get; set; }
        public string usb { get; set; }
        public string messaging { get; set; }
        public string browser { get; set; }
        public string java { get; set; }
        public string colors { get; set; }
        public string sensors { get; set; }
        public string os { get; set; }
        public string video { get; set; }
        public string secondary { get; set; }
        public string speed { get; set; }
        public string chipset { get; set; }
        public string features { get; set; }
        public string protection { get; set; }
        public string multitouch { get; set; }
        public string nfc { get; set; }
    }

    public class NetFonoapiClient
    {
        public string ApiUrl {get; set;} = "https://fonoapi.freshpixl.com/v1/getdevice?device={0}&token={1}";
        public string ApiKey {get; set;}
        public async Task<ApiResult[]> GetData(string device)
        {
            ApiResult[] result = null;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(string.Format(ApiUrl, device, ApiKey));
                
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
