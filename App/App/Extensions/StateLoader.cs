using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace App.Extensions
{
    public class State
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public static class StateLoader
    {
        public static async Task<List<State>> GetStatesFromApiAsync()
        {
            using (var client = new HttpClient())
            {
                string apiUrl = "https://countriesnow.space/api/v0.1/countries/";
                var response = await client.GetStringAsync(apiUrl);

                var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(response);

                if (apiResponse == null || apiResponse.Data == null)
                {
                    throw new Exception("Invalid response or no data returned from API.");
                }

                var states = apiResponse.Data.Select(c => new State
                {
                    Name = c.Country,
                    Code = c.Iso2
                }).ToList();

                return states;
            }
        }
    }

    public class ApiResponse
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public List<Countri> Data { get; set; }
    }
    public class Countri
    {
        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        [JsonProperty("iso3")]
        public string Iso3 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("cities")]
        public List<string> Cities { get; set; }
    }
}
