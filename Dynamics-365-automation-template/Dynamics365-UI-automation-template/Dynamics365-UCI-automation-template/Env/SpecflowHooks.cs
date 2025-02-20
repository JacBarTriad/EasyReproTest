using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.Env
{
    [Binding]
    public class SpecflowHooks : UCIBrowserUtils
    {
        #region Methods

        /// <summary>
        /// This method will initialise the webdriver before each scenario
        /// </summary>
        [BeforeScenario]
        public void SetUp()
        {
            Initialise();
        }

        /// <summary>
        /// This method will cleanup (close browser) after each scenario
        /// </summary>
        [AfterScenario]
        public void TearDown()
        {
            CleanUp();
        }

        #endregion Methods
    }
}
