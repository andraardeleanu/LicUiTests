@WorkPointManagement
Feature: WorkPointManagement
	As an admin
	I want to be able to create and update workpoints
	In order to manage them properly

Background:
	Given I navigate to Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C

@SmokeTests @WorkpointCleanUp
Scenario: Successfully create a new workpoint within a company
	When I select 'Adauga punct de lucru' button from Puncte de lucru tab
	And I fill in workpoint's new details
		| key     | value          |
		| Name    | Workpoint Test |
		| Address | Address Test   |
	When I select Adauga button from 'Creaza punct de lucru nou' page
	Then the following toast message is displayed: Punctul de lucru a fost adaugat.
	And the new workpoint is displayed through Workpoints page

@SmokeTests
Scenario: Successfully filter workpoints by name
	When I search for Demo Workpoint on Workpoints tab content
	Then the searched workpoint Demo Workpoint is the only one displayed

@RegressionTests
Scenario: Info message is displayed if the searched workpoint does not exist
	When I search for No Workpoint on Wokrpoint tab content
	Then the following tab info message is displayed: Nu s-au gasit puncte de lucru.

@SmokeTests @UpdatedWorkpointCleanUp
Scenario: Successfully update workpoint's details
	When I select 'Creeaza punct de lucru' button from Puncte de lucru tab
	And I fill in workpoint's new details
		| key     | value          |
		| Name    | Workpoint Test |
		| Address | Address Test   |
	When I select Adauga button from 'Creaza punct de lucru nou' page
	Then the following toast message is displayed: Punctul de lucru a fost adaugat.
	And the new workpoint is displayed through Workpoints page
	When I select Modifica punct de lucru button for the newly added workpoint
	And I set the new values of the updatedWorkpoint
		| key     | valuea         |
		| Name    | Workpoint Test |
		| Address | Address update |
	And I select Actualizeaza button from 'Workpoints' page
	Then the following toast message is displayed: Punctul de lucru a fost actualizat cu succes.
	And the updated details are displayed in the updatedWorkpoint box

@SmokeTests
Scenario: Cannot add a new workpoint with an existing name & address
	When I select 'Adauga punct de lucru' button from Puncte de lucru tab
	And I fill in the Workpoint Name field: Demo Workpoint
	And I fill in the Workpoint Address field: Str. Avram Iancu 15, Cluj-Napoca
	And I select Adauga button from 'Creaza punct de lucru' page
	Then the following error message is displayed: Exista deja un punct de lucru cu acest nume si adresa.
	
@RegressionTests
Scenario: Cannot add a new workpoint without fillin in any fields
	When I select 'Adauga punct de lucru' button from Puncte de lucru tab	
	And I select Adauga button from 'Creaza punct de lucru' page
	Then the following error message is displayed: Toate campurile sunt obligatorii.

@RegressionTests
Scenario: Cannot add a new workpoint without fillin in workpoint's name
	When I select 'Adauga punct de lucru' button from Puncte de lucru tab	
	And I fill in the Workpoint Address field: Str. Avram Iancu 15, Cluj-Napoca
	And I select Adauga button from 'Creaza punct de lucru' page
	Then the following error message is displayed: Toate campurile sunt obligatorii.
	
@RegressionTests
Scenario: Cannot add a new workpoint without fillin in workpoint's address
	When I select 'Adauga punct de lucru' button from Puncte de lucru tab	
	And I fill in the Workpoint Name field: Demo Workpoint
	And I select Adauga button from 'Creaza punct de lucru' page
	Then the following error message is displayed: Toate campurile sunt obligatorii.
	
@SmoketTests
Scenario: Successfully remove workpoints
	When I select 'Creeaza punct de lucru' button from Puncte de lucru tab
	And I fill in workpoint's new details
		| key     | value          |
		| Name    | Workpoint Test |
		| Address | Address Test   |
	When I select Adauga button from 'Creaza punct de lucru nou' page
	Then the following toast message is displayed: Punctul de lucru a fost adaugat.
	When I select Sterge punct de lucru button for the newly added workpoint
	And I confirm the workpoint removal pop-up message
	Then the following toast message is displayed: Punctul de lucru a fost sters cu succes.
	And it's confirmed the workpoint has been deleted: Nu s-au gasit puncte de lucru.

@RegressionTests
Scenario: Workpoints removal can be canceled
	When I select 'Creeaza punct de lucru' button from Puncte de lucru tab
	And I fill in workpoint's new details
		| key     | value          |
		| Name    | Workpoint Test |
		| Address | Address Test   |
	When I select Adauga button from 'Creaza punct de lucru nou' page
	Then the following toast message is displayed: Punctul de lucru a fost adaugat.
	When I select Sterge punct de lucru button for the newly added workpoint
	And I cancel the workpoint removal pop-up message
	Then  it's confirmed the workpoint has not been deleted
