using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorMauiUITesting.UITests.Drivers;
using BlazorMauiUITesting.UITests.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using Xunit.Abstractions;

namespace BlazorMauiUITesting.UITests.Tests.IOS
{
    public class IOSExampleTests: ExampleTests<IOSDriver>
    {
        public IOSExampleTests(ITestOutputHelper testOutputHelper, IAppiumDriver<IOSDriver> driverHolder) 
            : base(testOutputHelper, driverHolder)
        {
        }

        
    }
}
