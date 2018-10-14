using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    public class PasswordPage:BasePage
    {
        public PasswordPage(IWebDriver driver):base(driver) {  }

        // Password page elements.
        [FindsBy(How =How.XPath,Using = "//input[@id='ap_password']")]
        public IWebElement Passwordtxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='signInSubmit']")]
        public IWebElement Loginbtn { get; set; }

        // Password page methods.
        public void EnterPassword(string Password)
        {
            Passwordtxt.Clear();
            Passwordtxt.SendKeys(Password);
        }

        public ProductPurchasePage ClickOnLogin()
        {
            Loginbtn.Click();
            return new ProductPurchasePage(driver);
        }
    }
}
