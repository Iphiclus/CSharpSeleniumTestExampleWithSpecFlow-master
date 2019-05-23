using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTestExampleWithSpecFlow.Actions
{
    class Click
    {
        private IWebDriver driver;

        public Click(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void On(By element)
        {
            driver.FindElement(element).Click();
        }
    }
}