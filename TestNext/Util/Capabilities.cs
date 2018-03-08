using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;

namespace TestNext.Util
{
    static class Capabilities
    {
        private static TestContext Context { get; set; }

        public static DesiredCapabilities GetCapabilities(Setup setup)
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("browserstack.user", BrowserStackUser);
            capability.SetCapability("browserstack.key", BrowserStackKey);
            capability.SetCapability("browserstack.server", BrowserStackServer);
            capability.SetCapability("browserstack.local", "true");
            capability.SetCapability("acceptSslCerts", "true");
            capability.SetCapability("name", TestId);
            capability.SetCapability("project", "TestNext");
            capability.SetCapability("build", "TestNext");
            capability.SetCapability("browserstack.debug", "true");
            capability.SetCapability("browserstack.timezone", "Copenhagen");
            capability.SetCapability("browserstack.selenium_version", "3.5.2");
            Console.WriteLine("Capability has been set to: " + setup.ToString());
            switch (setup)
            {
                case Setup.Chrome:
                    capability.SetCapability("os", "Windows");
                    capability.SetCapability("os_version", "10");
                    capability.SetCapability("browser", "Chrome");
                    capability.SetCapability("browser_version", "62.0");
                    capability.SetCapability("resolution", "1920x1080");
                    return capability;

                case Setup.IE11:
                    capability.SetCapability("os", "Windows");
                    capability.SetCapability("os_version", "10");
                    capability.SetCapability("browser", "IE");
                    capability.SetCapability("browser_version", "11.0");
                    capability.SetCapability("resolution", "1920x1080");
                    return capability;

                case Setup.Andriod:
                    capability.SetCapability("os_version", "7.0");
                    capability.SetCapability("device", "Samsung Galaxy S8");
                    capability.SetCapability("real_mobile", "true");
                    return capability;

                case Setup.iOS:
                    capability.SetCapability("os_version", "10.3");
                    capability.SetCapability("device", "iPhone 7");
                    capability.SetCapability("real_mobile", "true");
                    return capability;

                default:
                    Console.WriteLine("Capability has been set to: Standard - no ID has been set");
                    capability.SetCapability("os", "Windows");
                    capability.SetCapability("os_version", "10");
                    capability.SetCapability("browser", "Chrome");
                    capability.SetCapability("browser_version", "62.0");
                    capability.SetCapability("resolution", "1920x1080");
                    return capability;
            }

        }

        public static void Init(TestContext context)
        {
            Context = context;
        }

        public static string TestId => Context.TestName;
        public static string BrowserStackUser => Context.Properties["browserstackUser"].ToString();
        public static string BrowserStackKey => Context.Properties["browserstackKey"].ToString();
        public static string BrowserStackServer => Context.Properties["browserstackServer"].ToString();
        public static string GmfApiUrl => Context.Properties["ApiBaseUrl"].ToString();

        public enum Setup { Chrome, Andriod, iOS, IE11 }
    }
}
