@FileOrderManagement
Feature: FileOrderManagement
As a Licenta UI consumer, I want to be able to manage file orders

Background:
	Given I navigate to Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | custone   |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user C

@SmokeTests @OrderProductsReset @OrderCleanUp 
Scenario: Successfully place order from file
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file FileOrder.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following toast message is displayed: Comanda plasata cu succes.
	And the new OrderNo is displayed through orders table

@SmokeTests
Scenario: File orders cannot be placed without selecting the workpoint
	When I navigate to 'Comenzile mele' tab
	And I upload the file FileOrder.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Nu ai selectat punctul de lucru pentru noua comanda. Daca este un punct de lucru nou, il poti crea din tab-ul Puncte de lucru.

@SmokeTests
Scenario: CSV files are the only ones permitted to upload
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file AnotherFileExtension.pdf for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Fisierul trebuie sa fie de tip .csv

@SmokeTests
Scenario: Empty files cannot be uploaded
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file EmptyFile.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Fisierul este invalid. Verifica continutul fisierului.

@SmokeTests
Scenario: File's format must be correct in order to upload it
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file WrongFormat.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Formatul fisierului este invalid.

@SmokeTests
Scenario: File must contain valid products in order to upload it
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file InvalidProduct.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Produsul cautat nu exista.

@SmokeTests
Scenario: File orders cannot be placed if there is not enough available stock
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file InvalidStock.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Verifica stocul disponibil pentru produsele din comanda.

@SmokeTests
Scenario: File orders cannot be placed if there are duplicated products in the file
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file DuplicatedProducts.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Au fost identificate produse duplicate. Te rog sa revizuiesti comanda.

@SmokeTests
Scenario: File orders cannot be placed if there are stocks <= 0
	When I navigate to 'Comenzile mele' tab
	And I select Workpoint Demo workpoint for my new file order
	And I upload the file StockLessThan0.csv for the new order
	And I select Creeaza comanda automat button from 'Comenzi' tab
	Then the following error message is displayed: Verifica stocul disponibil pentru produsele din comanda.