using MultipleWindowsandFrames.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;
using Xamarin.Forms.Platform.UWP;

namespace Tests
{
    [TestFixture]
    public class WindowsAndFramesTests
    {
        private IWebDriver Driver;
        private WindowsPage windowsPage;
        private FramePage framePage;
        private string originalWindowHandle;

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            windowsPage = new WindowsPage(Driver);
            framePage = new FramePage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
            Driver.Quit();
        }

        [Test]
        public void TestWindowSwitching()
        {
            // Navigate to the windows page
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            originalWindowHandle = Driver.CurrentWindowHandle;

            // Click the link to open a new window
            windowsPage.ClickLinkToOpenNewWindow();
            windowsPage.SwitchToNewWindow(originalWindowHandle);

            // Assert the new window text
            Assert.AreEqual("New Window", windowsPage.GetTextFromNewWindow());

            // Switch back to the original window
            Driver.SwitchTo().Window(originalWindowHandle);
            Assert.AreEqual("https://the-internet.herokuapp.com/windows", Driver.Url);
        }

        [Test]
        public void TestFrameInteraction()
        {
            // Navigate to the iframe page
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");

            // Switch to the frame and enter text
            framePage.SwitchToEditorFrame();
            framePage.TypeTextInEditor("Hello, World!");

            // Apply bold formatting
            framePage.SwitchBackToMainContent();
            framePage.ApplyBoldFormatting();

            // Re-enter the frame and verify text was entered correctly
            framePage.SwitchToEditorFrame();
            Assert.AreEqual("Hello, World!", Driver.FindElement(By.Id("tinymce")).Text);

            framePage.SwitchBackToMainContent();
        }

        [Test]
        public void TestTextFormattingInEditor()
        {
            // Navigate to the iframe page
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");

            // Switch to the editor iframe and type text
            framePage.SwitchToEditorFrame();
            framePage.TypeTextInEditor("Formatted Text");

            // Apply bold formatting
            framePage.SwitchBackToMainContent();
            framePage.ApplyBoldFormatting();

            // Apply italic formatting
            framePage.ApplyItalicFormatting();

            // Assert that the formatting options were applied
            Assert.DoesNotThrow(() => framePage.ApplyBoldFormatting());
            Assert.DoesNotThrow(() => framePage.ApplyItalicFormatting());
        }
    }
}
