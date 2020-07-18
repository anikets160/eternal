using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Base;

namespace TestProject.Tests
{
    [TestFixture]
    public class LoginTests:Base
    {

        [Test]
        public void Login()
        {
            extentReports.CreateTest("Login");
            //extentTest.Info("Login Test Completed");
            //extentReports.Flush();
        }

    }
}
