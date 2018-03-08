using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestNext.Action;

namespace TestNext.Util
{
    static class KeyboardInput
    {
        public static void InputString(string input)
        {
            new Actions(Driver.driver).SendKeys(input).Perform();
            WaitOld.ForSeconds(0.5);
        }

        public static void PressEnter()
        {
            new Actions(Driver.driver).SendKeys(Keys.Enter).Perform();
        }

        public static void PressTab()
        {
            new Actions(Driver.driver).SendKeys(Keys.Tab).Perform();
        }
    }
}
