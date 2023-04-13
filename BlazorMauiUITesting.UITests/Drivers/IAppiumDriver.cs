using OpenQA.Selenium.Appium;

namespace BlazorMauiUITesting.UITests.Drivers
{
    public interface IAppiumDriver<out TDriver>
         where TDriver : AppiumDriver
    {
        public TDriver Driver { get; }
    }
}
