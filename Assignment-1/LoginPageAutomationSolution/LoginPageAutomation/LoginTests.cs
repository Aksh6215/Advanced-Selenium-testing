//using LoginPageAutomation;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;

namespace Tests
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver Driver;
        private LoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            LoginPage = new LoginPage(Driver);
            LoginPage.NavigateTo("https://the-internet.herokuapp.com/login");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
            Driver.Quit();
        }

        [Test]
        [TestCase("tomsmith", "SuperSecretPassword!", true)]
        [TestCase("invaliduser", "SuperSecretPassword!", false)]
        [TestCase("", "", false)]
        public void TestLogin(string username, string password, bool shouldSucceed)
        {
            LoginPage.EnterUsername(username);
            LoginPage.EnterPassword(password);
            var securePage = LoginPage.ClickLoginButton();

            if (shouldSucceed)
            {
                Assert.IsTrue(securePage.IsSuccessMessageDisplayed());
            }
            else
            {
                Assert.IsTrue(LoginPage.GetErrorMessage().Contains("Your username is invalid!"));
            }
        }
    }
}
