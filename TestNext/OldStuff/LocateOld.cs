using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using TestNext.Util;

namespace TestNext.Action
{
    static class LocateOld
    {
        public static IWebElement Element (string[] elementSelector)
        {
            switch (elementSelector[0])
            {
                case "className":
                    return Driver.driver.FindElement(By.ClassName(elementSelector[1]));

                case "cssSelector":
                    return Driver.driver.FindElement(By.CssSelector(elementSelector[1]));

                case "id":
                    return Driver.driver.FindElement(By.Id(elementSelector[1]));

                case "linkText":
                    return Driver.driver.FindElement(By.LinkText(elementSelector[1]));

                case "name":
                    return Driver.driver.FindElement(By.Name(elementSelector[1]));

                case "tagName":
                    return Driver.driver.FindElement(By.TagName(elementSelector[1]));

                case "xPath":
                    return Driver.driver.FindElement(By.XPath(elementSelector[1]));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static IWebElement ElementOfElement (IWebElement parentElement, string[] childSelector)
        {
            switch (childSelector[0])
            {
                case "className":
                    return parentElement.FindElement(By.ClassName(childSelector[1]));

                case "cssSelector":
                    return parentElement.FindElement(By.CssSelector(childSelector[1]));

                case "id":
                    return parentElement.FindElement(By.Id(childSelector[1]));

                case "linkText":
                    return parentElement.FindElement(By.LinkText(childSelector[1]));

                case "name":
                    return parentElement.FindElement(By.Name(childSelector[1]));

                case "tagName":
                    return parentElement.FindElement(By.TagName(childSelector[1]));

                case "xPath":
                    return parentElement.FindElement(By.XPath(childSelector[1]));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static IWebElement ElementOfElement (string[] parentSelector, string[] childSelector)
        {
            IWebElement parentElement = Element(parentSelector);
            return ElementOfElement(parentElement, childSelector);
            
        }

        public static IWebElement ElementOfElements (string[] elementSelector, int index)
        {
            return Elements(elementSelector)[index];
        }

        public static IWebElement ElementWithTextOfElements(string[] elementSelector, string text)
        {
            foreach (IWebElement element in Elements(elementSelector))
            {
                if (Check.ElementContainsText(element, text))
                    return element;
            }
            string errorMessage = "Unable to locate element with text: " + text;
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }

        public static List<IWebElement> ElementsWithTextOfElements(string[] elementsSelector, string text, bool assertResults = false)
        {
            List<IWebElement> elementsWithText = new List<IWebElement>();
            foreach (IWebElement element in Elements(elementsSelector))
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

        public static IWebElement ElementWithTextOfElementsOfElement(IWebElement parentElement, string[] childSelector, string text)
        {
            foreach (IWebElement element in ElementsOfElement(parentElement, childSelector))
            {
                if (Check.ElementContainsText(element, text))
                    return element;
            }
            string errorMessage = "Unable to locate element with text: " + text;
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }

        public static List<IWebElement> ElementsWithTextOfElementsOfElement(IWebElement parentElement, string[] childrenSelector, string text, bool assertResults = false)
        {
            List<IWebElement> elementsWithText = new List<IWebElement>();
            foreach (IWebElement element in ElementsOfElement(parentElement, childrenSelector))
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

        public static List<IWebElement> Elements (string[] elementsSelector)
        {
            switch (elementsSelector[0])
            {
                case "className":
                    return new List<IWebElement>(Driver.driver.FindElements(By.ClassName(elementsSelector[1])));

                case "cssSelector":
                    return new List<IWebElement>(Driver.driver.FindElements(By.CssSelector(elementsSelector[1])));

                case "id":
                    return new List<IWebElement>(Driver.driver.FindElements(By.Id(elementsSelector[1])));

                case "linkText":
                    return new List<IWebElement>(Driver.driver.FindElements(By.LinkText(elementsSelector[1])));

                case "name":
                    return new List<IWebElement>(Driver.driver.FindElements(By.Name(elementsSelector[1])));

                case "tagName":
                    return new List<IWebElement>(Driver.driver.FindElements(By.TagName(elementsSelector[1])));

                case "xPath":
                    return new List<IWebElement>(Driver.driver.FindElements(By.XPath(elementsSelector[1])));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static List<IWebElement> ElementsOfElement(IWebElement parentElement, string[] childrenSelector)
        {
            switch (childrenSelector[0])
            {
                case "className":
                    return new List<IWebElement>(parentElement.FindElements(By.ClassName(childrenSelector[1])));

                case "cssSelector":
                    return new List<IWebElement>(parentElement.FindElements(By.CssSelector(childrenSelector[1])));

                case "id":
                    return new List<IWebElement>(parentElement.FindElements(By.Id(childrenSelector[1])));

                case "linkText":
                    return new List<IWebElement>(parentElement.FindElements(By.LinkText(childrenSelector[1])));

                case "name":
                    return new List<IWebElement>(parentElement.FindElements(By.Name(childrenSelector[1])));

                case "tagName":
                    return new List<IWebElement>(parentElement.FindElements(By.TagName(childrenSelector[1])));

                case "xPath":
                    return new List<IWebElement>(parentElement.FindElements(By.XPath(childrenSelector[1])));

                default:
                    string errorMessage = "No/Incorrect identifier method";
                    Console.WriteLine(errorMessage);
                    throw new ArgumentException(errorMessage);
            }
        }

        public static List<IWebElement> ElementsOfElement(string[] parentSelector, string[] childrenSelector)
        {
            IWebElement parentElement = Element(parentSelector);
            return ElementsOfElement(parentElement, childrenSelector);
        }
    }
}
