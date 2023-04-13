using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using Xunit;

namespace BlazorMauiUITesting.UITests;

public class DriverHolder 
{
    public AppiumDriver Driver { get; private set; }
    public DriverHolder()
    {
        var solutionDirectory = Path.GetFullPath(
            Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));

        var appiumOptions = new AppiumOptions  // please check our local versions of xcode and ios
        {
            PlatformName = "iOS",
            AutomationName = "XCuiTest",
            DeviceName = "iPhone 14",
            PlatformVersion = "16.2",
    
            // Please check your app path
            // Replace iossimulator-arm64 with iossimulator-x64 if you use x64 simulator
            App = Path.Combine(solutionDirectory, "BlazorMauiUITesting/bin/Debug/net7.0-ios/iossimulator-arm64/BlazorMauiUITesting.app")
        };

        var localService = new AppiumServiceBuilder().Build();
        localService.Start();
        
        //Driver = new AndroidDriver(localService.ServiceUrl, appiumOptions, TimeSpan.FromSeconds(180));
        Driver = new IOSDriver(localService.ServiceUrl, appiumOptions, TimeSpan.FromSeconds(180));
    }

    public Task InitializeAsync()
    {
        Driver.LaunchApp();
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        Driver.Quit();
        return Task.CompletedTask;
    }
}