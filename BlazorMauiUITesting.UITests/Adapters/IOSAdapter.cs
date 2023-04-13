using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;

namespace BlazorMauiUITesting.UITests.Adapters
{
    internal class IOSAdapter : DriverAdapter
    {
        public IOSAdapter(AppiumDriver driver) : base(driver)
        {
        }

        public override  AppiumElement NavMenuElement()
        {
            return Driver.FindElement(By.XPath("//XCUIElementTypeButton[@name=\"Navigation menu\"]"));
        }

        public override AppiumElement CounterElement()
        {
            return Driver.FindElement(By.XPath("//XCUIElementTypeButton[@name=\"Click me\"]"));
        }

        public override void NavigateCounterTab()
        {
            Driver.FindElement(By.XPath("//XCUIElementTypeLink[@name=\"Counter\"]")).Click();
        }
    }
}
