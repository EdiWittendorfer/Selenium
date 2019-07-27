using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    //1.4. enum koristim kako bih izbjegao hard kodirane dijelove code-a
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }


    class PropertiesCollection
    {
        //1.4. Auto-implement Property
        //1.4. Moguća implementacija u sve metode
        public static IWebDriver driver { get; set; }
    }
}
