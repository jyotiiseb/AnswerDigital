Feature: TheInternet
	

Scenario: Form Authentication
	Given I navigate to the internet homepage
	When I click 'Form Authentication' on homepage menu
	Then Login Page is displayed
	When I enter 'tomsmith' as username
	And I enter 'wrong' as password
	And I click Login button
	Then Error message 'Your password is invalid!' is displayed
	When I enter 'wrong' as username
	And I enter 'SuperSecretPassword!' as password
	And I click Login button
	Then Error message 'Your username is invalid!' is displayed
	When I enter 'tomsmith' as username
	And I enter 'SuperSecretPassword!' as password
	And I click Login button
	Then Logged in page is displayed
	When I click logout button
	Then Login Page is displayed



Scenario: Infinite Scroll
	Given I navigate to the internet homepage
	When I click 'Infinite Scroll' on homepage menu
	Then Infinite Scroll text is displayed
	When I scroll down to the page bottom
	And I scroll down to the page bottom
	And I scroll up to the top of the page
	Then Infinite Scroll text is displayed



Scenario: Key Presses
	Given I navigate to the internet homepage
	When I click 'Key Presses' on homepage menu
	Then Key Presses page is displayed
	When I enter 'Control' in text box
	Then 'You entered: CONTROL' is displayed
	When I enter 'Tab' in text box
	Then 'You entered: TAB' is displayed
	When I enter 'Alt' in text box
	Then 'You entered: ALT' is displayed
	When I enter 'Shift' in text box
	Then 'You entered: SHIFT' is displayed