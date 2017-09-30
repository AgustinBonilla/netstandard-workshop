using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetCotizacionBCU
{

    public class Dato
    {
        public string codigo { get; set; }
        public string texto { get; set; }
        public string compra { get; set; }
        public string venta { get; set; }
    }

    public class ApiResult
    {
        public bool result { get; set; }
        public string mensaje { get; set; }
        public List<Dato> datos { get; set; }
    }

    public class NetCotizacionBCUClient
    {
        public string ApiUrl {get; set;} = "http://webservice.solcre.com/cotizacion?backdoor=letmein";

        public async Task<ApiResult> GetData()
        {
            var result = new ApiResult();
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(string.Format(ApiUrl));
                
                if(response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    json = json.TrimStart('(').TrimEnd(')'); 
                    result = JsonConvert.DeserializeObject<ApiResult>(json);
                }
            }

            return result;
        }
    }
}
