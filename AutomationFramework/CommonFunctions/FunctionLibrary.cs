using AutomationFramework.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace AutomationFramework.CommonFunctions
{
    public class FunctionLibrary : AmazonBase
    {
        //static Actions action = new Actions(driver);

        public static void Screenshot(string fileName)
        {
            string FileName = @"H:\SeleniumC#Screenshots\" + fileName + ".png"; 
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(FileName, ScreenshotImageFormat.Png);            
        }
        
        public static void Scroll()
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteScript("window.scrollBy(0,950);");
        }

        public static void MouseOver(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public static void MouseOverAndClick(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Build().Perform();
        }

        public static void SelectDropdown(IWebElement element,string dropdownValue)
        {
            SelectElement selectElement = new SelectElement(element);
            //selectElement.SelectByValue(dropdownValue);
            selectElement.SelectByText(dropdownValue);
        }

        public static void ReadExcelData()
        {
            //Creates excel application
            excel.Application x1Appl = new excel.Application();

            //Creates excel workbook object for specified file
            excel.Workbook x1WorkBook = x1Appl.Workbooks.Open(@"H:\SeleniumC#TestData\TestDataUpdated.xlsx");

            //Creates excel work sheet object for sheet 1
            excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];

            //Gets used range of excel file(here range is 3)
            excel.Range x1Range = x1WorkSheet.UsedRange;

            for (int i = 1; i <= x1Range.Count; i++)
            {
                //Gets cell value of 'i'th row and 1st column value
                String Username = x1Range.Cells[i][1].value2;
            }
            x1WorkBook.Close(true);
            x1Appl.Quit();
        }

        //public static string ReadExcelData()
        //{
        //    //Creates excel application
        //    excel.Application x1Appl = new excel.Application();

        //    //Creates excel workbook object for specified file
        //    excel.Workbook x1WorkBook = x1Appl.Workbooks.Open(@"H:\SeleniumC#TestData\TestDataUpdated.xlsx");

        //    //Creates excel work sheet object for sheet 1
        //    excel._Worksheet x1WorkSheet = x1WorkBook.Sheets[1];

        //    //Gets used range of excel file(here range is 3)
        //    excel.Range x1Range = x1WorkSheet.UsedRange;

        //    for (int i = 1; i <= x1Range.Count; i++)
        //    {
        //        //Gets cell value of 'i'th row and 1st column value
        //        string Username = x1Range.Cells[i][1].value2;

        //    }
        //    return Username;
        //    x1WorkBook.Close(true);
        //    x1Appl.Quit();            
        //}
    }
}
