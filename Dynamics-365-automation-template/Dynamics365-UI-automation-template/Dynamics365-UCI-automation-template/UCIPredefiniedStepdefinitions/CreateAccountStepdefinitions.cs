using Dynamics365_UCI_automation_template.EasyReproUCIMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.UCIPredefiniedStepdefinitions
{
    /// <summary>
    /// This class contains all stepdefinitions to create an account
    /// </summary>
    [Binding]
    public class CreateAccountStepdefinitions : BaseTest
    {
        [Given(@"I have a record created with the following data:")]
        [Given(@"I have an account created with the following data:")]
        public void GivenIHaveARecordCreatedWithTheFollowingData(Table table)
        {
            createAccountMethods.CreateAccountUsingDataTable(table);
        }

        [Given(@"I fill the following data in new account summary page:")]
        public void GivenIFillTheFollowingDataInNewAccountSummaryPage(Table table)
        {
            createAccountMethods.FillDataInAccountSummaryPage(table);
        }

    }
}
