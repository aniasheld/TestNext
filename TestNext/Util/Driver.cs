using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestNext.Util
{
    public static class Driver
    {
        public static IWebDriver driver { get; set; }
        public static DriverType Type { get; set; }

        public static void InitializeDriver(DriverType type, DesiredCapabilities capability)
        {
            switch (type)
            {
                case DriverType.ChromeDriver:
                    Type = type;
                    driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), new ChromeOptions(), TimeSpan.FromMinutes(6));
                    break;

                case DriverType.Browserstack:
                    Type = type;
                    driver = new CustomRemoteWebDriver(new Uri("http://" + Capabilities.BrowserStackServer + "/wd/hub/"), capability, TimeSpan.FromMinutes(6));
                    break;

                default:
                    Type = type;
                    driver = new ChromeDriver();
                    break;

            }
        }

        public static string GetCookieValue(string cookieName)
        {
            return driver.Manage().Cookies.GetCookieNamed(cookieName).Value;
        }

        public enum DriverType { ChromeDriver, Browserstack }
    }
}
