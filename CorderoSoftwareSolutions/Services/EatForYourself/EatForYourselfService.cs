using CorderoSoftwareSolutions.Models.EatForYourself;
using MongoDB.Bson.IO;
using RestSharp;
using System.Net;
using Newtonsoft.Json;

namespace CorderoSoftwareSolutions.Services.EatForYourself
{
    public class EatForYourselfService : IEatForYourselfService
    {
        private IConfiguration _iConfig;

        public EatForYourselfService(IConfiguration iConfig)
        {
            _iConfig = iConfig;
        }

        public async Task<EatForYourselfResult?> USDASearch(EatForYourselfSearch eat)
        {
            string endpoint = "";

            endpoint = string.IsNullOrEmpty(eat.Company) ?
                $"https://api.nal.usda.gov/fdc/v1/foods/search?api_key={_iConfig.GetValue<string>("USDA_Api")}&query={eat.FoodDescription}"
                : $"https://api.nal.usda.gov/fdc/v1/foods/search?api_key={_iConfig.GetValue<string>("USDA_Api")}&query={eat.FoodDescription}&brandOwner={eat.Company}";

            var options = new RestClientOptions(endpoint);

            var client = new RestClient(options);

            var request = new RestRequest()
            {
                Method = Method.Get
            };

            RestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(response.Content))
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<EatForYourselfResult>(response.Content);
            }
            else
            {
                return null;
            }

        }
    }
}
