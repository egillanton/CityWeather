// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CityWeather.Touch.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SearchButton { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton ViewWeatherDetailButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField QueryStringTextField { get; set; }


        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIStackView WeatherSummaryStackView { get; set; }
        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherTitleTextField { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherTemperatureTextField { get; set; }


        void ReleaseDesignerOutlets ()
        {
            if (QueryStringTextField != null)
            {
                QueryStringTextField.Dispose();
                QueryStringTextField = null;
            }

            if (SearchButton != null) {
                SearchButton.Dispose ();
                SearchButton = null;
            }

            if (WeatherTitleTextField != null)
            {
                WeatherTitleTextField.Dispose();
                WeatherTitleTextField = null;
            }

            if (WeatherTemperatureTextField != null)
            {
                WeatherTemperatureTextField.Dispose();
                WeatherTemperatureTextField = null;
            }

            if (ViewWeatherDetailButton != null)
            {
                ViewWeatherDetailButton.Dispose();
                ViewWeatherDetailButton = null;
            }

            if (WeatherSummaryStackView != null)
            {
                WeatherSummaryStackView.Dispose();
                WeatherSummaryStackView = null;
            }
        }
    }
}