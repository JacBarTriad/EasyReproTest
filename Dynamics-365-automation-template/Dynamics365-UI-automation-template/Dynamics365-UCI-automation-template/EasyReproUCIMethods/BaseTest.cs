using Dynamics365_UCI_automation_template.Helpers;
using Dynamics365_UCI_automation_template.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    /// <summary>
    /// The BaseTest class contains the reference to the Easy repro methods. 
    /// All the stepdefinition classes should extend BaseTest
    /// </summary>
    public class BaseTest
    {
        public RandomGenerator randomGenerator = new RandomGenerator();
        public CRMInputMethods inputMethods = new CRMInputMethods();
        public CRMNavigationMethods navigationMethods = new CRMNavigationMethods();
        public CRMLoginMethods loginMethods = new CRMLoginMethods();
        public AssertionMethods assertionMethods = new AssertionMethods();
        public DataHandler dataHandler = new DataHandler();
        public CRMNotificationMethods notificationLocators = new CRMNotificationMethods();
        public CreateAccountMethods createAccountMethods = new CreateAccountMethods();
    }
}
