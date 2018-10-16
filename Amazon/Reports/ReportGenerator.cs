using AutomationFramework.BaseClasses;
using AutomationFramework.PageObjects;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Reports
{
    [TestFixture]
    public class ReportGenerator:AmazonBase
    {
        public static ExtentReports Extent;
        public static ExtentTest ExtentTest;

        [OneTimeSetUp]
        public void StartReport()
        {
            string Path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string ActualPath = Path.Substring(0, Path.LastIndexOf("bin"));
            string ProjectPath = new Uri(ActualPath).LocalPath;

            string ReportPath = ProjectPath + "Reports\\TestReport.html";

            Extent = new ExtentReports();            
            Extent.AddSystemInfo("Host Name", "Aniket-PC");
            Extent.AddSystemInfo("Environment", "QA");                
        }
        
        [Test]
        [Ignore("Skip Tests")]
        public void StartTest()
        {
            ExtentTest = Extent.CreateTest("SampleReporting");
            var LandingPage = new LandingPage(driver);
            var LoginPage = LandingPage.ClickOnSignInButton();
            //LoginPage.EnterEmailOrMobileNumber("7620674796");
            //LoginPage.Continue();
            ExtentTest.Log(Status.Pass,"Pass");
            Extent.AddTestRunnerLogs("TestEnd");
            
        }

        [OneTimeTearDown]
        public void End()
        {
            Extent.Flush();
            
        }
    }
}
