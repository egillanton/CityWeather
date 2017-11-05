using CityWeather.Core.Models;
using NUnit.Framework;

namespace CirtyWeather.Test.Models
{
    [TestFixture]
    public class WeatherTest
    {
        [Test]
        public void IsWeatherEqualWorkingAsExpected()
        {
            var weather1 = new Weather
            {
                Title = "Paris"
            };

            var weather2 = new Weather
            {
                Title = "Paris"
            };
            Assert.AreEqual(weather1, weather2);
        }
    }
}
