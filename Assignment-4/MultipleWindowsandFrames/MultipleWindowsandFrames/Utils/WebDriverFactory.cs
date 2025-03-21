using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver(string browser)
        {
            return browser switch
            {
                "Chrome" => new ChromeDriver(),
                // You can add support for Firefox, Edge, etc.
                _ => throw new ArgumentException("Browser not supported"),
            };
        }
    }
}
