﻿Feature: Cart feature
	As a user
	I want to add products to the cart
	So that I can buy them

@AddProductsToCart
Scenario: Add two products to the cart
	Given open the products list page
	When I add the two products to the cart with the following details
		| ProductName              | Quantity |
		| Sauce Labs Backpack      | 1        |
		| Sauce Labs Fleece Jacket | 1        |
	Then I should see the cart page with the two products