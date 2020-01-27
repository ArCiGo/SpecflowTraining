Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatory fields
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all mandatory details in form
	| Name    | Age | Phone      | Email                         |
	| karthik | 28  | 9098023842 | karthik@executeautomation.com |
	| ArCiGo | 27  | 8331215265 | acifuentes@luxoft.com |
	| ElCiGo | 25  | 111111 | elizabethcifuentes_1@hotmail.com |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with mandatory fields for different iteration
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples: 
	| Name    | Age | Phone      |
	| karthik | 28  | 9098023842 | 
	| ArCiGo | 27  | 8331215265 |
	| ElCiGo | 25  | 111111 |

Scenario: Check if I could get the details entered via Table from Extended Steps
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email                 |
	| Karthik | 28  | 1234567890 | acifuentes@luxoft.com |
	Then I should get the same value from Extended Steps