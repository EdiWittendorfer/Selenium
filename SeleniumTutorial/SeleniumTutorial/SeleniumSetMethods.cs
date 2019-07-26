using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    class SeleniumSetMethods
    {
        //1.2. Text box....
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
                 driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //1.2. Click button, checkBox, radioButton...
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }


        //1.2. Drop down...
        public static void SelectDropdown(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
               new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
