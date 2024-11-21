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
                string apiUrl = "https://restcountries.com/v3.1/all";
                var response = await client.GetStringAsync(apiUrl);

                var countries = JsonConvert.DeserializeObject<List<Country>>(response);

                var states = countries.Select(c => new State
                {
                    Name = c.name.common,
                    Code = c.cca2
                }).ToList();

                return states;
            }
        }
    }

    public class Country
    {
        public Name name { get; set; }
        public string cca2 { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
    }
}
