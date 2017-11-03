﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityWeather.Core.Models;

namespace CityWeather.Core.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetWeather(string cityName);
    }
}
