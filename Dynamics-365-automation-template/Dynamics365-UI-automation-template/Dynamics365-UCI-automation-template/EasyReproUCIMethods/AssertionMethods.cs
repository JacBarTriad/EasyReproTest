using Dynamics365_UCI_automation_template.Env;
using Dynamics365_UCI_automation_template.Helpers;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    /// <summary>
    /// This class contains all the methods that are required for assertions
    /// </summary>
    public class AssertionMethods
    {
        #region Properties

        private readonly DataHandler dataHandler = new DataHandler();

        #endregion Properties

        #region Methods

        /// <summary>
        /// Assert that the given link is present on the page
        /// </summary>
        /// <param name="linkText">link text to assert</param>
        public void AssertLinkPresent(string linkText)
        {
            var driver = UCIBrowserUtils.Client.Browser.Driver;

            Assert.IsTrue(
                driver.HasElement(By.LinkText(linkText))
                , "'{0}' link is not displayed on the page"
                , linkText
                );
        }

        /// <summary>
        /// Assert the value of the given entity
        /// </summary>
        /// <param name="entity">entity</param>
        /// <param name="expValue">expected value</param>
        public void AssertEntityValue(string entity, string expValue)
        {
            var actValue = UCIBrowserUtils.UCIBrowser.Entity.GetValue(entity);
            Assert.AreEqual(expValue, actValue
                , "The value of entity '{0}' is not set to '{1}'. Expected - '{1}', but actual - '{2}'."
                , entity
                , expValue
                , actValue);
        }

        public void AssertRandomValues(string entity)
        {
            var actValue = UCIBrowserUtils.UCIBrowser.Entity.GetValue(entity);
            var expValue = dataHandler.RetriveData<string>(entity);

            Assert.AreEqual(expValue, actValue
                , "The random value is not set correctly for entity '{0}'. Expected - {1}, but actual - {2}."
                , entity
                , expValue
                , actValue
                );
        }

        #endregion Methods
    }
}
