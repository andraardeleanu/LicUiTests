@UserManagement
Feature: UserManagement
	As an admin
	I want to be able to configure user data
	In order manage them 

Background:
	Given I navigate to Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	And I navigate to 'Clienti' tab

@SmokeTests @UserCleanUp
Scenario: Successfully create a new user
	When I select 'Adauga client nou' button from Clienti tab
	And I register the customer with the following details
		| key      | value           |
		| Prenume  | Customer        |
		| Nume     | UI Test         |
		| Companie | Demo Company    |
		| Username | customerUItest  |
		| Parola   | Admin@123       |
		| Email    | customerui@test |
	And I select 'Adauga client nou' button from Register modal
	Then the following toast message is displayed: Noul client a fost adaugat cu succes!
	And the new customer is displayed through Customers page

@SmokeTests
Scenario: Cannot create a new user with and existing username
	When I select 'Adauga client nou' button from Clienti tab
	And I register the customer with the following details
		| key      | value           |
		| Prenume  | Customer        |
		| Nume     | UI Test         |
		| Companie | Demo Company    |
		| Username | custone         |
		| Parola   | Admin@123       |
		| Email    | customerui@test |
	And I select 'Adauga client nou' button from Register modal
	Then the following error message is displayed: Exista deja un client cu acest usernume.

@SmokeTests
Scenario: Cannot create a new user with without filling in all the data
	When I select 'Adauga client nou' button from Clienti tab
	And I register the customer with the following details
		| key      | value        |
		| Prenume  | Customer     |
		| Nume     | UI Test      |
		| Companie | Demo Company |
		| Username |              |
		| Parola   | Admin@123    |
		| Email    |              |
	And I select 'Adauga client nou' button from Register modal
	Then the following error message is displayed: Toate campurile sunt obligatorii.

@SmokeTests @UserCleanUp
Scenario: Successfully update a new user
	When I select 'Adauga client nou' button from Clienti tab
	And I register the customer with the following details
		| key      | value           |
		| Prenume  | Customer        |
		| Nume     | UI Test         |
		| Companie | Demo Company    |
		| Username | customerUItest  |
		| Parola   | Admin@123       |
		| Email    | customerui@test |
	And I select 'Adauga client nou' button from Register modal
	Then the following toast message is displayed: Noul client a fost adaugat cu succes!
	When I select 'Modifica' button from Clienti tab for the customerUItest username
	And I update the following data for the customer selected
		| key     | value            |
		| Prenume | Customer Updated |
	Then I select Actualizeaza button on customer update modal
	And the following toast message is displayed: Clientul a fost actualizat cu succes.
	And the new customer is displayed through Customers page


@SmokeTests @UserCleanUp
Scenario: Successfully update user's password
	When I select 'Adauga client nou' button from Clienti tab
	And I register the customer with the following details
		| key      | value           |
		| Prenume  | Customer        |
		| Nume     | UI Test         |
		| Companie | Demo Company    |
		| Username | customerUItest  |
		| Parola   | Admin@123       |
		| Email    | customerui@test |
	And I select 'Adauga client nou' button from Register modal
	Then the following toast message is displayed: Noul client a fost adaugat cu succes!
	When I choose to disconnect from Licenta app
	Then I'm successfully disconnected: Pentru a putea utiliza toate functionalitatile, te rugam sa te conectezi.
	When I navigate to Login page
	And I log in with the following credentials
		| key      | value          |
		| username | customerUItest |
		| password | Admin@123      |
	And I navigate to user's profile
	And I update user's password
		| key          | value       |
		| Old password | Admin@123   |
		| New password | Admin@12345 |
	Then the following toast message is displayed: Parola a fost schimbata. Te rugam sa te reconectezi folosind noua parola.
	And I'm successfully disconnected: Pentru a putea utiliza toate functionalitatile, te rugam sa te conectezi.
	When I navigate to Login page
	And I log in with the following credentials
		| key      | value          |
		| username | customerUItest |
		| password | Admin@12345    |
	Then I'm successfully logged into Licenta app with user C
