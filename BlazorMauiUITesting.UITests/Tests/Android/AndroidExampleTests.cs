using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorMauiUITesting.UITests.Drivers;
using OpenQA.Selenium.Appium.Android;
using Xunit.Abstractions;

namespace BlazorMauiUITesting.UITests.Tests.Android
{
    public class AndroidExampleTests : ExampleTests<AndroidDriver>
    {
        public AndroidExampleTests(ITestOutputHelper testOutputHelper,
            IAppiumDriver<AndroidDriver> driverHolder) : base(testOutputHelper, driverHolder)
        {
        }
    }
}
