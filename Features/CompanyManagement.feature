@CompanyManagement
Feature: CompanyManagement
	As an admin
	I want to be able to fill in companies forms
	In order manage them 

Background:
	Given I navigate to Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A

@SmokeTests @CompanyCleanUp
Scenario: Successfully create a new company
	When I select 'Adauga companie' button from Companii tab
	And I fill in company's new details with a new CUI
		| key  | value        |
		| Name | Company Test |
	When I select Adauga button from 'Creaza companie' page
	Then the following toast message is displayed: Compania a fost creata cu succes!
	And the new company is displayed through Companies page
	
@RegressionTests
Scenario: Cannot create a company without filling in any fields
	When I select 'Adauga companie' button from Companii tab
	And I select Adauga button from 'Creaza companie' page
	Then the following error message is displayed: Toate campurile sunt obligatorii.

@RegressionTests
Scenario: Cannot create a company without filling in the CUI field
	When I select 'Adauga companie' button from Companii tab
	And I fill in the Company Name field: CompanyName
	And I select Adauga button from 'Creaza companie' page
	Then the following error message is displayed: Toate campurile sunt obligatorii.
	
@RegressionTests
Scenario: Cannot create a company without filling in the Name field
	When I select 'Adauga companie' button from Companii tab
	And I fill in the Company CUI field: 0987654321
	And I select Adauga button from 'Creaza companie' page
	Then the following error message is displayed: Toate campurile sunt obligatorii.

@RegressionTests
Scenario: Cannot create a company with an already existing name
	When I select 'Adauga companie' button from Companii tab
	And I fill in the Company Name field: Company Test
	And I fill in the Company CUI field: 0987654321
	And I select Adauga button from 'Creaza companie' page
	Then the following error message is displayed: Exista deja o companie cu acest nume.
	
@RegressionTests @ResetCompanyName
Scenario: Successfully update the name of an existing company
	When I search for Update Company Test-ABC on Companies tab content
	And I select 'Modifica companie' button from Companii tab
	And I set the new Company Name: Update Company Test-XYZ
	And I select Actualizeaza button from 'Creaza companie' page
	Then the following toast message is displayed: Compania a fost actualizata cu succes.

@SmokeTests
Scenario: Successfully display company's workpoints
	When I select the workpoint option button from the Company Demo
	Then the company's workpoint Workpoint Demo is displayed through table: Company Demo

@RegressionTests
Scenario: Info message is displayed if there are no workpoints assigned to the company
	When I select the workpoint option button from the No Workpoints Company
	Then the following info message is displayed: Nu exista puncte de lucru.

@SmokeTests
Scenario: Successfully filter companies by name
	When I search for Company Demo on Companies tab content
	Then the searched company Company Demo is the only one displayed

@RegressionTests
Scenario: Info message is displayed if the searched company does not exist
	When I search for No Company on Companies tab content
	Then the following tab info message is displayed: Nu s-au gasit companii.
