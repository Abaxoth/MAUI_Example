using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using Xunit;

namespace BlazorMauiUITesting.UITests.Drivers
{
    public class AndroidProvider: IAppiumDriver<AndroidDriver>, IDisposable
    {
        private readonly AppiumLocalService _localService;


        public AndroidProvider()
        {
            var solutionDirectory = Path.GetFullPath
            (Path.Combine(AppContext.BaseDirectory,
                "..", "..", "..", ".."));

            var appiumOptions = new AppiumOptions 
            {
                PlatformName = "Android",
                AutomationName = "UiAutomator2",
                DeviceName = "Samsung SM-G973U",
                PageLoadStrategy = PageLoadStrategy.Default,

                App = Path.Combine(solutionDirectory,
                    "BlazorMauiUITesting/bin/Release/net7.0-android/com.companyname.blazormauiuitesting-Signed.apk")
            };

            _localService = new AppiumServiceBuilder().Build();
            _localService.Start();

            Task.Delay(5000).Wait(); //todo delete

            Driver = new AndroidDriver(_localService.ServiceUrl,
                appiumOptions, TimeSpan.FromSeconds(180));

            Driver.LaunchApp();
        }

        public AndroidDriver Driver { get; }

        public void Dispose()
        {
            _localService.Dispose();
            Driver.Quit();
        }
    }
}
