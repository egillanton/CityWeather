using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace CityWeather.Touch.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class WeatherDetailView : MvxViewController
    {
        public WeatherDetailView() : base("WeatherDetailView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<WeatherDetailView, Core.ViewModels.WeatherDetailViewModel>();
            set.Bind(SetAsDefultCityButton).To(vm => vm.SetAsDefultCityCommand);
            set.Bind(WeatherHumidityTextField).To(vm => vm.CurrentWeather.Humidity);
            set.Bind(WeatherSunriseTextField).To(vm => vm.CurrentWeather.Sunrise);
            set.Bind(WeatherSunsetTextField).To(vm => vm.CurrentWeather.Sunset);
            set.Bind(WeatherTemperatureTextField).To(vm => vm.CurrentWeather.Temperature);
            set.Bind(WeatherTitleTextField).To(vm => vm.CurrentWeather.Title);
            set.Bind(WeatherVisibilityTextField).To(vm => vm.CurrentWeather.Visibility);
            set.Bind(WeatherWindTextField).To(vm => vm.CurrentWeather.Wind);
            set.Apply();
        }
    }
}
