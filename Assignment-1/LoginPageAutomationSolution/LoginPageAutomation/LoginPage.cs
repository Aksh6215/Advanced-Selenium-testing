using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage : BasePage
    {
        private By UsernameField = By.Id("username");
        private By PasswordField = By.Id("password");
        private By LoginButton = By.CssSelector("button[type='submit']");
        private By ErrorMessage = By.CssSelector(".flash.error");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void EnterUsername(string username)
        {
            WaitForElement(UsernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            WaitForElement(PasswordField).SendKeys(password);
        }

        public SecurePage ClickLoginButton()
        {
            WaitForElement(LoginButton).Click();
            return new SecurePage(Driver);
        }

        public string GetErrorMessage()
        {
            return WaitForElement(ErrorMessage).Text;
        }
    }
}
