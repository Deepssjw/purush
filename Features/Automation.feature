Feature: Automation

Background:
	Given the user is on the login page



@Google
Scenario: Test login
	Given open the browser
	When Enter the URL
	And Enter the Username
	And Enter the Password
	And Click the Submit button
	Then Close the browser

@Google1
Scenario: Test login1

	Given open the browser
	When Enter the URL
	And Enter the invalidUsername
	And Enter the invalidcPassword
	And Click the Submit button
	Then Close the browser

