using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace CityWeather.Touch.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, Core.ViewModels.MainViewModel>();
            set.Bind(QueryStringTextField).To(vm => vm.QueryString);
            set.Bind(WeatherSummaryStackView).For("Visibility").To(vm => vm.IsWeatherVisable);
            set.Bind(WeatherTitleTextField).To(vm => vm.Weather.Title);
            set.Bind(WeatherTemperatureTextField).To(vm => vm.Weather.Temperature);
            set.Bind(SearchButton).To(vm => vm.SearchCommand);
            set.Bind(ViewWeatherDetailButton).To(vm => vm.ViewWeatherDetailCommand);
            set.Apply();
        }
    }
}
