using CityWeather.Core.Models;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace CityWeather.Core.ViewModels
{
    public class WeatherDetailViewModel : MvxViewModel<Weather, string>
    {
        private readonly IMvxNavigationService _navigationService;
        public WeatherDetailViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Prepare(Weather weather)
        {
            CurrentWeather = weather;
        }

        private Weather _currentWeather;
        public Weather CurrentWeather { get => _currentWeather; set => SetProperty(ref _currentWeather, value); }


        public IMvxCommand SetAsDefultCityCommand => new MvxCommand(async () =>
        {
            await _navigationService.Close(this, CurrentWeather.Title);
        });
    }
}
