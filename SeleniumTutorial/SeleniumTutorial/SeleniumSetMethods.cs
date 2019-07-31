using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    //1.4. No longer do I pass the driver inside each method, I use "PropertiesCollection"
    //1.4. Instead of hard-coded Id/Name, I use the "PropertyType" class for "elementType"
    class SeleniumSetMethods
    {
        //1.2. TextBox....
        public static void EnterText(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //1.2. Click button, checkBox, radioButton...
        public static void Click(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }


        //1.2. DropDown...
        public static void SelectDropdown(string element, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
               new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
