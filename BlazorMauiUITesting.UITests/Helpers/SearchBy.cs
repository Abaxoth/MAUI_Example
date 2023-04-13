using OpenQA.Selenium.Appium;

namespace BlazorMauiUITesting.UITests.Helpers
{
    public static class SearchBy
    {
        public static ByAndroidUIAutomator ContainsText(string text)
        {
            return new ByAndroidUIAutomator
                ($"new UiSelector().textContains(\"{text}\")");
        }
    }
}
