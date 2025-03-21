using OpenQA.Selenium;
using DynamicLoadingElements.Utilities;

namespace DynamicLoadingElements.Pages
{
    public class DynamicLoadingExample1Page : DynamicLoadingPage
    {
        public DynamicLoadingExample1Page(IWebDriver driver) : base(driver) { }

        public string WaitForElementAndRetrieveText()
        {
            WaitHelper.WaitForElementToDisappear(Driver, LoadingIndicator);
            WaitHelper.WaitForElementToBeVisible(Driver, LoadedText);
            return Driver.FindElement(LoadedText).Text;
        }
    }
}
