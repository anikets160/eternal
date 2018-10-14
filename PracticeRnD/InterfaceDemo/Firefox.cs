using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD.InterfaceDemo
{
    class Firefox : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Click for Firefox");
        }

        public void FindElement()
        {
            Console.WriteLine("Find for Firefox");
        }

        public void SendKeys()
        {
            Console.WriteLine("SendKeys in Firefox");
        }
    }
}
