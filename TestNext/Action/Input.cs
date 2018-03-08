using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace TestNext.Action
{
    static class Input
    {

        public static void StringToInputField(IWebElement target, string input, bool verifyInput = true, int tries = 0)
        {
            target.Clear();
            target.SendKeys(input);
            if (verifyInput == true)
            {
                if (!Check.InputFieldContainsValue(target, input) && tries < 5)
                {
                    WaitOld.ForSeconds(0.3);
                    StringToInputField(target, input, verifyInput, ++tries);
                }
                else if (tries >= 5)
                {
                    ThrowInputError(inputErrorMessage);
                }
            }
        }   
        public static void FormattedStringToInputField(IWebElement target, string input, string splitValue, bool verifyInput = true, int tries = 0)
        {
            target.Clear();
            target.SendKeys(input);
            if (verifyInput == true)
            {

            }
        }

        public static void ClickRadioButton(IWebElement target, bool verifyCheck = true, int tries = 0)
        {
            target.Click();
            if (verifyCheck == true)
            {
                if (!Check.RadioButtonChecked(target) && tries < 5)
                {
                    WaitOld.ForSeconds(0.3);
                    ClickRadioButton(target, verifyCheck, ++tries);
                }
                else if (tries >= 5)
                {
                    ThrowInputError(radioButtonErrorMessage);
                }
            }
        }

        public static void ClickRadioButton(IWebElement target, string[] checkingTarget, bool verifyCheck = true, int tries = 0)
        {
            target.Click();
            if (verifyCheck == true)
            {
                if (!Check.RadioButtonChecked(checkingTarget) && tries < 5)
                {
                    WaitOld.ForSeconds(0.3);
                    ClickRadioButton(target, checkingTarget, verifyCheck, ++tries);
                }
                else if (tries >= 5)
                {
                    ThrowInputError(radioButtonErrorMessage);
                }
            }
        }

        public static void ClickRadioButton(IWebElement target, IWebElement checkingTarget, bool verifyCheck = true, int tries = 0)
        {
            target.Click();
            if (verifyCheck == true)
            {
                if (!Check.RadioButtonChecked(checkingTarget) && tries < 5)
                {
                    WaitOld.ForSeconds(0.3);
                    ClickRadioButton(target, checkingTarget, verifyCheck, ++tries);
                }
                else if (tries >= 5)
                {
                    ThrowInputError(radioButtonErrorMessage);
                }
            }
        }

        public static IWebElement PickResultInList(IWebElement parentElement, string[] childrenSelector, int choice)
        {
            List<IWebElement> options = LocateOld.ElementsOfElement(parentElement, childrenSelector);
            if (choice > options.Count)
            {
                Console.WriteLine("The provided index is out of range; choosing last entry");
                choice = options.Count - 1;
            }
            else if (choice < 0)
            {
                Console.WriteLine("The provided index is less than zero; choosing first entry");
                choice = 0;
            }
            return LocateOld.ElementsOfElement(parentElement, childrenSelector)[choice];
        }
        public static IWebElement PickResultInList(List<IWebElement> listOfElements, int choice)
        {
            if (choice > listOfElements.Count)
            {
                Console.WriteLine("The provided index is out of range; choosing last entry");
                choice = listOfElements.Count - 1;
            }
            else if (choice < 0)
            {
                Console.WriteLine("The provided index is less than zero; choosing first entry");
                choice = 0;
            }
            return listOfElements[choice];
        }

        private static string inputErrorMessage = "Failed to input correct value.";
        private static string radioButtonErrorMessage = "Failed to check radio button.";

        private static void ThrowInputError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            throw new ArgumentException(errorMessage);
        }
    }
}
