using AutomationFramework.BaseClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.PageObjects;
using AutomationFramework.CommonFunctions;
using excel = Microsoft.Office.Interop.Excel;

//[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace Amazon.Tests
{
    [TestFixture]
    class LoginPageTest : AmazonBase
    {
        LoginPage LoginPage;
        LandingPage LandingPage;
        PasswordPage PasswordPage;
        ProductPurchasePage ProductPurchasePage;

        public LoginPageTest()
        {
            LoginPage = new LoginPage();
            LandingPage = new LandingPage(driver);
            PasswordPage = new PasswordPage(driver);
            ProductPurchasePage = new ProductPurchasePage(driver);
        }


        [Test]
        public void LoginToAmazon()
        {
            //FunctionLibrary.Scroll();
            LandingPage.ClickOnSignInButton();
            LoginPage.EnterEmailOrMobileNumber("7620674796");
            LoginPage.Continue();
            PasswordPage.EnterPassword("pillu123$");
            PasswordPage.ClickOnLogin();
        }

        [Test, TestCaseSource(typeof(LoginTestDataManager))]
        public void SearchProducts(string Username)
        {
            
            ProductPurchasePage.SelectSearchValue("Books");
        }

        //static string[] Username;

        //[Test]
        //public static void ReadExcelData()
        //{
        //    //Creates excel application
        //    excel.Application x1App = new excel.Application();

        //    //Creates excel workbook object for specified file
        //    excel.Workbook x1WorkBook = x1App.Workbooks.Open(@"C:\Users\Aniket\Desktop\TestData.xlsx");

        //    //Creates excel work sheet object for sheet 1
        //    excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];

        //    //Gets used range of excel file(here range is 3)
        //    excel.Range x1Range = x1WorkSheet.UsedRange;

        //    for (int i = 1; i <= x1Range.Count; i++)
        //    {
        //        //Gets cell value of 'i'th row and 1st column value
        //        Username = (string[])x1Range.Cells[i][1].value2;
        //    }

        //    Console.WriteLine(Username);
        //    x1WorkBook.Close(true);
        //    x1App.Quit();
        //}

        //[Test]
        //public void Login()
        //{
            
        //}
    }
}
