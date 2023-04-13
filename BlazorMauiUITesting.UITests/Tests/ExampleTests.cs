using BlazorMauiUITesting.UITests.Drivers;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorMauiUITesting.UITests.Extensions;
using OpenQA.Selenium.Appium;
using Xunit;
using Xunit.Abstractions;
using OpenQA.Selenium;

namespace BlazorMauiUITesting.UITests.Tests
{
    public abstract class ExampleTests<TDriver>
        where TDriver: AppiumDriver
    {
        protected ExampleTests(ITestOutputHelper testOutputHelper,
            IAppiumDriver<TDriver> driverHolder)
        {
            Output = testOutputHelper;
            Driver = driverHolder.Driver;
        }

        protected TDriver Driver { get; }
        protected ITestOutputHelper Output { get; }

        [Fact]
        public virtual Task Example()
        {
            var navMenu = Driver.Adapter().NavMenuElement();
            navMenu.Click();

            Driver.Adapter().NavigateCounterTab();
            var counter = Driver.Adapter().CounterElement();

            for (var i = 0; i < 10; i++)
                counter.Click();

            var screenshot = Driver.GetScreenshot();
            screenshot.SaveAsFile($"{ContextName}_counter.jpg", ScreenshotImageFormat.Jpeg);

            return Task.CompletedTask;
        }

        protected string ContextName => typeof(TDriver).Name;
    }
}
