using Dynamics365_UCI_automation_template.EasyReproUCIMethods;
using Dynamics365_UCI_automation_template.Env;
using Microsoft.Dynamics365.UIAutomation.Browser;
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
    /// Step definitions to handle notifications
    /// </summary>
    [Binding]
    public class NotificationStepdefinitions : BaseTest
    {
        [When(@"I click ""(.*)"" on duplicate records notification")]
        [Then(@"I click ""(.*)"" on duplicate records notification")]
        public void WhenIClickOnDuplicateRecordsNotification(string buttonText)
        {
            notificationLocators.HandleDuplicateRecordNotification(buttonText);
            UCIBrowserUtils.UCIBrowser.ThinkTime(5000);
        }

    }
}
