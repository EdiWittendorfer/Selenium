﻿using NUnit.Framework;
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
            //1.2. Pokretanje drivera te navigiranje na executeautomation webstranciu
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            //1.1. Povratna informacija koja nam govori dali je/nije izvrsen dio testa putem Output linka
            Console.WriteLine("Opened link");
        }

        [Test]
        public void ExecuteTest()
        {
            //1.2. Odabiranje drop down menu-a
            SeleniumSetMethods.SelectDropdown(driver, "TitleId", "Mr.", "Id");

            //1.2. Upisivanje texta u text box
            SeleniumSetMethods.EnterText(driver, "Initial", "EW", "Name");

            //1.2. Submitanje podataka clickom na button Save
            SeleniumSetMethods.Click(driver, "Save", "Name");

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

//DOJMOVI PROGRAMA: Korištenje custom Set metoda kako bih si olakšao pisanje novih testova, poboljšao preglednost koda i samnjio mogućnost upisa krivih informacija.


