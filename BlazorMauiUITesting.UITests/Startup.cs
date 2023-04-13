using BlazorMauiUITesting.UITests.Drivers;
using Castle.Core.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Windows;

namespace BlazorMauiUITesting.UITests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAppiumDriver<AndroidDriver>, AndroidProvider>();
            services.AddScoped<IAppiumDriver<IOSDriver>, IOSProvider>();
        }
    }
}
