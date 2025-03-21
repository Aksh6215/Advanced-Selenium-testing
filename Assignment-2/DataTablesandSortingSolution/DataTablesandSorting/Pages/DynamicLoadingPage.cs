using OpenQA.Selenium;

namespace DynamicLoadingElements.Pages
{
    public class DynamicLoadingPage : BasePage
    {
        protected By StartButton = By.CssSelector("#start button");
        protected By LoadingIndicator = By.Id("loading");
        protected By LoadedText = By.Id("finish");

        public DynamicLoadingPage(IWebDriver driver) : base(driver) { }

        public void ClickStartButton()
        {
            Driver.FindElement(StartButton).Click();
        }
    }
}
