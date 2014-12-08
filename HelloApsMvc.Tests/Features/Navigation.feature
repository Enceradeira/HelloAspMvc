Feature: Navigation
	
Scenario: Start Web-Site
	Given I navigate to the website
	Then I see a list of books

	When I click on create book
	Then I can enter a new book