@ProductsManagement
Feature: ProductsManagement

Background:
	Given I navigate to Licenta app
	And I navigate to Login page

@SmokeTests
Scenario: Successfully display products for admin
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	Then all the products are displayed through the table for admin
	And the button Adauga produs is available for the admin

@SmokeTests
Scenario: Successfully display products for customer
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Produse' tab
	Then all the products are displayed through the table for customer
	And the button Adauga produs is not avaialble for the customer

@SmokeTests @ProductCleanUp
Scenario: Successfully add a new product as admin
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I select Adauga produs button from 'Produse' tab
	And I set the new product's Name and details
		| key             | value       |
		| Nume produs     | Produs Test |
		| Pret produs     | 250.99      |
		| Stoc disponibil | 100         |
	And I select Adauga button from 'Produse' tab
	Then the following toast message is displayed: Produsul a fost adaugat cu succes!
	And I confirm the new product's Name is displayed through products table

@SmokeTests
Scenario: Can't add a new product with stock 0
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I select Adauga produs button from 'Produse' tab
	And I set the new product's Name and details
		| key             | value       |
		| Nume produs     | Produs Test |
		| Pret produs     | 250.99      |
		| Stoc disponibil | 0           |
	And I select Adauga button from 'Produse' tab
	Then the following error toast message is displayed: Valoarea stocului trebuie sa fie mai mare decat zero.

@SmokeTests
Scenario: Can't add a new product with negative stock
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I select Adauga produs button from 'Produse' tab
	And I set the new product's Name and details
		| key             | value       |
		| Nume produs     | Produs Test |
		| Pret produs     | 250.99      |
		| Stoc disponibil | -10         |
	And I select Adauga button from 'Produse' tab
	Then the following error toast message is displayed: Valoarea stocului trebuie sa fie mai mare decat zero.

@SmokeTests
Scenario: Can't add a new product with price 0
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I select Adauga produs button from 'Produse' tab
	And I set the new product's Name and details
		| key             | value       |
		| Nume produs     | Produs Test |
		| Pret produs     | 0           |
		| Stoc disponibil | 100         |
	And I select Adauga button from 'Produse' tab
	Then the following error toast message is displayed: Pretul setat noului produs trebuie sa aiba o valoare mai mare sau egala decat 0.

@SmokeTests
Scenario: Can't add a new product with negative price
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I select Adauga produs button from 'Produse' tab
	And I set the new product's Name and details
		| key             | value       |
		| Nume produs     | Produs Test |
		| Pret produs     | -10         |
		| Stoc disponibil | 100         |
	And I select Adauga button from 'Produse' tab
	Then the following error toast message is displayed: Pretul setat noului produs trebuie sa aiba o valoare mai mare sau egala decat 0.

@SmokeTests
Scenario: Fileds are mandatory for adding a new product
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I select Adauga produs button from 'Produse' tab
	And I set the new product's Name and details
		| key             | value |
		| Nume produs     |       |
		| Pret produs     | 15    |
		| Stoc disponibil | 15    |
	And I select Adauga button from 'Produse' tab
	Then the following error message is displayed: Toate campurile sunt obligatorii.

@SmokeTests
Scenario: Successfully filter products by name
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I filter the list of products by name: Product Demo 1
	Then I confirm the displayed product is Product Demo 1

@SmokeTests
Scenario: Successfully order products by ascending price
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I filter the list of products by ascending price
	Then I confirm the first product's price is 1 RON
	
@SmokeTests
Scenario: Successfully order products by descending price
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A
	When I navigate to 'Produse' tab
	And I filter the list of products by descending price
	Then I confirm the first product's price is 999.99 RON

@SmokeTests
Scenario: View stock for each product is available
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Produse' tab
	And I filter the list of products by name: Product Demo 1
	And I select Vezi stoc button from 'Produse' tab
	Then the stock for the selected product is displayed

@Ignore
Scenario: Products are displayed through pages
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C
	When I navigate to 'Produse' tab
	Then I confirm products are displayed through pages
	And I am able to change the number of results per page


