Feature: SpecFlowFeature1
		1. Open your webbrowser
		2. Navigate to the Wikipedia site: https://www.wikipedia.org/
		3. Choose the English language
		4. Search for „Test Automation”
		5. Validate the following in this page:
		5/a. Unit testing text
		5/b. Existence of Test Automation Interface Model picture
		6. Search for the link of Behavior driven development and navigate to there

@Regression
Scenario: I search for Test Automation in browser
	Given I open the firefox browser
	Then I navigate to the "https://www.wikipedia.org/"
	And I choose the "English" language
	Then I click into the search field
	And I search for the following "Test automation" text
	Then I click on the magnifying glass icon
	And I check whether the "Unit testing" text is contained on the site
	Then I check whether the Test Automation Interface picture is appear on the site
	And Finally I check the "Behavior driven development" link is appear and I navigate to there
	Then I close the browser