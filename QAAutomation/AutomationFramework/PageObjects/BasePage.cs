using AutomationFramework.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    public class BasePage:AmazonBase
    {
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
