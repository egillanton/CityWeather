Feature: Get City Weather's Information
	In order to know a city's weather information
	As a user
	I want to be told the temperature, the wind speed and the humidity levels

@mytag
Scenario: Get temperature information in a city
	Given I am on the main screen
	And I have entered Paris into the search bar
	When I press Get Weather Information
	Then the result should be appear on the screen

Scenario: Get wind speed information in a city
	Given I am on the main screen
	And I have entered Paris into the search bar
	When I press Get Weather Information
	Then a brief weather summary should be appear on the screen including the city title and temperature
	When I press View Details
	Then I navigate to a detail scress
	Then the result should be appear on the screen

Scenario: Get humidity level information in a city
	Given I am on the main screen
	And I have entered Paris into the search bar
	When I press Get Weather Information
	Then a brief weather summary should be appear on the screen including the city title and temperature
	When I press View Details
	Then I navigate to a detail scress
	Then the result should be appear on the screen