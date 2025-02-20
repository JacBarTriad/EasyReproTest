using Dynamics365_UCI_automation_template.EasyReproUCIMethods;
using Dynamics365_UCI_automation_template.Env;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.UCIPredefiniedStepdefinitions
{
    [Binding]
    public class LoginStepdefinitions : BaseTest
    {
        [Given(@"I login to CRM")]
        public void GivenILoginToCRM()
        {
            loginMethods.LogintoCRM(UCIBrowserUtils.BaseUrl
                , ConstantsUtils.UserName
                , ConstantsUtils.Password
                );
        }

        [Given(@"I log in to CRM with MFA")]
        public void GivenILogInToCRMWithMFA()
        {
            loginMethods.LogintoCRMWithMFA();
        }

    }
}
