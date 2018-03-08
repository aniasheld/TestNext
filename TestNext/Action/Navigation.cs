using System;
using TestNext.Util;

namespace TestNext.Action
{
    static class Navigation
    {
        public static void GoTo(string url)
        {
            Console.WriteLine("Going to following URL" + url);
            Driver.driver.Navigate().GoToUrl(url);
        }
    }
}
