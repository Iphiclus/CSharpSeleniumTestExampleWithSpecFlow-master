using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CSharpSeleniumTestExampleWithSpecFlow.Pages
{
    class MacbookProBuyPage
    {
        public static By FIFTEEN_INCH = By.XPath("//button[contains(text(),'15-inch')]");
        public static By SILVER = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Space Grey'])[6]/following::span[1]");
        public static By SELECT = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='(opens in new window)'])[12]/following::span[2]");
        public static By LOGIC_PRO = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='None'])[2]/following::div[6]");
        public static By ADD_TO_BAG = By.Name("add-to-cart");
        public static By ADD_USB_C = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='£19.00'])[1]/following::span[1]");
        public static By REVIEW_BAG = By.Name("proceed");
    }
}
