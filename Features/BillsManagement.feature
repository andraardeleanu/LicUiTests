@BillsManagement
Feature: BillsManagement
As a Licenta UI consumer, I want to be able to manage order's bills

Background:
	Given I navigate to Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab

@SmokeTests @BillCleanUp @OrderCleanUp @OrderProductsReset
Scenario: Successfully generate order bills
	When I select Workpoint Demo from workpoints dropdown on Create manual order modal
	And I select the following list of products for the new order with a total price of 200.00 RON
		| key            | value |
		| Product Demo 1 | 2     |
	And I select Creeaza comanda button on Create manual order modal
	Then the following toast message is displayed: Comanda a fost creata cu succes!
	And the new OrderNo is displayed through orders table
	When I choose to disconnect from Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Comenzi' tab
	And I select Modifica status button from 'Comenzi' tab
	Then the following toast message is displayed: Status actualizat cu succes.
	When I choose to disconnect from Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Genereaza si descarca factura button from 'Comenzi' tab
	Then I confirm the bill was downloaded from the app - Factura Comanda.pdf
	