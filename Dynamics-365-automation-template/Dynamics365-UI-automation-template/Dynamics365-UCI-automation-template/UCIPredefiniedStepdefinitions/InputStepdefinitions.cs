using Dynamics365_UCI_automation_template.EasyReproUCIMethods;
using Dynamics365_UCI_automation_template.Env;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.UCIPredefiniedStepdefinitions
{
    /// <summary>
    /// This class contains stepdefinitions to handle input actions
    /// </summary>
    [Binding]
    public class InputStepdefinitions : BaseTest
    {
        [When(@"I set value of ""(.*)"" to ""(.*)""")]
        public void WhenISetValueOfTo(string field, string value)
        {
            inputMethods.SetValueOfField(field, value);
        }

        [When(@"I set value of ""(.*)"" to random string of (.*)")]
        public void WhenISetValueOfToRandomStringOf(string field, int stringLength)
        {
            inputMethods.SetValueOfFieldWithRandomString(field, stringLength);
        }
        
        [When(@"I set value of ""(.*)"" to random phone number")]
        [When(@"I set value of ""(.*)"" to random fax number")]
        public void WhenISetValueOfToRandomPhoneNumber(string field)
        {
            inputMethods.SetValueOfFieldWithRandomPhoneNumber(field);
        }

        [When(@"I set value of ""(.*)"" address field to ""(.*)""")]
        public void WhenISetValueOfAddressFieldTo(string field, string value)
        {
            inputMethods.SetValueOfAddressField(field, value);
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchText)
        {
            inputMethods.SearchForGivenEntry(searchText);
        }

        [When(@"I clear the search field")]
        public void WhenIClearTheSearchField()
        {
            inputMethods.ClearSearchField();
        }

        [When(@"I set the value of lookup field ""(.*)"" to ""(.*)""")]
        public void WhenISetTheValueOfLookupFieldTo(string field, string value)
        {
            inputMethods.SetValueOfALookupField(field, value);
        }

        [When(@"I select ""(.*)"" option from ""(.*)"" dropdown box")]
        public void WhenISelectOptionFromDropdownBox(string option, string dropdown)
        {
            inputMethods.SelectOptionFromDropdown(option, dropdown);
        }

    }
}
