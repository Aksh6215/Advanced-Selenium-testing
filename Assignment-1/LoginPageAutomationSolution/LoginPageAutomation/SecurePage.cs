using OpenQA.Selenium;

namespace Pages
{
    public class SecurePage : BasePage
    {
        private By LogoutButton = By.CssSelector("a.button");
        private By SuccessMessage = By.CssSelector(".flash.success");

        public SecurePage(IWebDriver driver) : base(driver) { }

        public bool IsSuccessMessageDisplayed()
        {
            return WaitForElement(SuccessMessage).Displayed;
        }

        public void Logout()
        {
            WaitForElement(LogoutButton).Click();
        }
    }
}
