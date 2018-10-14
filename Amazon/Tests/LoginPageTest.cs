using AutomationFramework.BaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.PageObjects;
using AutomationFramework.CommonFunctions;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace Amazon.Tests
{
    [TestFixture]
    class LoginPageTest : AmazonBase
    {
        [Test, TestCaseSource(typeof(LoginTestDataManager))]        
        public void LoginToAmazon(string Username)
        {
            var LandingPage = new LandingPage(driver);
            FunctionLibrary.Scroll();
            var LoginPage = LandingPage.ClickOnSignInButton();
            LoginPage.EnterEmailOrMobileNumber(Username);
            var PasswordPage = LoginPage.Continue();
            PasswordPage.EnterPassword("pillu123$");
            PasswordPage.ClickOnLogin();
            log.Info("Test Ended");
        }

        [Test, TestCaseSource(typeof(LoginTestDataManager))]
        public void SearchProducts(string Username)
        {
            LoginToAmazon(Username);
            var ProductPurchasePage = new ProductPurchasePage(driver);
            ProductPurchasePage.SelectSearchValue("Books");
        }
    }
}
