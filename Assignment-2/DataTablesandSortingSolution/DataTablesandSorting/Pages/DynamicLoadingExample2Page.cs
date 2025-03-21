using OpenQA.Selenium;
using DynamicLoadingElements.Utilities;

namespace DynamicLoadingElements.Pages
{
    public class DynamicLoadingExample2Page : DynamicLoadingPage
    {
        public DynamicLoadingExample2Page(IWebDriver driver) : base(driver) { }

        public string WaitForElementAndRetrieveText()
        {
            WaitHelper.WaitForElementToDisappear(Driver, LoadingIndicator);
            WaitHelper.WaitForElementToBeVisible(Driver, LoadedText);
            return Driver.FindElement(LoadedText).Text;
        }
    }
}
