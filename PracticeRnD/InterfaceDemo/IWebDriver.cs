using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD.InterfaceDemo
{
    interface IWebDriver
    {
        void FindElement();
        void SendKeys();
        void Click();        
    }
}
