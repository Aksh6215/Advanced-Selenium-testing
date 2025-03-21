using OpenQA.Selenium;

namespace ComprehensiveTestSuite.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement UsernameField => Driver.FindElement(By.Id("username"));
        private IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => Driver.FindElement(By.CssSelector("button[type='submit']"));

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }

        public bool IsLoginSuccessful()
        {
            return Driver.PageSource.Contains("You logged into a secure area!");
        }
    }
}
