Dynamics-365-automation-template
====================================

Dynamics-365-automation-template is an automation testing template using C#, Specflow and EasyRepro. 
This template enables you to write automation test scripts to test Dynamics365 Unified Client Interface (UCI) applications using Behaviour Driven Development (BDD) approach with minimal coding.

# Pre-requisites
- Download and setup <a href="https://dotnet.microsoft.com/download/dotnet-framework/net472" target="_blank">.NET 4.7.2</a>
- Download and setup <a href="https://visualstudio.microsoft.com/downloads/" target="_blank">Visual Studio</a>
- Install <a href="https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio" target="_blank">Specflow</a> for Visual Studio 2019 from marketplace
- Familiarise yourself with writing <a href="https://cucumber.io/docs/gherkin" target="_blank">Gherkin Syntax</a> and <a href="https://cucumber.io/docs/cucumber/step-definitions" target="_blank">Step Definitions</a>

# Setting up Dynamics-365-automation-template
- Clone <a href="https://github.com/TriadGroupPlc/Dynamics-365-automation-template" target="_blank">Dynamics-365-automation-template</a> repository
- Open Dynamics365-UI-automation-template.sln solution in Visual studio and build
	- The solution consists of two projects
		1. Dynamics365-UCI-automation-template: A Class Library project (.NET Framework) that contains EasyRepro methods, predefined stepdefinitions, helper classes and test configuration. This project is added as part of the build dependencies to the Unit Test project.
		2. Dynamics365-UCI-automation-sample-tests: A Unit Test project (.NET Framework) that contains Feature files, user defined stepdefinitions. Dynamics365-UCI-automation-template project is added as the build dependency.

# Running tests
There are two options available to run the tests

## 1. Run tests from Visual studio Test Explorer
	- In Visual studio open '/Dynamics365-UI-automation-template/Dynamics365-UCI-automation-template/Env/ConstantsUtils.cs' and add the intended values to the parameters
	- Build Dynamics365-UCI-automation-sample-tests project. Once build is completed the available tests will be displayed in Test Explorer
	- Now individual tests can be run from Test Explorer
	
## 2. Run tests from CLI 
	- Open VS command prompt
	- Navigate to the Unit Test project directory
	- Run `VSTest.Console.exe bin\Debug\Dynamics365-UCI-automation-sample-tests.dll /Logger:trx;LogFileName=TestResult.trx`

# Writing new features
- This template enables you to write automation test scripts in <a href="https://cucumber.io/docs/bdd" target="_blank">BDD</a> approach using <a href="https://docs.specflow.org/projects/specflow/en/latest/Gherkin/Gherkin-Reference.html" target="_blank">Gherkin</a> syntax.
- Specflow tests are written in terms of "<a href="https://docs.specflow.org/projects/specflow/en/latest/Gherkin/Feature-Language.html" target="_blank">Features</a>". 
- Each feature consists of one or more "<a href="https://docs.specflow.org/projects/specflow/en/latest/Gherkin/Gherkin-Reference.html#scenario" target="_blank">Scenarios</a>". 
- Specflow feature files goes in the `\Dynamics365-UCI-automation-sample-tests\Features` directory and should have ".feature" extension.
- You can start by looking at `features/CreateAccount.feature`. 
- More Scenarios can be added into `CreateAccount.feature` file or even add new feature file in the directory using the predefined step definitions.

# Step Definitions
- A Step Definition is a C# method with an expression that links it to one or more Gherkin steps. 
- When Specflow executes a Gherkin step in a scenario, it will look for a matching `step definition` to execute.

## Predefined Step definitions
Predefined step definition C# classes are located at `Dynamics365-UCI-automation-template\UCIPredefiniedStepdefinitions`.
The predefined stepdefinitions can be used to automate features more quickly without much coding.

### Navigation Stepdefinitions
Use the following steps from `NavigationStepdefinitions` to navigate through the application.

Open an app
```
When I open the ""(.*)"" app
```

Navigate to a sub-area
```
When I navigate to area ""(.*)"" and select ""(.*)""
```

Navigate to given uri
```
When I navigate to ""(.*)""
```

Select a tab
```
When I navigate to ""(.*)"" tab
When I select ""(.*)"" tab
```

Select a sub-tab
```
When I select tab ""(.*)"" and select ""(.*)""
When I select tab ""(.*)"" and select sub-tab ""(.*)""
```

Navigate to a form
```
When I navigate to ""(.*)"" form
When I select ""(.*)"" form
```

Switch view
```
When I switch view to ""(.*)""
```

Open record from row using row index
```
When I open the record from the row (.*)
```

Click on given link in accounts table
```
When I click on account ""(.*)"" link
```

Click on given command from command bar
```
When I click on ""(.*)"" command
```

Save a record
```
When I save the record
```

