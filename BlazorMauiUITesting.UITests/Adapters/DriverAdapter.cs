using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorMauiUITesting.UITests.Extensions;
using OpenQA.Selenium.Appium.MultiTouch;
using BlazorMauiUITesting.UITests.Helpers;

namespace BlazorMauiUITesting.UITests.Adapters
{
    internal abstract class DriverAdapter
    {
        protected DriverAdapter(AppiumDriver driver)
        {
            Driver = driver;
        }

        protected AppiumDriver Driver { get; }

        public abstract AppiumElement NavMenuElement();

        public abstract AppiumElement CounterElement();

        public abstract void NavigateCounterTab();
    }
}
