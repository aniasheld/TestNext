using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNext.Action;
using TestNext.Util;

namespace TestNext.Tests
{
    [TestClass]
    public class CapSogHomepage : TestBase
    {
        [ClassInitialize]
        public static void InitCapabilities(TestContext context)
        {
            Capabilities.Init(context);
            TestUrl.Init(context);
        }
        //[DataRow ("WhatToEnter")]
        [TestMethod]
        public void GoThere()//string input)
        {
            Navigation.GoTo(TestUrl.CapSogUrl);
            Wait.ForElementClickable(Objects.Header, 3);
            Locate.ElementOfElement(Objects.Header, Objects.WakeSearch).Click();
            Wait.ForElementClickable(Objects.SearchField, 2).SendKeys("test");
            KeyboardInput.PressEnter();
            WaitOld.ForSeconds(5);
        }

        static class Objects
        {
            public static ElementLocator Header = ElementLocator.GetLocator(ElementLocator.LocatorStrategy.Id, "header");
            public static ElementLocator WakeSearch = ElementLocator.GetLocator(ElementLocator.LocatorStrategy.ClassName, "wake-search");
            public static ElementLocator SearchField = ElementLocator.GetLocator(ElementLocator.LocatorStrategy.Id, "q");
        }

    }
}
