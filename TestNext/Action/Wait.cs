using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestNext.Util;

namespace TestNext.Action
{
    class Wait
    {
        private static WebDriverWait WaitTimeInSeconds(int seconds)
        {
            return new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(seconds));
        }

        public static IWebElement ForElementClickable(ElementLocator elementLocator, int seconds)
        {
            switch (elementLocator.Locator)
            {
                case ElementLocator.LocatorStrategy.ClassName:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.CssSelector:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.Id:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.Id(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.LinkText:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.LinkText(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.Name:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.Name(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.PartialLinkText:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.TagName(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.TagName:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.TagName(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.XPath:
                    return WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.XPath(elementLocator.Identifier)));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }
    }
}
