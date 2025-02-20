using Dynamics365_UCI_automation_template.Env;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.PageObjects
{
    /// <summary>
    /// This page object class for My Portal App login page
    /// </summary>
    public class MyPortalAppLoginPage
    {
        #region

        private static readonly string userNameFieldXpath = "//input[@name='loginfmt']";
        private static readonly string nextButtonXpath = "//input[contains(@id, 'idSIButton')]";
        private static readonly string passwordFieldXpath = "//input[@name='passwd']";

        #endregion

        #region Getters and Setters

        public void LogintoMyPortalApp(string username, string password)
        {
            var driver = UCIBrowserUtils.Client.Browser.Driver;
            driver.FindElement(By.XPath(userNameFieldXpath)).Clear();
            driver.FindElement(By.XPath(userNameFieldXpath)).SendKeys(username);

            driver.FindElement(By.XPath(nextButtonXpath)).Click();

            driver.FindElement(By.XPath(passwordFieldXpath)).Clear() ;
            driver.FindElement(By.XPath(passwordFieldXpath)).SendKeys(password) ;

            driver.FindElement(By.XPath(nextButtonXpath)).Click();
        }

        #endregion Getters and Setters
    }
}
