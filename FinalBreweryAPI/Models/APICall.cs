using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FinalBreweryAPI.Models
{
    public class APICall
    {
        public async Task<Items> BreweryAPICall()
        {
            var client = new HttpClient();

            

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com/breweries"),
                Headers =
                {
                    { "X-RapidAPI-Key", "95e6116b23mshd25623c7e1eef4ap1fdb4fjsn3841aa601faf" },
                    { "X-RapidAPI-Host", "brianiswu-open-brewery-db-v1.p.rapidapi.com" },
                },
            };


            //var brewObject = ;
            var body = "";
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            var brewObject = JArray.Parse(body);
            //Console.WriteLine(brewObject);
            var items = new Items()
            {
                Name = brewObject[0]["name"].ToString(),
                WebsiteURL = brewObject[0]["website_url"].ToString(),
                Street = brewObject[0]["street"].ToString(),
                Phone = ((double)brewObject[0]["phone"]),

            };
            //items.Name = brewObject[0]["name"].ToString();
            //items.WebsiteURL = brewObject[14];
            return items;


            //return brewObject;
        }
    }
}
