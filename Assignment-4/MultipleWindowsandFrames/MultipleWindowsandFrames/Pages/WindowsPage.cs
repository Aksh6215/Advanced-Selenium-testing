using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebElement WaitForElement(By by)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(10))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        // Method to switch to a window based on its handle
        public void SwitchToWindow(string windowHandle)
        {
            Driver.SwitchTo().Window(windowHandle);
        }

        // Method to switch to an iframe
        public void SwitchToFrame(By iframeLocator)
        {
            Driver.SwitchTo().Frame(WaitForElement(iframeLocator));
        }

        // Switch back to the main document
        public void SwitchToMainContent()
        {
            Driver.SwitchTo().DefaultContent();
        }
    }
}
