﻿using PracticeRnD.InterfaceDemo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD
{
    class Program
    {
        //public static IWebDriver driver = new ChromeDriver();        

        static void Main(string[] args)
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            //driver.Navigate().GoToUrl("https://www.jquery-az.com/jquery/demo.php?ex=167.0_1");
            //driver.FindElement(By.XPath("//span[text()='Your Expertise']")).Click();
            //driver.FindElement(By.XPath("//div[@class='dropdown-menu open']//ul[@class='dropdown-menu inner']//li//a[text()='Framework']")).Click();
            //Console.ReadLine();
            //IReadOnlyList<IWebElement> listOfElements = driver.FindElements(By.XPath("//div[@class='dropdown-menu open']//ul[@class='dropdown-menu inner']//li//a"));
            //for (int i = 0; i < length; i++)
            //{

            //}

            //for (int i = 0; i < listOfElements.Count; i++)
            //{

            //}
            //Console.WriteLine(listOfElements.Count);
            //Console.ReadLine();           
            //driver.Quit();

            Console.WriteLine("Save");
            CollectionsListDemo collectionsList = new CollectionsListDemo();
            collectionsList.ListDemo("Aniket", "Pallavi", "Shubham","Shruti","Palla");

            IWebDriver driver = new Chrome();
            driver.Click();
            driver.FindElement();
            driver.SendKeys();

            IWebDriver driver1 = new Firefox();
            driver1.Click();
            driver1.FindElement();
            driver1.SendKeys();

            IWebDriver driver2 = new IE();
            driver2.Click();
            driver2.FindElement();
            driver2.SendKeys();
            
            Console.ReadLine();            
        }
    }
}
