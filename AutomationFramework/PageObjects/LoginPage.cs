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
    public class LoginPage:AmazonBase
    {
        public IWebElement EmailOrMobileNumbertxt => driver.FindElement(By.XPath("//input[@id='ap_email']"));
        public IWebElement ContinueBtn => driver.FindElement(By.XPath("//input[@id='continue']"));

        public void EnterEmailOrMobileNumber(string emailormobilenumber)
        {
            EmailOrMobileNumbertxt.SendKeys(emailormobilenumber);
        }

        public PasswordPage Continue()
        {
            ContinueBtn.Click();
            return new PasswordPage(driver);
        }
    }
}
