using BlazorMauiUITesting.UITests.Helpers;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMauiUITesting.UITests.Adapters
{
    internal class AndroidAdapter: DriverAdapter
    {
        public AndroidAdapter(AppiumDriver driver) : base(driver)
        {
        }

        public override AppiumElement NavMenuElement()
        {
            return Driver.FindElement(SearchBy.ContainsText("Navigation menu"));
        }

        public override AppiumElement CounterElement()
        {
            return Driver.FindElement(SearchBy.ContainsText("Click me"));
        }

        public override void NavigateCounterTab()
        {
            TouchTap(Driver, 400, 560);
        }

        private void TouchTap(AppiumDriver driver, int x, int y)
        {
            var action = new TouchAction(driver);
            action.Tap(x, y);
            action.Perform();
        }

       
    }
}
