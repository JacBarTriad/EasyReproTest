using Dynamics365_UCI_automation_template.Env;
using Dynamics365_UCI_automation_template.Helpers;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using System;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    /// <summary>
    /// Methods to navigate through CRM application pages
    /// </summary>
    public class CRMNavigationMethods
    {
        #region Properties

        private readonly DataHandler dataHandler = new DataHandler();

        #endregion Properties

        #region Methods

        /// <summary>
        /// Open the given application
        /// </summary>
        /// <param name="appName">Name of the app to be opened</param>
        public void OpenApplication(string appName)
        {
            UCIBrowserUtils.UCIBrowser.Navigation.OpenApp(appName);
            UCIBrowserUtils.UCIBrowser.ThinkTime(500);
        }

        /// <summary>
        /// Navigate to the sub area
        /// </summary>
        /// <param name="area">Name of the area</param>
        /// <param name="subArea">Name of the sub-area</param>
        public void NavigateToSubArea(string area, string subArea)
        {
            UCIBrowserUtils.UCIBrowser.Navigation.OpenSubArea(area, subArea);
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }
        
        /// <summary>
        /// Navigate to the given URI
        /// </summary>
        /// <param name="uri">URI to navigate to</param>
        public void NavigateToUri(string uri)
        {
            UCIBrowserUtils.Client.Browser.Driver.Navigate().GoToUrl(UCIBrowserUtils.BaseUrl + uri);
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }

        /// <summary>
        /// Navigate/select the given tab
        /// </summary>
        /// <param name="tabName">Name of the tab to be selected</param>
        /// <param name="subTabName">Optional name of the sub-tab to be selected</param>
        public void NavigateToTab(string tabName, string subTabName = "")
        {
            UCIBrowserUtils.UCIBrowser.Entity.SelectTab(tabName, subTabName);
        }

        /// <summary>
        /// Navigate/Select the given form
        /// </summary>
        /// <param name="formName">Name of the form to be selected</param>
        public void NavigateToForm(string formName)
        {
            UCIBrowserUtils.UCIBrowser.Entity.SelectForm(formName);
        }

        /// <summary>
        /// Select an option from System views to switch the Grid view  
        /// </summary>
        /// <param name="viewName">Option to be selected from System view</param>
        public void SwitchGridView(string viewName)
        {
            UCIBrowserUtils.UCIBrowser.Grid.SwitchView(viewName);
        }

        /// <summary>
        /// Open record from the given row
        /// </summary>
        /// <param name="recordRowNumber">row number of the record to be opened</param>
        public void OpenTheRecord(int recordRowNumber)
        {
            UCIBrowserUtils.UCIBrowser.Grid.OpenRecord(recordRowNumber);
        }

        /// <summary>
        /// Click on the given link
        /// </summary>
        /// <param name="linkText">link text to click on</param>
        public void FollowLink(string linkText)
        {
            UCIBrowserUtils.Client.Browser.Driver.FindElement(By.LinkText(linkText));
            UCIBrowserUtils.Client.Browser.ThinkTime(500);
        }

        /// <summary>
        /// Click on the given link in accounts table 
        /// </summary>
        /// <param name="entity">link text</param>
        public void ClickOnLinkFromDataHandler(string entity)
        {
            var linkText = dataHandler.RetriveData<string>(entity);
            //UCIBrowserUtils.UCIBrowser.CommandBar.ClickCommand(linkText);
            try
            {
                UCIBrowserUtils.Client.Browser.Driver.FindElement(By.LinkText(linkText)).Click(true);
            }
            catch (StaleElementReferenceException)
            {
                Console.WriteLine("Stale element present");
            }

            UCIBrowserUtils.UCIBrowser.ThinkTime(500);
        }

        /// <summary>
        /// Click on the given command in commandbar
        /// </summary>
        /// <param name="command"></param>
        public void ClickOnCommand(string command)
        {
            UCIBrowserUtils.UCIBrowser.CommandBar.ClickCommand(command);
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }

        /// <summary>
        /// Save the changes in the record
        /// </summary>
        public void SaveChanges()
        {
            UCIBrowserUtils.UCIBrowser.Entity.Save();
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }

        /// <summary>
        /// Click the signout button
        /// </summary>
        public void SignOutOfAccount()
        {
            UCIBrowserUtils.UCIBrowser.Navigation.SignOut();
        }

        

        #endregion Methods
    }
}
