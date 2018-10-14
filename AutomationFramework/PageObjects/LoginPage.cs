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
        //public LoginPage(IWebDriver driver):base(driver) { }

        //[FindsBy(How =How.XPath,Using = "//input[@id='ap_email']")]
        //public IWebElement EmailOrMobileNumbertxt { get; set; }

        //[FindsBy(How = How.XPath, Using = "//input[@id='continue']")]
        //public IWebElement ContinueBtn { get; set; }

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
