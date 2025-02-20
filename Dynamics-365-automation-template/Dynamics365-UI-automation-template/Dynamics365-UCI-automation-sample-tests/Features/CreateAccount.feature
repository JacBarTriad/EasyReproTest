Feature: Create Account
	In order to have contacts of a customer
	As a customer service
	I want to create an account for new customer


  @Test1
Scenario: Create a new account
	Given I login to CRM
	When I open the "Sales Hub" app
	  And I navigate to area "Sales" and select "Accounts"
	  And I click on "New" command
	  And I set value of "name" to "QA test145"
	  And I set value of "telephone1" to random phone number
	  And I set value of "fax" to random fax number
	  And I set value of "websiteurl" to "https://www.triad.co.uk/"
	  And I set value of "address1_line1" address field to "QA address 1"
	  And I set value of "address1_city" address field to "Milton Keynes"
	 # And I set the value of lookup field "primarycontactid" to "Rene Valdes (sample)"
			
	Then I click on "Save & Close" command
	  And I click "Ignore & Save" on duplicate records notification
	  And I navigate to area "Sales" and select "Accounts"
	

	@Test1
Scenario: Create a new account and verify
	Given I login to CRM
	When I open the "Sales Hub" app
	And I navigate to area "Sales" and select "Accounts"
	When I click on "New" command
	And I set value of "name" to random string of 5
	#And I set value of "name" to "QA test1"
	And I set value of "telephone1" to random phone number
	And I set value of "fax" to random fax number
	And I set value of "websiteurl" to "https://www.triad.co.uk/"
	And I set value of "address1_line1" address field to "QA address 1"
	And I set value of "address1_city" address field to "Milton Keynes"
	And I set the value of lookup field "primarycontactid" to "Rene Valdes (sample)"
			
	And I click on "Save & Close" command
	And I click "Yes" on duplicate records notification
	And I navigate to area "Sales" and select "Accounts"
	Then I should see this account "name" in the accounts table
	And I should see this account "telephone1" in the accounts table
	
	When I click on account "name" link
	Then I should see the value of "name" is set to random string
	And I should see the value of "telephone1" is set to random phone number


  Scenario: Create an account using data table
	Given I login to CRM
	When I click on "New" command
	#And I set value of "name" to random string of 5
		
	Given I fill the following data in new account summary page:
		| Entity           | Value                    |
		| name             | QA Test1234              |
		| telephone1       | 12231233                 |
		| fax              | 1231231                  |
		| websiteurl       | https://www.triad.co.uk/ |
		| address1_line1   | QA Address               |
		| primarycontactid | Rene Valdes (sample)     |
	And I navigate to "Details" tab

	When I select "Consulting" option from "industrycode" dropdown box



  Scenario: Details page
	#Given I fill the following data in new account details page:
	#	| Entity       | Value      |
	#	| industrycode | Accounting |


		