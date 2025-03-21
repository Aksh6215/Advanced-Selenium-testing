using DynamicLoadingElements.Pages;

namespace DynamicLoadingElements.Tests
{
    [TestFixture]
    [Category("DynamicLoading")]
    public class DynamicLoadingTests : BaseTest
    {
        [Test]
        public void VerifyExample1TextAppearsAfterLoading()
        {
            var dynamicPage = new DynamicLoadingExample1Page(Driver);
            dynamicPage.NavigateTo("https://the-internet.herokuapp.com/dynamic_loading/1");
            dynamicPage.ClickStartButton();

            string text = dynamicPage.WaitForElementAndRetrieveText();
            Assert.That(text, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void VerifyExample2TextAppearsAfterLoading()
        {
            var dynamicPage = new DynamicLoadingExample2Page(Driver);
            dynamicPage.NavigateTo("https://the-internet.herokuapp.com/dynamic_loading/2");
            dynamicPage.ClickStartButton();

            string text = dynamicPage.WaitForElementAndRetrieveText();
            Assert.That(text, Is.EqualTo("Hello World!"));
        }

        [Test]
        public void VerifyElementLoadingWithDifferentTimeouts()
        {
            var dynamicPage = new DynamicLoadingExample1Page(Driver);
            dynamicPage.NavigateTo("https://the-internet.herokuapp.com/dynamic_loading/1");
            dynamicPage.ClickStartButton();

            string text = dynamicPage.WaitForElementAndRetrieveText();
            Assert.That(text, Is.EqualTo("Hello World!"));
        }
    }
}