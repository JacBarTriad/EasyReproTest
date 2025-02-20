using Dynamics365_UCI_automation_template.EasyReproUCIMethods;
using Dynamics365_UCI_automation_template.Env;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    /// This class contains all the stepdefinitions for assertions
    /// </summary>
    [Binding]
    public class AssertionStepdefinitions : BaseTest
    {
        [Then(@"I should see account name ""(.*)"" in the accounts table")]
        public void ThenIShouldSeeAccountNameInTheAccountsTable(string linkText)
        {
            assertionMethods.AssertLinkPresent(linkText);
        }
        
        [Then(@"I should see this account ""(.*)"" in the accounts table")]
        public void ThenIShouldSeeThisAccountInTheAccountsTable(string entity)
        {
            var expValue = dataHandler.RetriveData<string>(entity);
            assertionMethods.AssertLinkPresent(expValue);
        }


        [Then(@"I should see ""(.*)"" is set to ""(.*)""")]
        public void ThenIShouldSeeIsSetTo(string entity, string expValue)
        {
            assertionMethods.AssertEntityValue(entity, expValue);
        }

        [Then(@"I should see the value of ""(.*)"" is set to random string")]
        [Then(@"I should see the value of ""(.*)"" is set to random phone number")]
        public void ThenIShouldSeeTheValueOfIsSetToRandomString(string entity)
        {
            assertionMethods.AssertRandomValues(entity);
        }



    }
}
