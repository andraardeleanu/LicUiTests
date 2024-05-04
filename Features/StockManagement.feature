@StockManagement
Feature: StockManagement

Background:
	Given I navigate to Licenta app
	And I navigate to Login page
	When I log in with the following credentials
		| key      | value     |
		| username | admin     |
		| password | Admin@123 |
	Then I'm successfully logged into Licenta app with user A

@SmokeTests
Scenario: Stock is displayed for each product for admin
	When I navigate to 'Stoc' tab
	Then stock table is displayed

@SmokeTests @StockReset
Scenario: Succesfully update stock
	When I navigate to 'Stoc' tab
	And I filter stock by Stock Update product
	And I select Actualizeaza stoc button from 'Stoc' tab
	Then I confirm the current available stock is displayed in modal's header: 10 buc.
	When I update the new available stock to 35 buc.
	Then the following toast message is displayed: Noul stoc s-a actualizat cu succes.
	And I can confirm the new stock has been saved for product - Stock Update: 35 buc.

@SmokeTests 
Scenario: Cannot set a new available stock <= 0
	When I navigate to 'Stoc' tab
	And I filter stock by Stock Update product
	And I select Actualizeaza stoc button from 'Stoc' tab
	Then I confirm the current available stock is displayed in modal's header: 10 buc.
	When I update the new available stock to -35 buc.
	Then the following error message is displayed: Nu se poate adauga un stoc mai mic sau egal cu 0.
