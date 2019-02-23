using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.BaseClasses
{
    public class AmazonBase
    {
        public static IWebDriver driver;
        public static ResourceManager resources = new ResourceManager("Amazon.Properties", Assembly.GetExecutingAssembly());
        public static readonly log4net.ILog log = log = log4net.LogManager.GetLogger("Base");
        public static WebDriverWait wait;

        //enum Browser
        //{
        //    chrome,
        //    firefox,
        //    ie,
        //    safari
        //}

        // Initialization method
        public void Initialize()
        {
            string browser = ConfigurationManager.AppSettings.Get("Browser");
            switch (browser)
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
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("URL"));
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
        }

        [SetUp]
        public void InitialSetup()
        {
            Initialize();

        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
