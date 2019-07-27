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

        

        static void Main(string[] args)
        {

        }



        [SetUp] //1.1 Dodavanje NUnit atributa klasama 
        public void Initialize()
        {
            //1.4. Pozivanje drivera kroz "PropertiesCollection"
            PropertiesCollection.driver = new ChromeDriver();

            //1.2. Pokretanje drivera te navigiranje na executeautomation webstranciu
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            //1.1. Povratna informacija koja nam govori dali je/nije izvrsen dio testa putem Output linka
            Console.WriteLine("Opened link");
        }

        //1.4. Primjenio sam "PropertyType" na sve testove gdje su bili hard kodirani Id/Name 
        [Test]
        public void ExecuteTest()
        {
            //1.2. Odabiranje drop down menu-a
            SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);

            //1.2. Upisivanje texta u text box
            SeleniumSetMethods.EnterText("Initial", "EW", PropertyType.Name);

            //1.3. U konzolu upisuje vrijednosti koje se nalaze u TitleId i Initial poljima 
            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //1.2. Submitanje podataka clickom na button Save
            SeleniumSetMethods.Click("Save", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            //1. Zatvaranje drivera
            PropertiesCollection.driver.Close();

            Console.WriteLine("Close the browser");
        }
    }
}

//DOJMOVI PROGRAMA: Samnjio sam ponavljanje code-a s klasom "PropertiesCollection" pomoću koje pozivam driver. Preglednije metode.
//                  Kako bih se izbjegao *bug* krivo upisanog naziva Id/Name koristim "PropertyType" pomoću kojega odabira tip varijable.

