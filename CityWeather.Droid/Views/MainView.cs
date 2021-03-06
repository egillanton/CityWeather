using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace CityWeather.Droid.Views
{
    [Activity(Label = "City Weather")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
