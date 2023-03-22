using System;
using System.ComponentModel;
using System.Security.AccessControl;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace FinalBreweryAPI.Models
{
    //By State with addition of Drop Down State list
    //public async Task<Items> BreweryAPICall(string state)

    public class APICall
    {
        public static List<Root> BreweryAPICall()
        {
            
            var items = new Items();
            var client = new RestClient($"https://brianiswu-open-brewery-db-v1.p.rapidapi.com/breweries?by_state=Missouri");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "95e6116b23mshd25623c7e1eef4ap1fdb4fjsn3841aa601faf");
            request.AddHeader("X-RapidAPI-Host", "brianiswu-open-brewery-db-v1.p.rapidapi.com");
            var response = client.Execute(request).Content;
            var roots = JsonConvert.DeserializeObject<List<Root>>(response);

            return roots;
        }

    }
}
