using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.PageObjects
{
    /// <summary>
    /// This class contains all the locators for notifications
    /// </summary>
    public class NotificationLocators
    {
        #region CSS Selectors

        private static readonly string duplicateRecordsNotificationWindow = "//div[contains(@data-id,'ManageDuplicates')]";
        private static readonly string duplicateRecordsIgnoreAndSaveButton = "//button[contains(@data-id,'ignore_save')]";
        private static readonly string duplicateRecordsCancelButton = "//button[contains(@data-id,'close_dialog')]";
        private static readonly string duplicateRecordsGridRow = "//div[contains(@class,'data-selectable')]";

        #endregion CSS Selectors

        #region Getters and Setters

        /// <summary>
        /// Get duplicate records notification window xpath
        /// </summary>
        /// <returns>Duplicate Records Notification Window xpath</returns>
        public static string GetDuplicateRecordsNotificationWindow()
        {
            return duplicateRecordsNotificationWindow;
        }

        /// <summary>
        /// Get duplicate notification ignore and save button xpath
        /// </summary>
        /// <returns>Duplicate Records Ignore And Save Button xpath</returns>
        public static string GetDuplicateRecordsIgnoreAndSaveButton()
        {
            return duplicateRecordsIgnoreAndSaveButton;
        }

        /// <summary>
        /// Get duplicate record cancel button xpath
        /// </summary>
        /// <returns>Duplicate Records Cancel Button xpath</returns>
        public static string GetDuplicateRecordsCancelButton()
        {
            return duplicateRecordsCancelButton;
        }

        /// <summary>
        /// Get duplication record grid row xpath
        /// </summary>
        /// <returns>Duplicate Record Grid Row xpath</returns>
        public static string GetDuplicateRecordsGridRow()
        {
            return duplicateRecordsGridRow;
        }

        #endregion Getters and Setters
    }
}
