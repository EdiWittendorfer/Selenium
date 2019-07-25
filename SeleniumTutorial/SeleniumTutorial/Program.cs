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
        static void Main(string[] args)
        {
            //Postavljanje drivera kao ChromeDrviver
            IWebDriver driver = new ChromeDriver();

            //Pokretanje drivera te navigiranje na Google homepage
            driver.Navigate().GoToUrl("http://www.google.com");

            //Postavljanje elementa kao SearchBox ("q") na Google homepage-u
            IWebElement element = driver.FindElement(By.Name("q"));

            //Upisivanje teksta u element
            element.SendKeys("Edi Wittendorfer");

            //Submitanje teksta
            element.Submit();

            //zatvaranje drivera
            driver.Close();
        }
    }
}

//DOJMOVI PROGRAMA: Jedostavan nacin izrade testa, no nepregledan i veoma sklon programerskim pogreskama


