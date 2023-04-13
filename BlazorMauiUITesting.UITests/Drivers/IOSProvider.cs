using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;

namespace BlazorMauiUITesting.UITests.Drivers
{
    public class IOSProvider : IAppiumDriver<IOSDriver>, IDisposable
    {
        private readonly AppiumLocalService _localService;

        public IOSProvider()
        {
            var solutionDirectory = Path.GetFullPath
            (Path.Combine(AppContext.BaseDirectory,
                "..", "..", "..", ".."));

            var appiumOptions = new AppiumOptions
            {
                PlatformName = "iOS",
                AutomationName = "XCuiTest",
                DeviceName = "iPhone 14",
                PlatformVersion = "16.2",

                App = Path.Combine(solutionDirectory, 
                    "BlazorMauiUITesting/bin/Debug/net7.0-ios/iossimulator-arm64/BlazorMauiUITesting.app")
            };

            _localService = new AppiumServiceBuilder().Build();
            _localService.Start();

            Driver = new IOSDriver(_localService.ServiceUrl,
                appiumOptions, TimeSpan.FromSeconds(180));

            Driver.LaunchApp();
        }

        public IOSDriver Driver { get; }


        public void Dispose()
        {
            _localService.Dispose();
            Driver.Quit();
        }
    }
}
