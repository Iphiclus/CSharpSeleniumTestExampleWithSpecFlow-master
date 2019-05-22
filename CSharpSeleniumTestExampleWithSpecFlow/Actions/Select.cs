using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace CSharpSeleniumTestExampleWithSpecFlow.Actions
{
    class Select
    {
        private IWebDriver driver;
        private By element;

        public Select(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Select In(By element)
        {
            this.element = element;
            return this;
        }

        public void TheValue(string value)
        {
            new SelectElement(driver.FindElement(element)).SelectByText(value);
        }
    }
}

