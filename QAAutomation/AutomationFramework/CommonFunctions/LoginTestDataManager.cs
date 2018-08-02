using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace AutomationFramework.CommonFunctions
{
    public class LoginTestDataManager:IEnumerable<object[]> 
    {
        List<object[]> TestData = new List<object[]>();

        public LoginTestDataManager()
        {
            TestData.Add(new Object[] { "7620674796" });
            //TestData.Add(new Object[] { "9730757183" });
            //TestData.Add(new Object[] { "7623456398" });
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return TestData.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //string[] Username;
        //public IEnumerator GetEnumerator()
        //{
        //    return Username.GetEnumerator();
        //}
        //public static IEnumerable<TestCaseData> AddCases()
        //{
        //    yield return new TestCaseData("7620674796");
        //    yield return new TestCaseData("9730757183");
        //    yield return new TestCaseData("9875342567");
        //}


        //string[] Username;
        //public void ReadExcelData()
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
        //        Username = x1Range.Cells[i][1].value2;
        //    }
        //    x1WorkBook.Close(true);
        //    x1Appl.Quit();
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    return Username.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //IEnumerator<string[]> IEnumerable<string[]>.GetEnumerator()
        //{
        //    return Username.GetEnumerator();
        //}
    }
}
