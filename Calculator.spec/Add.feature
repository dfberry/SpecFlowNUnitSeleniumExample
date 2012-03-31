Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
    Given I am on calculator page
	Given I have entered 50 into 'first' of the calculator
	And I have entered 70 into 'second' of the calculator
	When I press add
	Then the result should be 120 on the screen
