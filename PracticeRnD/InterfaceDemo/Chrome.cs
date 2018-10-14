using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD.InterfaceDemo
{
    class Chrome : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click for Chrome");
        }

        public void FindElement()
        {
            Console.WriteLine("Find for Chrome");
        }

        public void SendKeys()
        {
            Console.WriteLine("SendKeys in Chrome");
        }
    }
}
