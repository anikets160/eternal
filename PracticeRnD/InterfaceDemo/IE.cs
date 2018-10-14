using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD.InterfaceDemo
{
    class IE : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click for IE");
        }

        public void FindElement()
        {
            Console.WriteLine("Find for IE");
        }

        public void SendKeys()
        {
            Console.WriteLine("SendKeys in IE");
        }
    }
}
