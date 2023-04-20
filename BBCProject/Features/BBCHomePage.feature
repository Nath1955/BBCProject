Feature: BBCHomePage

As a user of BBC
I want to go on the homepage
So that I can read the news

@tag1
Scenario: verify a user can view BBC homepage
	Given a user navigate to the website "https://www.bbc.co.uk/"
	When a user click on sport menu
	Then the sport page is displayed