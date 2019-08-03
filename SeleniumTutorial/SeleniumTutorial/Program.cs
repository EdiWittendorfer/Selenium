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



        [SetUp] //1.1. Adding NUnit attribute to classes
        public void Initialize()
        {
            //1.4. Calling the driver through "PropertiesCollection"
            PropertiesCollection.driver = new ChromeDriver();

            //1.2. Starting the driver and navigating to the executeautomation website
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            //1.1. The feedback tells me if it is/isn't executed test via the Output link
            Console.WriteLine("Opened link");
        }

        //1.4. I applied "PropertyType" to all tests where they were hard coded Id/Name
                [Test]
        public void ExecuteTest()
        {
            //1.2. Selecting a option from Drop Down menu
            SeleniumSetMethods.SelectDropdown("TitleId", "Mr.", PropertyType.Id);

            //1.2. Type text into a text box
            SeleniumSetMethods.EnterText("Initial", "EW", PropertyType.Name);

            //1.3. Enters values ​​in the console from TitleId and Initial
            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));
            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //1.2. Submits information by clicking the Save button
            SeleniumSetMethods.Click("Save", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            //1. Closing the driver
            PropertiesCollection.driver.Close();

            Console.WriteLine("Close the browser");
        }
    }
}

//PROGRAM IMPRESSIONS: I have cut down on the repeating code with the "PropertiesCollection" class by which I call the driver.More transparent methods.
//                     To avoid the *bug* misspelled name Id/Name I use "PropertyType" to select the type of variable.

