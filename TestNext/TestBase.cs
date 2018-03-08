using System;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNext.Util;

namespace TestNext
{
    [TestClass]
    public class TestBase
    {
        protected DesiredCapabilities Capability { get; set; }
        public static TestContext TestContext { get; set; }
        string SessionId { get; set; }
        public enum Status { Completed, Error }

        [TestInitialize]
        public void Init()
        {
            Capability = Capabilities.GetCapabilities(Capabilities.Setup.Chrome);
            Driver.InitializeDriver(Driver.DriverType.ChromeDriver, Capability);
            if (Driver.Type == Driver.DriverType.Browserstack)
            {
                SessionId = ((CustomRemoteWebDriver)Driver.driver).GetSessionId().ToString();
            }
            Driver.driver.Manage().Window.Maximize();
            Console.WriteLine();
        }


        [TestCleanup]
        public void CleanUp()
        {
            if (Driver.Type == Driver.DriverType.Browserstack)
            {
                Status status = (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed) ? Status.Completed : Status.Error;
                ((CustomRemoteWebDriver)Driver.driver).SetStatus(SessionId, status.ToString(), Capabilities.BrowserStackUser, Capabilities.BrowserStackKey);
            }
            Driver.driver.Quit();
        }
    }
}
