using AutomationFramework.BaseClasses;
using AutomationFramework.CommonFunctions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    public class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver):base(driver) {  }        
        
        [FindsBy(How = How.XPath, Using = "//a[text()='Customer Service']")]
        public IWebElement CustomerServiceLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Sell']")]
        public IWebElement SellLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Hello. Sign in']")]
        public IWebElement SignInLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-flyout-ya-signin']//span[@class='nav-action-inner' and text()='Sign in']")]
        public IWebElement SignInButton { get; set; }

        //public void ElementDisplayed()
        //{
        //    WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //    webDriverWait.Until(ExpectedConditions.ElementIsVisible(driver.FindElement(By.XPath("//a[text()='Customer Service']"))));
        //}

        public CustomerPage ClickOnCustomerServiceLink()
        {
            try
            {
                CustomerServiceLink.Click();
                return new CustomerPage(driver);
            }
            catch (System.ArgumentException e)
            {
                throw e;
            }
        }

        public SellPage ClickOnSellLink()
        {
            SellLink.Click();
            return new SellPage(driver);
        }

        public void ClickOnSignIn()
        {
            FunctionLibrary.MouseOver(SignInLink);
        }

        //public LoginPage ClickOnSignInButton()
        //{
        //    ClickOnSignIn();
        //    //FunctionLibrary.MouseOverAndClick(SignInButton);
        //    SignInButton.Click();
        //    return new LoginPage(driver);
        //}

        public LoginPage ClickOnSignInButton()
        {
            ClickOnSignIn();
            //FunctionLibrary.MouseOverAndClick(SignInButton);
            SignInButton.Click();
            return new LoginPage();
        }
    }
}
