using AutomationFramework.BaseClasses;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Tests
{
    [TestFixture]
    [Ignore("Skip Tests")]
    public class MiscellaneousTest:AmazonBase
    {

        [Test]
        public void SelectBootstrapDropdown()
        {
            IReadOnlyList<IWebElement> listOfElements = driver.FindElements(By.XPath("//div[@class='dropdown-menu open']//ul[@class='dropdown-menu inner']//li//a"));

            Console.WriteLine(listOfElements.Count);

            Proxy proxy = new Proxy();
            proxy.HttpProxy = "";

        }

    }
}
