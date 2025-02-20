using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.Env
{
    public class UCIBrowserUtils
    {
        #region Properties

        /// <summary>
        /// Initialise browser options for chrome browser
        /// </summary>
        public static readonly BrowserOptions options = new BrowserOptions
        {
            BrowserType = BrowserType.Chrome,
            PrivateMode = true,
            FireEvents = true,
            Headless = ConstantsUtils.Headless,
            UCITestMode = true,
            UCIPerformanceMode = true
        };

        public static XrmApp UCIBrowser { get; set; }
        public static WebClient Client { get; set; }

        public static string BaseUrl
        {
            get { return ConstantsUtils.BaseUrl; }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Initialise browser
        /// </summary>
        public void Initialise()
        {
            Client = new WebClient(options);
            UCIBrowser = new XrmApp(Client);
        }

        /// <summary>
        /// Close the browser
        /// </summary>
        public void CleanUp()
        {
            if (UCIBrowser != null)
            {
                UCIBrowser.Dispose();
            }
        }

        #endregion Methods
    }
}
