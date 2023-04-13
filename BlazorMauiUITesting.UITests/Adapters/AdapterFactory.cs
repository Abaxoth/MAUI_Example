using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;

namespace BlazorMauiUITesting.UITests.Adapters
{
    internal class AdapterFactory
    {
        public DriverAdapter Adapter<TDriver>(TDriver driver)
            where TDriver: AppiumDriver
        {
            if (typeof(TDriver) == typeof(AndroidDriver))
                return new AndroidAdapter(driver);

            if (typeof(TDriver) == typeof(IOSDriver))
                return new IOSAdapter(driver);

            throw new NotSupportedException($"Failed to find adapter for {typeof(TDriver)}");
        }
    }
}
