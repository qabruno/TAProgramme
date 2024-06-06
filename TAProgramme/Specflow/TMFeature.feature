Feature: TMFeature

As a TurnUp portal admin user
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

@regression
Scenario: create time record with valid data
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	When I create a time record
	Then the record should be created successfully

