using Dynamics365_UCI_automation_template.Env;
using Dynamics365_UCI_automation_template.Helpers;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    /// <summary>
    /// Methods to input into fields
    /// </summary>
    public class CRMInputMethods
    {
        #region Properties

        private readonly RandomGenerator random = new RandomGenerator();
        private readonly DataHandler dataHandler = new DataHandler();

        public static string Name;

        #endregion Properties

        #region Methods
        
        /// <summary>
        /// Set the given value to the given field 
        /// </summary>
        /// <param name="field">entity name</param>
        /// <param name="value">value to set</param>
        public void SetValueOfField(string field, string value)
        {
            UCIBrowserUtils.UCIBrowser.Entity.ClearValue(field);
            UCIBrowserUtils.UCIBrowser.Entity.SetValue(field, value);
            UCIBrowserUtils.UCIBrowser.ThinkTime(500);
        }

        /// <summary>
        /// Set value of a field with a random string of given length 
        /// </summary>
        /// <param name="field">Entity name</param>
        /// <param name="length">lenght of the string</param>
        public void SetValueOfFieldWithRandomString(string field, int length)
        {
            dataHandler.SaveData(field, random.GetRandomString(length));
            UCIBrowserUtils.UCIBrowser.Entity.SetValue(field, dataHandler.RetriveData<string>(field));
            UCIBrowserUtils.UCIBrowser.ThinkTime(500);
        }

        /// <summary>
        /// Set value of a field with a a random phone number
        /// </summary>
        /// <param name="field">Entity name</param>
        public void SetValueOfFieldWithRandomPhoneNumber(string field)
        {
            dataHandler.SaveData(field, random.GetRandomPhoneNumber());
            UCIBrowserUtils.UCIBrowser.Entity.SetValue(field, dataHandler.RetriveData<string>(field));
            UCIBrowserUtils.UCIBrowser.ThinkTime(500);
        }

        /// <summary>
        /// Search for a given text
        /// </summary>
        /// <param name="searchText">Text to search for</param>
        public void SearchForGivenEntry(string searchText)
        {
            UCIBrowserUtils.UCIBrowser.Grid.ClearSearch();
            UCIBrowserUtils.UCIBrowser.Grid.Search(searchText);
        }

        /// <summary>
        /// Clear search field
        /// </summary>
        public void ClearSearchField()
        {
            UCIBrowserUtils.UCIBrowser.Grid.ClearSearch();
        }

        /// <summary>
        /// Set the value of the address field
        /// </summary>
        /// <param name="field">field name</param>
        /// <param name="value">value to set</param>
        public void SetValueOfAddressField(string field, string value)
        {
            try
            {
                UCIBrowserUtils.UCIBrowser.Entity.SetValue(field, value);
            }
            catch (ElementNotInteractableException)
            {
                Console.WriteLine("Element Not Interactable Exception shown.");
            }
            UCIBrowserUtils.Client.Browser.ThinkTime(100);
        }

        /// <summary>
        /// Set the value of the given lookup field
        /// </summary>
        /// <param name="field">lookup field</param>
        /// <param name="value">value to be set</param>
        public void SetValueOfALookupField(string field, string value)
        {
            UCIBrowserUtils.UCIBrowser.Entity.ClearValue(new LookupItem { Name = field });
            UCIBrowserUtils.UCIBrowser.Entity.SetValue(new LookupItem { Name = field, Value = value });
            UCIBrowserUtils.UCIBrowser.ThinkTime(100);
        }

        /// <summary>
        /// Select an option from the dropdown box
        /// </summary>
        /// <param name="dropdown">dropdown</param>
        /// <param name="option">option to select</param>
        public void SelectOptionFromDropdown(string option, string dropdown)
        {
            UCIBrowserUtils.UCIBrowser.Entity.SetValue(new OptionSet { Name = dropdown, Value = option });
            UCIBrowserUtils.UCIBrowser.ThinkTime(100);
        }

        #endregion Methods
    }
}
