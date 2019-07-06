using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD.Tests
{
    [TestFixture]
    public class Practice
    {

        [Test]
        public void SelectDate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);
            driver.FindElement(By.XPath("//span[text()='DEPARTURE']")).Click();

            string date = "10-July-2019";
            
            

            IList<IWebElement> months = new List<IWebElement>();


            months = driver.FindElements(By.XPath("//div[@class='DayPicker-Caption']"));
            

            driver.Close();
            driver.Quit();
        }


    }
}
