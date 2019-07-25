using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    class Program
    {

        //1. Postavljanje drivera kao ChromeDrviver
        //1.1 Globalna varijabla
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

        }



        [SetUp] //1.1 Dodavanje NUnit atributa klasama 
        public void Initialize()
        {
            //1. Pokretanje drivera te navigiranje na Google homepage
            driver.Navigate().GoToUrl("http://www.google.com");
            //1.1. Povratna informacija koja nam govori dali je/nije izvrsen dio testa putem Output linka
            Console.WriteLine("Opened link");
        }

        [Test]
        public void ExecuteTest()
        {
            //1. Postavljanje elementa kao SearchBox ("q") na Google homepage-u
            IWebElement element = driver.FindElement(By.Name("q"));

            //1. Upisivanje teksta u element
            element.SendKeys("Edi Wittendorfer");

            //1. Submitanje teksta
            element.Submit();

            Console.WriteLine("Executed Test");

        }

        [TearDown]
        public void CleanUp()
        {
            //1. Zatvaranje drivera
            driver.Close();

            Console.WriteLine("Close the browser");
        }
    }
}

//DOJMOVI PROGRAMA: Pregledniji nacin postavljanja testova koji daje povratnu informaciju dali je test izvrsen ili nije pomocu NUnit-a


