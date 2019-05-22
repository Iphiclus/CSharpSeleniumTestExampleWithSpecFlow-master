using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTestExampleWithSpecFlow.Actions
{
    class Enter
    { 
        private IWebDriver driver;
        private By element;

        public Enter(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Enter Into(By element)
        {
            this.element = element;
            return this;
        }

        public void Text(string value)
        {
            driver.FindElement(element).SendKeys(value);
        }
    }
}