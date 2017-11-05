# City Weather
__City Weather__ is a cross-platform Xamarin Native application that shows weather
information in cities using the [Open Weather API](http://openweathermap.org/current).

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
* Visual Studio 2017 15.14.2
* Access to Android device that runs on Android 6.0 (Marshmallow) or higher.

## Screen Shots
![Screen Shots](./doc/img/screen_shots.png)


## Projects
### CityWeather.Core
  Shared backend services, __Models__, and [MVVMCross](https://www.mvvmcross.com/documentation/) __ViewModels__
### CityWeather.Droid
  Android platform specific frontend [MVVMCross](https://www.mvvmcross.com/documentation/) __Views__
### CityWeather.Touch
  iOS platform specific frontend [MVVMCross](https://www.mvvmcross.com/documentation/) __Views__

  __Mostly completed, where I don't own iOS devices to test__
### CityWeather.Test
  [NUnit](http://nunit.org/documentation/) TDD tests for the __CityWeather.Core__ project
### CityWeather.Specs
  [Specflow](http://specflow.org/docs/) BDD feature tests

## Author
  * [Egill Anton Hlöðversson](https://github.com/egillanton) - Xamarin Developer

# License
This project is licensed under the MIT License - see the [LICENSE.md](./doc/LICENSE.md) file for details
