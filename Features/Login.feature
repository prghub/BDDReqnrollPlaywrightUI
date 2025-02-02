Feature: LoginTest

@mytag
Scenario: Test Login operation of application
	Given I navigate to application
	And I enter following login details
	Then I see Inventry list