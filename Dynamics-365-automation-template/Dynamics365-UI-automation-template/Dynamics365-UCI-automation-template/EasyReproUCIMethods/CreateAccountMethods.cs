using Dynamics365_UCI_automation_template.Env;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    /// <summary>
    /// This class contains different method that can be used to create an account
    /// </summary>
    public class CreateAccountMethods
    {
        #region Properties

        private readonly CRMInputMethods inputMethods = new CRMInputMethods();
        private readonly CRMNavigationMethods navigationMethods = new CRMNavigationMethods();

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Fill the data for given entities and click "Save & Close" to create an account
        /// </summary>
        /// <param name="table">Data table</param>
        public void CreateAccountUsingDataTable(Table table)
        {
            FillFollowingEntities(table);

            navigationMethods.ClickOnCommand("Save & Close");
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }

        /// <summary>
        /// Select Summary tab in create new account page
        /// Fill the data for the given entities
        /// </summary>
        /// <param name="table">Data table</param>
        public void FillDataInAccountSummaryPage(Table table)
        {
            navigationMethods.NavigateToTab("Summary");
            FillFollowingEntities(table);
        }

        #endregion Public Methods

        #region Private Methods

        private void FillFollowingEntities(Table table)
        {
            foreach (var item in table.Rows)
            {
                if (item[1].ToString().ToLower().Contains("random string"))
                {
                    inputMethods.SetValueOfFieldWithRandomString(item[0].ToString(), 7);
                }
                else if (item[1].ToString().ToLower().Contains("random") && item[1].ToString().ToLower().Contains("number"))
                {
                    inputMethods.SetValueOfFieldWithRandomPhoneNumber(item[0].ToString());
                }
                else if (item[0].ToString().Contains("address"))
                {
                    inputMethods.SetValueOfAddressField(item[0].ToString(), item[1].ToString());
                }
                else if (item[0].ToString().Contains("primarycontact"))
                {
                    inputMethods.SetValueOfALookupField(item[0].ToString(), item[1].ToString());
                }
                else
                {
                    inputMethods.SetValueOfField(item[0].ToString(), item[1].ToString());
                }
            }
        }

        #endregion Private Methods
    }
}
