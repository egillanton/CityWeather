using System;
using System.Threading.Tasks;
using CityWeather.Core.Models;

namespace CityWeather.Core.Services
{
    class OpenWeatherMapWeatherService : IWeatherService
    {

        public async Task<Weather> GetWeather(string cityName)
        {
            //API Documentation: http://openweathermap.org/current
            var apiKey = "c9289d68a25eb2fb65a37d2a925491f3";
            var queryString = $"http://api.openweathermap.org/data/2.5/weather?q={cityName},&appid={apiKey}";

            var dataService = new DataService();
            var results = await dataService.GetDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                var time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                var sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                var sunset = time.AddSeconds((double)results["sys"]["sunset"]);

                var weather = new Weather
                {
                    Title = (string)results["name"],
                    Temperature = (string)results["main"]["temp"] + " °F",
                    Wind = (string)results["wind"]["speed"] + " mph",
                    Humidity = (string)results["main"]["humidity"] + " %",
                    Visibility = (string)results["weather"][0]["main"],
                    Sunrise = sunrise + " UTC",
                    Sunset = sunset + " UTC"
                };
                return weather;
            }
            return null;
        }
    }
}
