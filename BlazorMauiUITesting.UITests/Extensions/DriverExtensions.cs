using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorMauiUITesting.UITests.Adapters;
using BlazorMauiUITesting.UITests.Helpers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace BlazorMauiUITesting.UITests.Extensions
{
    public static class DriverExtensions
    {
        internal static DriverAdapter Adapter<TDriver>(this TDriver driver)
            where TDriver: AppiumDriver
        {
            var factory = new AdapterFactory();
            return factory.Adapter<TDriver>(driver);
        }
    }
}
