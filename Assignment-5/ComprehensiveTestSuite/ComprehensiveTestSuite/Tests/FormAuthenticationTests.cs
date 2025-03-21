using ComprehensiveTestSuite.Pages;
using NUnit.Framework;

namespace ComprehensiveTestSuite.Tests
{
    [TestFixture]
    [Category("Authentication")]
    public class FormAuthenticationTests : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.NavigateTo("https://the-internet.herokuapp.com/login");
            loginPage.Login("tomsmith", "SuperSecretPassword!");

            Assert.That(loginPage.IsLoginSuccessful(), Is.True);
        }
    }
}
