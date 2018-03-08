using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using TestNext.Util;

namespace TestNext.Action
{
    static class Locate
    {
        public static IWebElement Element(ElementLocator elementLocator)
        {
            switch (elementLocator.Locator)
            {
                case ElementLocator.LocatorStrategy.ClassName:
                    return Driver.driver.FindElement(By.ClassName(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.CssSelector:
                    return Driver.driver.FindElement(By.CssSelector(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.Id:
                    return Driver.driver.FindElement(By.Id(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.LinkText:
                    return Driver.driver.FindElement(By.LinkText(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.Name:
                    return Driver.driver.FindElement(By.Name(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.PartialLinkText:
                    return Driver.driver.FindElement(By.PartialLinkText(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.TagName:
                    return Driver.driver.FindElement(By.TagName(elementLocator.Identifier));

                case ElementLocator.LocatorStrategy.XPath:
                    return Driver.driver.FindElement(By.XPath(elementLocator.Identifier));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static IWebElement ElementOfElement(IWebElement parentElement, ElementLocator childLocator)
        {
            switch (childLocator.Locator)
            {
                case ElementLocator.LocatorStrategy.ClassName:
                    return parentElement.FindElement(By.ClassName(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.CssSelector:
                    return parentElement.FindElement(By.CssSelector(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.Id:
                    return parentElement.FindElement(By.Id(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.LinkText:
                    return parentElement.FindElement(By.LinkText(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.Name:
                    return parentElement.FindElement(By.Name(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.PartialLinkText:
                    return parentElement.FindElement(By.PartialLinkText(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.TagName:
                    return parentElement.FindElement(By.TagName(childLocator.Identifier));

                case ElementLocator.LocatorStrategy.XPath:
                    return parentElement.FindElement(By.XPath(childLocator.Identifier));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static IWebElement ElementOfElement(ElementLocator parentLocator, ElementLocator childLocator)
        {
            IWebElement parentElement = Element(parentLocator);
            return ElementOfElement(parentElement, childLocator);
        }

        public static IWebElement ElementOfElements(ElementLocator elementLocator, int index)
        {
            return Elements(elementLocator)[index];
        }

        public static List<IWebElement> Elements(ElementLocator elementLocator)
        {
            switch (elementLocator.Locator)
            {
                case ElementLocator.LocatorStrategy.ClassName:
                    return new List<IWebElement>(Driver.driver.FindElements(By.ClassName(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.CssSelector:
                    return new List<IWebElement>(Driver.driver.FindElements(By.CssSelector(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.Id:
                    return new List<IWebElement>(Driver.driver.FindElements(By.Id(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.LinkText:
                    return new List<IWebElement>(Driver.driver.FindElements(By.LinkText(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.Name:
                    return new List<IWebElement>(Driver.driver.FindElements(By.Name(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.PartialLinkText:
                    return new List<IWebElement>(Driver.driver.FindElements(By.PartialLinkText(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.TagName:
                    return new List<IWebElement>(Driver.driver.FindElements(By.TagName(elementLocator.Identifier)));

                case ElementLocator.LocatorStrategy.XPath:
                    return new List<IWebElement>(Driver.driver.FindElements(By.XPath(elementLocator.Identifier)));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static List<IWebElement> ElementsOfElement(IWebElement parentElement, ElementLocator childLocator)
        {
            switch (childLocator.Locator)
            {
                case ElementLocator.LocatorStrategy.ClassName:
                    return new List<IWebElement>(parentElement.FindElements(By.ClassName(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.CssSelector:
                    return new List<IWebElement>(parentElement.FindElements(By.CssSelector(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.Id:
                    return new List<IWebElement>(parentElement.FindElements(By.Id(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.LinkText:
                    return new List<IWebElement>(parentElement.FindElements(By.LinkText(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.Name:
                    return new List<IWebElement>(parentElement.FindElements(By.Name(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.PartialLinkText:
                    return new List<IWebElement>(parentElement.FindElements(By.PartialLinkText(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.TagName:
                    return new List<IWebElement>(parentElement.FindElements(By.TagName(childLocator.Identifier)));

                case ElementLocator.LocatorStrategy.XPath:
                    return new List<IWebElement>(parentElement.FindElements(By.XPath(childLocator.Identifier)));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static List<IWebElement> ElementsOfElement(ElementLocator parentLocator, ElementLocator childLocator)
        {
            IWebElement parentElement = Element(parentLocator);
            return ElementsOfElement(parentElement, childLocator);
        }

        public static IWebElement ElementWithTextOfElements(ElementLocator elementLocator, string text)
        {
            foreach (IWebElement element in Elements(elementLocator))
            {
                if (Check.ElementContainsText(element, text))
                    return element;
            }
            string errorMessage = "Unable to locate element with text: " + text;
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }

        public static List<IWebElement> ElementsWithTextOfElements(ElementLocator elementLocator, string text, bool assertResults = false)
        {
            List<IWebElement> elementsWithText = new List<IWebElement>();
            foreach (IWebElement element in Elements(elementLocator))
            {
                if (Check.ElementContainsText(element, text))
                    elementsWithText.Add(element);
            }
            if (elementsWithText.Count > 0 || assertResults == false)
                return elementsWithText;

            string errorMessage = "Unable to locate any elements with text: " + text;
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }

        public static IWebElement ElementWithTextOfElementsOfElement(IWebElement parentElement, ElementLocator childLocator, string text)
        {
            foreach (IWebElement element in ElementsOfElement(parentElement, childLocator))
            {
                if (Check.ElementContainsText(element, text))
                    return element;
            }
            string errorMessage = "Unable to locate element with text: " + text;
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }
        public static IWebElement ElementWithTextOfElementsOfElement(ElementLocator parentLocator, ElementLocator childLocator, string text)
        {
            IWebElement parentElement = Element(parentLocator);
            return ElementWithTextOfElementsOfElement(parentElement, childLocator, text);
        }

        public static List<IWebElement> ElementsWithTextOfElementsOfElement(IWebElement parentElement, ElementLocator childLocator, string text, bool assertResults = false)
        {
            List<IWebElement> elementsWithText = new List<IWebElement>();
            foreach (IWebElement element in ElementsOfElement(parentElement, childLocator))
            {
                if (Check.ElementContainsText(element, text))
                    elementsWithText.Add(element);
            }
            if (elementsWithText.Count > 0 || assertResults == false)
                return elementsWithText;

            string errorMessage = "Unable to locate any elements with text: " + text;
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }

        public static List<IWebElement> ElementsWithTextOfElementsOfElement(ElementLocator parentLocator, ElementLocator childLocator, string text, bool assertResults = false)
        {
            IWebElement parentElement = Element(parentLocator);
            return ElementsWithTextOfElementsOfElement(parentElement, childLocator, text, assertResults);
        }
    }
}
