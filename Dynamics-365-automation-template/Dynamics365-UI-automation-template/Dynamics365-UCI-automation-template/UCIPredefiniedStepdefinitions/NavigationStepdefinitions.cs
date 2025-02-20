using Dynamics365_UCI_automation_template.EasyReproUCIMethods;
using Dynamics365_UCI_automation_template.Env;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.UCIPredefiniedStepdefinitions
{
    /// <summary>
    /// Step definitions to navigate through the CRM pages and applications
    /// </summary>
    [Binding]
    public class NavigationStepdefinitions : BaseTest
    {
        [When(@"I open the ""(.*)"" app")]
        public void WhenIOpenTheApp(string appName)
        {
            navigationMethods.OpenApplication(appName);            
        }

        [When(@"I navigate to area ""(.*)"" and select ""(.*)""")]
        [Then(@"I navigate to area ""(.*)"" and select ""(.*)""")]
        public void WhenINavigateToAreaAndSelect(string area, string subArea)
        {
            navigationMethods.NavigateToSubArea(area, subArea);
        }

        [When(@"I navigate to ""(.*)""")]
        public void WhenINavigateTo(string uri)
        {
            navigationMethods.NavigateToUri(uri);
        }

        [When(@"I navigate to ""(.*)"" tab")]
        [When(@"I select ""(.*)"" tab")]
        [Given(@"I navigate to ""(.*)"" tab")]
        public void WhenINavigateToTab(string tabName)
        {
            navigationMethods.NavigateToTab(tabName);
        }

        [When(@"I select tab ""(.*)"" and select ""(.*)""")]
        [When(@"I select tab ""(.*)"" and select sub-tab ""(.*)""")]
        public void WhenISelectTabAndSelect(string tabName, string subTabName)
        {
            navigationMethods.NavigateToTab(tabName, subTabName);
        }
        
        [When(@"I navigate to ""(.*)"" form")]
        [When(@"I select ""(.*)"" form")]
        public void WhenISelectForm(string formName)
        {
            navigationMethods.NavigateToForm(formName);
        }

        [When(@"I switch view to ""(.*)""")]
        [Given(@"I switch view to ""(.*)""")]
        public void WhenISwitchViewTo(string viewName)
        {
            navigationMethods.SwitchGridView(viewName);
        }

        [When(@"I open the record from the row (.*)")]
        public void WhenIOpenTheRecordFromTheRow(int rowNumber)
        {
            navigationMethods.OpenTheRecord(rowNumber);
        }

        [When(@"I follow ""(.*)"" link")]
        public void WhenIFollowLink(string linkText)
        {
            navigationMethods.FollowLink(linkText);
        }

        [When(@"I click on account ""(.*)"" link")]
        public void WhenIClickOnAccountLink(string entity)
        {
            navigationMethods.ClickOnLinkFromDataHandler(entity);
        }

        [When(@"I click on ""(.*)"" command")]
        [Then(@"I click on ""(.*)"" command")]
        public void WhenIClickOnCommand(string command)
        {
            navigationMethods.ClickOnCommand(command);
        }

        [When(@"I save the record")]
        public void WhenISaveTheRecord()
        {
            navigationMethods.SaveChanges();
        }

        [Then(@"I sign out of the account")]
        public void ThenISignOutOfTheAccount()
        {
            navigationMethods.SignOutOfAccount();
        }


    }
}
