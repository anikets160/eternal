
using OpenQA.Selenium;
using AutomationFramework.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.CommonFunctions
{
    public static class WebDriverExtension
    {
        public static void SendKeysExntensionMethod(this IWebDriver driver)
        {
            Console.WriteLine("Extension Method");
        }

    }
}
