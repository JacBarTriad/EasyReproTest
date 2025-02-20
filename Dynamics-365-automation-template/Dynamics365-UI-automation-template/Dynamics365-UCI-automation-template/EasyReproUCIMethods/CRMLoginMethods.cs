using Dynamics365_UCI_automation_sample_tests;
using Dynamics365_UCI_automation_template.Env;
using Dynamics365_UCI_automation_template.PageObjects;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Browser.Logs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_template.EasyReproUCIMethods
{
    /// <summary>
    /// Methods to log into CRM
    /// </summary>
    public class CRMLoginMethods 
    {
        protected readonly Uri _xrmUri = new Uri(ConfigurationManager.AppSettings["OnlineCrmUrl"]);
        protected readonly SecureString _username = ConfigurationManager.AppSettings["OnlineUsername"]?.ToSecureString();
        protected readonly SecureString _password = ConfigurationManager.AppSettings["OnlinePassword"]?.ToSecureString();
        protected readonly SecureString _mfaSecretKey = ConfigurationManager.AppSettings["MfaSecretKey"]?.ToSecureString();
        protected readonly TracingService trace;
        protected XrmApp _xrmApp;
        protected WebClient _client;

        public void LogintoCRM(string uri, string userName, string password)
        {
            UCIBrowserUtils.UCIBrowser.OnlineLogin.Login(
                new Uri(uri)
                , userName.ToSecureString()
                , password.ToSecureString()
                );
            UCIBrowserUtils.UCIBrowser.ThinkTime(1000);
        }

        public void LogintoMyPortalAPP(string userName, string password)
        {
            CRMNavigationMethods navigationMethods = new CRMNavigationMethods();
            navigationMethods.NavigateToUri("/");

            MyPortalAppLoginPage myPortalAppLoginPage = new MyPortalAppLoginPage();
            myPortalAppLoginPage.LogintoMyPortalApp(userName, password);
        }

        public void LogintoCRMWithMFA(BrowserOptions options = null)
        {
            options = options ?? TestSettings.Options;
            SetOptions(options);

            _client = new WebClient(options);
            _xrmApp = new XrmApp(_client);

            _xrmApp.OnlineLogin.Login(_xrmUri, _username, _password, _mfaSecretKey);
        }

        public virtual void SetOptions(BrowserOptions options) { }



    }

    
}
