using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Base
{
    public class Base
    {
        public static IWebDriver driver;

        public void Initalize()
        {
            string browserName = ConfigurationManager.AppSettings.Get("browserName");
            switch (browserName)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                
                default:
                    driver = new InternetExplorerDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(5000);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("browserURL"));
        }

        [SetUp]
        public void Setup()
        {
            Initalize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
        
    }
}
