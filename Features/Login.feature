@Login
Feature: Login
	As a client
	I want to be able to use my credentials 
	In order to log in into the app

Background:
	Given I navigate to Licenta app
	And I navigate to Login page

@SmokeTests
Scenario: Successfully login using an admin
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A

@SmokeTests
Scenario: Successfully login using an usual customer
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C

@RegressionTests
Scenario: Successfully disconnect from the App
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I choose to disconnect from Licenta app
	Then I'm successfully disconnected: Pentru a putea utiliza toate functionalitatile, te rugam sa te conectezi.

@RegressionTests
Scenario: Error when logging in with wrong credentials
	When I log in with the following credentials
		| key      | value       |
		| username | admin123    |
		| password | Admin@12345 |
	Then the following warning message is displayed: Parola nu este corecta!
