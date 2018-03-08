using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestNext.Util;

namespace TestNext.Action
{
    static class WaitOld
    {
        public static void ForSeconds (double seconds)
        {
            Thread.Sleep(Convert.ToInt32(seconds * 1000));
        }

        private static WebDriverWait WaitTimeInSeconds(int seconds)
        {
            return new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(seconds)); 
        }

        public static void ForElementClickable(string[] elementSelector, int seconds)
        {
            switch (elementSelector[0])
            {
                case "className":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.ClassName(elementSelector[1])));
                    break;

                case "cssSelector":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementSelector[1])));
                    break;

                case "id":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.Id(elementSelector[1])));
                    break;

                case "linkText":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.LinkText(elementSelector[1])));
                    break;

                case "name":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.Name(elementSelector[1])));
                    break;

                case "tagName":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.TagName(elementSelector[1])));
                    break;

                case "xPath":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(By.XPath(elementSelector[1])));
                    break;

                default:
                    IncorrectIdentifier();
                    break;
            }
        }

        public static void ForElementOfElementClickable(IWebElement parentElement, string[] childSelector, int seconds)
        {
            switch (childSelector[0])
            {
                case "className":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.ClassName(childSelector[1]))));
                    break;

                case "cssSelector":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.CssSelector(childSelector[1]))));
                    break;

                case "id":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.Id(childSelector[1]))));
                    break;

                case "linkText":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.LinkText(childSelector[1]))));
                    break;

                case "name":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.Name(childSelector[1]))));
                    break;

                case "tagName":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.TagName(childSelector[1]))));
                    break;

                case "xPath":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementToBeClickable(parentElement.FindElement(By.XPath(childSelector[1]))));
                    break;

                default:
                    IncorrectIdentifier();
                    break;
            }
        }

        public static void ForElementPresent(string[] elementSelector, int seconds)
        {
            switch (elementSelector[0])
            {
                case "className":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.ClassName(elementSelector[1])));
                    break;

                case "cssSelector":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.CssSelector(elementSelector[1])));
                    break;

                case "id":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.Id(elementSelector[1])));
                    break;

                case "linkText":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.LinkText(elementSelector[1])));
                    break;

                case "name":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.Name(elementSelector[1])));
                    break;

                case "tagName":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.TagName(elementSelector[1])));
                    break;

                case "xPath":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.ElementExists(By.XPath(elementSelector[1])));
                    break;

                default:
                    IncorrectIdentifier();
                    break;
            }
        }

        public static void ForElementInvisible(string[] elementSelector, int seconds)
        {
            switch (elementSelector[0])
            {
                case "className":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(elementSelector[1])));
                    break;

                case "cssSelector":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(elementSelector[1])));
                    break;

                case "id":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id(elementSelector[1])));
                    break;

                case "linkText":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.LinkText(elementSelector[1])));
                    break;

                case "name":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.Name(elementSelector[1])));
                    break;

                case "tagName":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.TagName(elementSelector[1])));
                    break;

                case "xPath":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(elementSelector[1])));
                    break;

                default:
                    IncorrectIdentifier();
                    break;
            }
        }

        public static void ForElementStale(IWebElement element, int seconds)
        {
            WaitTimeInSeconds(seconds).Until(ExpectedConditions.StalenessOf(element));
        }

        public static void ForElementWithTextInvisible(string[] elementSelector, string text, int seconds)
        {
            switch (elementSelector[0])
            {
                case "className":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.ClassName(elementSelector[1]), text));
                    break;

                case "cssSelector":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.CssSelector(elementSelector[1]), text));
                    break;

                case "id":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.Id(elementSelector[1]), text));
                    break;

                case "linkText":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText(elementSelector[1]), text));
                    break;

                case "name":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.Name(elementSelector[1]), text));
                    break;

                case "tagName":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.TagName(elementSelector[1]), text));
                    break;

                case "xPath":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.InvisibilityOfElementWithText(By.XPath(elementSelector[1]), text));
                    break;

                default:
                    IncorrectIdentifier();
                    break;
            }
        }

        public static void ForFrameReadyAndSwitchToIt(string[] iFrameSelector, int seconds)
        {
            switch (iFrameSelector[0])
            {
                case "className":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName(iFrameSelector[1])));
                    break;

                case "cssSelector":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector(iFrameSelector[1])));
                    break;

                case "id":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Id(iFrameSelector[1])));
                    break;

                case "linkText":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.LinkText(iFrameSelector[1])));
                    break;

                case "name":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Name(iFrameSelector[1])));
                    break;

                case "tagName":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.TagName(iFrameSelector[1])));
                    break;

                case "xPath":
                    WaitTimeInSeconds(seconds).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath(iFrameSelector[1])));
                    break;

                default:
                    IncorrectIdentifier();
                    break;

            }
        }

        public static void ForElementNotDisplayedOrStale(IWebElement element, int seconds)
        {
            try
            {
                if (Check.ElemenentDisplayed(element) && seconds > 0)
                {
                    ForSeconds(1);
                    ForElementNotDisplayedOrStale(element, --seconds);
                }
                else if(seconds <= 0)
                {
                    throw new ArgumentException("Element still displayed!");
                }
            }
            catch(StaleElementReferenceException)
            {
            }
        }

        public static void ForElementDisplayed(string[] elementSelector, int seconds)
        {
            try
            {
                if (!Check.ElemenentDisplayed(LocateOld.Element(elementSelector)) && seconds > 0)
                {
                    ForSeconds(1);
                    ForElementDisplayed(elementSelector, --seconds);
                }
                else if (seconds <= 0)
                {
                    throw new ArgumentException("Element still not displayed!");
                }
            }
            catch
            {
                if (seconds > 0)
                {
                    ForSeconds(1);
                    ForElementDisplayed(elementSelector, seconds);
                }
                else
                    throw new ArgumentException("Element still not displayed!");
            }
        }

        public static void ForElementDisplayed(IWebElement element, int seconds)
        {
            try
            {
                if (!Check.ElemenentDisplayed(element) && seconds > 0)
                {
                    ForSeconds(1);
                    ForElementDisplayed(element, --seconds);
                }
                else if (seconds <= 0)
                {
                    throw new ArgumentException("Element still not displayed!");
                }
            }
            catch
            {
                if (seconds > 0)
                {
                    ForSeconds(1);
                    ForElementDisplayed(element, seconds);
                }
                else
                    throw new ArgumentException("Element still not displayed!");
            }
        }

        private static void IncorrectIdentifier()
        {
            string errorMessage = "No/Incorrect identifier method";
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }
    }
}