Sign out of the user account
```
When I sign out of the account
```

### Login Stepdefinitions
Use the following steps from `LoginStepdefinitions.cs` to log into Dynamics 365 user account
```
Given I login to CRM
```

### Input Stepdefinitions
Use the following steps from `InputStepDefinitions.cs` to handle input fields

Set given value to the given field
```
When I set value of ""(.*)"" to ""(.*)""
```

Set the value of given field with a random string of given length 
```
When I set value of ""(.*)"" to random string of (.*)
```

Set the value of given field with random phone number
```
When I set value of ""(.*)"" to random phone number
When I set value of ""(.*)"" to random fax number
```

Search for a given record
```
When I search for ""(.*)""
```

Clear search field
```
When I clear the search field
```

Enter address in an address field
```
When I set value of ""(.*)"" address field to ""(.*)""
```

Set value of a lookup field
```
When I set the value of lookup field ""(.*)"" to ""(.*)""
```

Select an option from a dropdown box
```
When I select ""(.*)"" option from ""(.*)"" dropdown box
```

### Assertion Stepdefinitions
Use the following steps from `AssertionStepDefinitions.cs` to handle assertions.

Verify that a given account name is present in accounts table
```
Then I should see account name ""(.*)"" in the accounts table
```

Verify that given account parameter (name, telephone1, etc.) are present in accounts table
```
Then I should see this account ""(.*)"" in the accounts table
```

Verify that the expected value is set to the given field
```
Then I should see ""(.*)"" is set to ""(.*)""
```

Verify that the value of the given field is set with expected random string/phone number
```
Then I should see the value of ""(.*)"" is set to random string
Then I should see the value of ""(.*)"" is set to random phone number
```

### Notification Stepdefinitions
Use the following steps from `NavigationStepdefinitions.cs` to handle notifications.

Click Ignore and Save button on duplicate records notification
```
When I click "Ignore and Save" on duplicate records notification
When I click "Yes" on duplicate records notification
```

Click Cancel button on duplicate records notification
```
When I click "Cancel" on duplicate records notification
```

### Create account Stepdefinitions
Use the following steps from `CreateAccountStepdefinitions.cs` to create a record.

Create a record
```
Given I have a record created with the following data:
	| Entity | Value |
Given I have an account created with the following data:
	| Entity | Value |
```

Fill details in new account summary page
```
Given I fill the following data in new account summary page:
	| Entity | Value |
```

	
## Writing new Stepdefinitions
- Write a Gherkin step in a feature file and run the feature. 
- Then specflow looks for the associated stepdefinition and if specflow can't find one, then it will generate a snippet which can be used to create a stepdefinition. 
- Any required C# stepdefinition classes can be created in `Dynamics365-UCI-automation-sample-tests\Stepdefinitions` directory.

## MFA Support
This framework also supports MFA (Multi-Factor Authentication) login. You need to provide MFA Secret Key. Follow the below steps to obtain the MFA secret key for your account and setup Microsoft's Authenticator App:

1. Log in to you Dynamics-365 application
2. Open Account View account -> Security info
3. Click on 'Add sign-in method'
4. Select 'Authenticator app' from the dropdown on the pop-up and click 'Add'
5. Click on 'I want to use a different authenticator app' link and click 'Next'
6. Click on 'Can't scan image?'
7. Make a note of the 'Secret key' which is displayed
8. Open Authenticator app and click the '+' to add an account and select 'work or school account'
9. Scan the QR code displayed on the web page
10. When the App displays a six-digit code, click 'Next' on the web page
11. Enter the six-digit verification code from the app into the web page and Click the 'Next' button
12. Add your MFA Secret key from step 7 with the spaces removed to your app.config as shown below, in the same section that you add your username and password
```
<appSettings>
    <add key="OnlineUsername" value="Username@dynamics365.com"/> <!-- add your actual username -->
    <add key="OnlinePassword" value="password"/> <!-- add your actual password -->
    <add key="OnlineCrmUrl" value="https://dynamics365.com"/> <!-- add your actual app url -->
    <add key="MfaSecretKey" value="MfaSecretKey"/> <!-- add your account MfaSecretKey -->
    <add key="AzureKey" value=""/>
    <!-- IE,Chrome,Firefox,Edge,Remote-->
    <add key="BrowserType" value="Chrome"/>
    <add key="DriversPath" value=""/>
    <add key="UsePrivateMode" value="true"/>
    <!-- The following settings are only used if BrowserType = "Remote" above -->
    <add key="RemoteBrowserType" value="Chrome"/>
    <add key="RemoteHubServer" value="http://1.1.1.1:4444/wd/hub"/>
  </appSettings>
```

## Additional Resources
- EasyRepro youtube tutorials - https://www.youtube.com/watch?v=x0cHZ3E7Ekw
