@ManualOrdersManagement
Feature: ManualOrdersManagement
As a Licenta UI consumer, I want to be able to manage manual orders

Background:
	Given I navigate to Licenta app
	And I navigate to Login page

@SmokeTests
Scenario: Successfully display orders for admin
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Comenzi' tab
	Then all the orders are displayed through the table
	And the button Creeaza comanda manual is not avaialble for the admin
	
@SmokeTests
Scenario: Successfully filter orders by order number as admin
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Comenzi' tab
	Then all the orders are displayed through the table
	When I filter the list of orders by order number: 8b313e8e-7b8f-42e1-b992-540920dd373b
	Then the order 8b313e8e-7b8f-42e1-b992-540920dd373b is displayed
		
@SmokeTests
Scenario: Info message is displayed if there are no order results on selected filters
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Comenzi' tab
	Then all the orders are displayed through the table
	When I filter the list of orders by order number: xyz
	Then the following info message is displayed on orders tab: Nu s-au gasit rezultate.

@SmokeTests
Scenario: Successfully filter orders by status as customer
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	Then all the orders are displayed through the table
	When I filter the list of orders by status: Procesata
	Then the all the orders displayed have status: Procesata

@SmokeTests
Scenario: Successfully display orders for customer
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	Then all my orders are displayed through the table
	And the button Creeaza comanda manual is avaialble for the customer

@SmokeTests
Scenario: Info message is displayed if there are no order details
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Detalii button for the order c87f8659-c7f0-4ac5-a00c-6091a419d6a1 from the table
	Then the following info message is displayed: Nu exista produse in comanda.

@SmokeTests
Scenario: Order's details are available for the admin
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Comenzi' tab
	And I select Detalii button for the order 8b313e8e-7b8f-42e1-b992-540920dd373b from the table
	Then every product from the order is displayed

@SmokeTests
Scenario: Order's details are available for the customer
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Detalii button for the order 8b313e8e-7b8f-42e1-b992-540920dd373b from the table
	Then every product from the order is displayed

@SmokeTests
Scenario: Successfully create new manual order
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab
	And I select Demo Workpoint from workpoints dropdown on Create manual order modal
	And I select the following list of products for the new order with a total price of 1401.95 RON
		| key            | value |
		| Product Demo 1 | 3     |
		| Product Demo 2 | 2     |
		| Product Demo 3 | 10    |
	And I select Creeaza comanda button on Create manual order modal
	Then the following toast message is displayed: Comanda a fost creata cu succes!
	And the new order is displayed through orders table

@SmokeTests
Scenario: Manual order cannot be created without selecting the workpoint
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab
	And I select the following list of products for the new order with a total price of 1401.95 RON
		| key            | value |
		| Product Demo 1 | 3     |
		| Product Demo 2 | 2     |
		| Product Demo 3 | 10    |
	And I select Creeaza comanda button on Create manual order modal
	Then the following error message is displayed: Nu ai selectat punctul de lucru pentru noua comanda. Daca este un punct de lucru nou, il poti crea din tab-ul Puncte de lucru.

@SmokeTests
Scenario: Manual order cannot be created without selecting the products
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab
	And I select Demo Workpoint from workpoints dropdown on Create manual order modal
	And I select Creeaza comanda button on Create manual order modal
	Then the following error message is displayed: Nu ai selectat niciun produs pentru comanda.

@SmokeTests
Scenario: Manual orders cannot be created if there is not enough stock
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab
	And I select Demo Workpoint from workpoints dropdown on Create manual order modal
	And I select the following list of products for the new order with a total price of 3000801.98 RON
		| key            | value |
		| Product Demo 1 | 30000 |
		| Product Demo 2 | 2     |
		| Product Demo 3 | 10    |
	And I select Creeaza comanda button on Create manual order modal
	Then the following error message is displayed: Verifica stocul disponibil pentru produsele din comanda.

@SmokeTests
Scenario: Product's quantity must be valid in order to place the order
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab
	And I select Demo Workpoint from workpoints dropdown on Create manual order modal
	And I select the following list of products for the new order with a total price of 802.01 RON
		| key            | value |
		| Product Demo 1 | -3    |
		| Product Demo 2 | 2     |
		| Product Demo 3 | 10    |
	And I select Creeaza comanda button on Create manual order modal
	Then the following error message is displayed: Cantitatea setata pentru unul sau mai multe produse este invalida.

@SmokeTests
Scenario: Total price is displayed correctly on create order modal
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Comenzile mele' tab
	And I select Creeaza comanda manual button from 'Comenzi' tab
	And I select Demo Workpoint from workpoints dropdown on Create manual order modal
	And I select the following list of products for the new order with a total price of 350.98 RON
		| key            | value |
		| Product Demo 1 | 1     |
		| Product Demo 2 | 1     |
		| Product Demo 3 | 2     |	
	Then I confirm total price is corecct for the selected products and quantities: 350.98 RON
