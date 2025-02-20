using Dynamics365_UCI_automation_template.Env;
using Dynamics365_UCI_automation_template.PageObjects;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    public class CRMNotificationMethods
    {        
        #region Methods

        /// <summary>
        /// If duplicate record notification window is displayed then click on the given button
        /// </summary>
        /// <param name="buttonText">Ignore and Save / Cancel button</param>
        public void HandleDuplicateRecordNotification(string buttonText)
        {
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
            
            var driver = UCIBrowserUtils.Client.Browser.Driver;
                       
            if (driver.HasElement(By.XPath(NotificationLocators.GetDuplicateRecordsNotificationWindow())))
            {
                if (driver.HasElement(By.XPath(NotificationLocators.GetDuplicateRecordsGridRow())))
                {
                    //Select the first record in the grid
                    //driver.FindElements(By.XPath(NotificationLocators.GetDuplicateRecordsGridRow()))[0].Click(true);

                    if (buttonText == "Cancel")
                    {
                        driver.FindElement(By.XPath(NotificationLocators.GetDuplicateRecordsCancelButton())).Click(true);
                    }
                    else
                    {
                        driver.FindElement(By.XPath(NotificationLocators.GetDuplicateRecordsIgnoreAndSaveButton())).Click(true);
                    }
                }
            }
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }

        #endregion Methods

    }
}
