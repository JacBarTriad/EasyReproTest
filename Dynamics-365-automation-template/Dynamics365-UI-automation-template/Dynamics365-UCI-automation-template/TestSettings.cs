using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_UCI_automation_sample_tests
{
    public class TestSettings
    {
        public static string InvalidAccountLogicalName = "accounts";

        public static LookupItem LookupValues = new LookupItem { Name = "primarycontactid", Value = "Nancy Anderson (sample)" };
        public static string LookupField = "primarycontactid";
        public static string LookupName = "Nancy Anderson (sample)";
        private static readonly string Type = ConfigurationManager.AppSettings["BrowserType"];
        private static readonly string RemoteType = ConfigurationManager.AppSettings["RemoteBrowserType"];
        private static readonly string RemoteHubServerURL = ConfigurationManager.AppSettings["RemoteHubServer"];
        private static readonly string DriversPath = ConfigurationManager.AppSettings["DriversPath"] ?? string.Empty;
        private static readonly bool UsePrivateMode = Convert.ToBoolean(ConfigurationManager.AppSettings["UsePrivateMode"] ?? bool.TrueString);

        // Once you change this instance will affect all follow tests executions
        public static BrowserOptions SharedOptions = new BrowserOptions
        {
            BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), Type),
            PrivateMode = UsePrivateMode,
            FireEvents = false,
            Headless = false,
            Kiosk = false,
            UserAgent = false,
            DefaultThinkTime = 2000,
            RemoteBrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), RemoteType),
            RemoteHubServer = new Uri(RemoteHubServerURL),
            UCITestMode = true,
            UCIPerformanceMode = false,
            DriversPath = Path.IsPathRooted(DriversPath) ? DriversPath : Path.Combine(Directory.GetCurrentDirectory(), DriversPath),
            DisableExtensions = false,
            DisableFeatures = false,
            DisablePopupBlocking = false,
            DisableSettingsWindow = false,
            EnableJavascript = false,
            NoSandbox = false,
            DisableGpu = false,
            DumpDom = false,
            EnableAutomation = false,
            DisableImplSidePainting = false,
            DisableDevShmUsage = false,
            DisableInfoBars = false,
            TestTypeBrowser = false
        };

        // Create a new options instance, copy of the share, to use just in the current test, modifications in test will not affect other tests
        public static BrowserOptions Options => new BrowserOptions
        {
            BrowserType = SharedOptions.BrowserType,
            PrivateMode = SharedOptions.PrivateMode,
            FireEvents = SharedOptions.FireEvents,
            Headless = SharedOptions.Headless,
            Kiosk = SharedOptions.Kiosk,
            UserAgent = SharedOptions.UserAgent,
            DefaultThinkTime = SharedOptions.DefaultThinkTime,
            RemoteBrowserType = SharedOptions.RemoteBrowserType,
            RemoteHubServer = SharedOptions.RemoteHubServer,
            UCITestMode = SharedOptions.UCITestMode,
            UCIPerformanceMode = SharedOptions.UCIPerformanceMode,
            DriversPath = SharedOptions.DriversPath,
            DisableExtensions = SharedOptions.DisableExtensions,
            DisableFeatures = SharedOptions.DisableFeatures,
            DisablePopupBlocking = SharedOptions.DisablePopupBlocking,
            DisableSettingsWindow = SharedOptions.DisableSettingsWindow,
            EnableJavascript = SharedOptions.EnableJavascript,
            NoSandbox = SharedOptions.NoSandbox,
            DisableGpu = SharedOptions.DisableGpu,
            DumpDom = SharedOptions.DumpDom,
            EnableAutomation = SharedOptions.EnableAutomation,
            DisableImplSidePainting = SharedOptions.DisableImplSidePainting,
            DisableDevShmUsage = SharedOptions.DisableDevShmUsage,
            DisableInfoBars = SharedOptions.DisableInfoBars,
            TestTypeBrowser = SharedOptions.TestTypeBrowser
        };

    }
}
