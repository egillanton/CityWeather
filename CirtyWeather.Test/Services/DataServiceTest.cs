using System;
using System.Net.Http;
using NUnit.Framework;
using CityWeather.Core.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CirtyWeather.Test.Services
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CanGetDataFromService()
        {
            //API Documentation: http://openweathermap.org/current
            var cityName = "Paris";
            var apiKey = "c9289d68a25eb2fb65a37d2a925491f3";
            var queryString = $"http://api.openweathermap.org/data/2.5/weather?q={cityName},&appid={apiKey}";

            var dataService = new DataService();
            var actual = dataService.GetDataFromService(queryString);
            actual.Wait();



            JContainer expected = null;

            HttpClient client = new HttpClient();
            var response = client.GetAsync(queryString);
            response.Wait();

            if (response != null)
            {
                var json = response.Result.Content.ReadAsStringAsync();
                json.Wait();
                expected = (JContainer)JsonConvert.DeserializeObject(json.Result);
            }

            Assert.AreEqual(expected, actual.Result);
        }
    }
}
