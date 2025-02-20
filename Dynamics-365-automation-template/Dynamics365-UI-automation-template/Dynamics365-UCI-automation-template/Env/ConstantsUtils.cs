using System;

namespace Dynamics365_UCI_automation_template.Env
{
    /// <summary>
    /// This class contains the constants commonly used by all acceptance tests
    /// </summary>
    public class ConstantsUtils
    {
        /// <summary>
        /// Base url of the site
        /// </summary>
        //public static string BaseUrl = Environment.GetEnvironmentVariable("BASEURL");
        //public static string BaseUrl = "https://crm074118.crm.dynamics.com";
        //public static string BaseUrl = "https://crm074118.crm.dynamics.com/main.aspx?appid=1ce3e64d-6fad-ea11-a812-000d3a35bc16&forceUCI=1&pagetype=entitylist&etn=account&viewid=00000000-0000-0000-00aa-000010001001&viewType=1039";
        // My portal app Base Url
        //public static string BaseUrl = "https://triadgroupplc.sharepoint.com/sites/AllOnboard";
        // Azure portal Base URL
        public static string BaseUrl = "https://triad-group.crm11.dynamics.com/main.aspx?appid=b2f52476-e39a-ec11-b400-6045bd104435";

        /// <summary>
        /// Type of browser to run the tests
        /// "Google chrome", "Firefox" or "InternetExplorer"
        /// </summary>
        //public static string BrowserType = Environment.GetEnvironmentVariable("BROWSERTYPE");
        public static string BrowserType = "Chrome";

        /// <summary>
        /// Username to log into Dynamics 365 application
        /// </summary>
        //public static string UserName = Environment.GetEnvironmentVariable("USERNAME");
        //public static string UserName = "admin@CRM074118.onmicrosoft.com";
        //public static string UserName = "venuBtest2@ZephyrGroup.onmicrosoft.com";
        //public static string UserName = "VenuBadmin@ZephyrGroup.onmicrosoft.com";
        public static string UserName = "VenuBtest1@ZephyrGroup.onmicrosoft.com";

        /// <summary>
        /// Password to log into Dynamics 365 application
        /// </summary>
        //public static string Password = Environment.GetEnvironmentVariable("PASSWORD");
        //public static string Password = "e503LGoOCM";
        //public static string Password = "$Mfatestuser2";
        //public static string Password = "$Mfatestadmin1";
        public static string Password = "$Mfatestuser1t1";

        /// <summary>
        /// Run the tests in Headless browser true or false
        /// </summary>
        //public static bool Headless = Convert.ToBoolean(Environment.GetEnvironmentVariable("HEADLESS"));
        public static bool Headless = false;

    }
}
