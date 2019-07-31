using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial
{
    //1.4. I use "enum" to avoid hard-coded sections of the code
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
        //1.4. Possible implementation in all methods
        public static IWebDriver driver { get; set; }
    }
}
