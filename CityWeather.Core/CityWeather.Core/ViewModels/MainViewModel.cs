using System;
using CityWeather.Core.Services;
using CityWeather.Core.Models;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;

namespace CityWeather.Core.ViewModels
{
    
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            QueryString = DefaultQueryString;
        }

        private string _defaultQueryString = "Reykjavík";
        public string DefaultQueryString { get => _defaultQueryString; set => SetProperty(ref _defaultQueryString, value); }

        private string _queryString = string.Empty;
        public string QueryString { get => _queryString; set => SetProperty(ref _queryString, value); }

        private Weather _weather;
        public Weather Weather { get => _weather; set => SetProperty(ref _weather, value); }

        private bool _isWeatherVisable;
        public bool IsWeatherVisable { get => _isWeatherVisable; set => SetProperty(ref _isWeatherVisable, value); }

        

        public IMvxCommand SearchCommand => new MvxCommand(async () =>
        {
            if (String.IsNullOrEmpty(QueryString))
            {
                QueryString = DefaultQueryString;
            }

            var openWeatherMapWeatherService = new OpenWeatherMapWeatherService();
            Weather = await openWeatherMapWeatherService.GetWeather(QueryString);
            IsWeatherVisable = true;
        });

        public IMvxCommand ViewWeatherDetailCommand => new MvxCommand(async () =>
        {
            var result = await _navigationService.Navigate<WeatherDetailViewModel, Weather, string>(Weather);

            if (!String.IsNullOrEmpty(result))
            {
                DefaultQueryString = result;
                QueryString = DefaultQueryString;
            }
        });
    }
}