using AutomationFramework.CommonFunctions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.PageObjects
{
    public class ProductPurchasePage:BasePage
    {
        public ProductPurchasePage(IWebDriver driver) : base(driver) { }
   
        // Purchase page elements.
        [FindsBy(How =How.XPath,Using ="")]
        public IWebElement SearchDropdown { get; set; }

        // Purchase page methods.
        public void SelectSearchValue(string SearchValue)
        {
            FunctionLibrary.SelectDropdown(SearchDropdown, SearchValue);
        }
    }
}
