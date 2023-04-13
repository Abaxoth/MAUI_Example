//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;
//using OpenQA.Selenium.Appium.iOS;
//using OpenQA.Selenium.Appium.Service;
//using OpenQA.Selenium.Support.Extensions;
//using Xunit;
//using Xunit.Abstractions;

//namespace BlazorMauiUITesting.UITests;

//[Collection(nameof(DriverHolder))]
//public abstract class Tests 
//{
//    private readonly ITestOutputHelper _testOutputHelper;
//    private readonly DriverHolder _driverHolder;

//    public Tests(ITestOutputHelper testOutputHelper, DriverHolder driverHolder)
//    {
//        _testOutputHelper = testOutputHelper;
//        _driverHolder = driverHolder;
//    }
    
//    [Fact]
//    public async Task Test1()
//    {
//        _driverHolder.Driver.FindElement(By.XPath("//XCUIElementTypeButton[@name=\"Navigation menu\"]")).Click();
//        _driverHolder.Driver.FindElement(By.XPath("//XCUIElementTypeLink[@name=\"Counter\"]")).Click();

//        var clickButton = _driverHolder.Driver.FindElement(By.XPath("//XCUIElementTypeButton[@name=\"Click me\"]"));
//        for (var i = 0; i < 10; i++)
//        {
//            clickButton.Click();
//        }
        
//        await Task.Delay(TimeSpan.FromSeconds(10));

//        //var screenshot = _driverHolder.Driver.TakeScreenshot();
//        //screenshot.SaveAsFile("counter.jpeg", ScreenshotImageFormat.Jpeg);
//    }
//}