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
    [Register ("WeatherDetailView")]
    partial class WeatherDetailView
    {
        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton SetAsDefultCityButton { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherHumidityTextField { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherSunriseTextField { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherSunsetTextField { get; set; }


        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherTemperatureTextField { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherTitleTextField { get; set; }


        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherVisibilityTextField { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField WeatherWindTextField { get; set; }


        void ReleaseDesignerOutlets ()
        {
            if (SetAsDefultCityButton != null)
            {
                SetAsDefultCityButton.Dispose();
                SetAsDefultCityButton = null;
            }

            if (WeatherHumidityTextField != null)
            {
                WeatherHumidityTextField.Dispose();
                WeatherHumidityTextField = null;
            }

            if (WeatherSunriseTextField != null)
            {
                WeatherSunriseTextField.Dispose();
                WeatherSunriseTextField = null;
            }

            if (WeatherSunsetTextField != null)
            {
                WeatherSunsetTextField.Dispose();
                WeatherSunsetTextField = null;
            }

            if (WeatherTemperatureTextField != null)
            {
                WeatherTemperatureTextField.Dispose();
                WeatherTemperatureTextField = null;
            }

            if (WeatherTitleTextField != null)
            {
                WeatherTitleTextField.Dispose();
                WeatherTitleTextField = null;
            }

            if (WeatherVisibilityTextField != null)
            {
                WeatherVisibilityTextField.Dispose();
                WeatherVisibilityTextField = null;
            }

            if (WeatherWindTextField != null)
            {
                WeatherWindTextField.Dispose();
                WeatherWindTextField = null;
            }
        }
    }
}