using Newtonsoft.Json;

namespace FinalBreweryAPI.Models
{
    public class Items
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("brewery_type")]
        public string BreweryType { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("address_2")]
        public string? Address2 { get; set; }

        [JsonProperty("address_3")]
        public string? Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county_providence")]
        public string? CountyProvidence { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("phone")]
        public double? Phone { get; set; }

        [JsonProperty("website_url")]
        public string? WebsiteURL { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}
