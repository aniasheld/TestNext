using OpenQA.Selenium;

namespace TestNext.Action
{
    static class Check
    {
        public static bool ElementContainsText(IWebElement element, string text)
        {
            return (element.Text == text);
        }

        public static bool InputFieldContainsValue (IWebElement element, string input)
        {
            return (element.GetAttribute("value") == input);
        }
        public static bool ElemenentDisplayed (IWebElement element)
        {
            return (element.Displayed);
        }
        public static bool FormattedInputFieldContainsValue (IWebElement element, string input, string splitValue)
        {
            return (element.GetAttribute("value").ToString().Replace(splitValue, "") == input);
        }

        public static bool RadioButtonChecked (IWebElement element)
        {
            return (element.GetAttribute("checked") == "true");
        }

        public static bool RadioButtonChecked(string[] element)
        {
            return (LocateOld.Element(element).GetAttribute("checked") == "true");
        }

        public static bool StringContains(string input, string subString)
        {
            return (input.Contains(subString));
        }

    }
}
