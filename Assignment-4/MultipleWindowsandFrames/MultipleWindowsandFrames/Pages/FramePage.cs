using MultipleWindowsandFrames.Pages;
using OpenQA.Selenium;

namespace Pages
{
    public class FramePage : BasePage
    {
        private By IframeLocator = By.Id("mce_0_ifr");
        private By TextEditor = By.Id("tinymce");
        private By BoldButton = By.CssSelector("[aria-label='Bold']");
        private By ItalicButton = By.CssSelector("[aria-label='Italic']");

        public FramePage(IWebDriver driver) : base(driver) { }

        // Switch to the iframe
        public void SwitchToEditorFrame()
        {
            SwitchToFrame(IframeLocator);
        }

        // Type text in the rich text editor
        public void TypeTextInEditor(string text)
        {
            var editor = WaitForElement(TextEditor);

            // Clear the editor using JavaScript since it's content-editable
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].innerHTML = '';", editor);

            // Now type new text
            editor.SendKeys(text);
        }

        // Apply bold formatting
        public void ApplyBoldFormatting()
        {
            WaitForElement(BoldButton).Click();
        }

        // Apply italic formatting
        public void ApplyItalicFormatting()
        {
            WaitForElement(ItalicButton).Click();
        }

        // Switch back to the main content from the iframe
        public void SwitchBackToMainContent()
        {
            Driver.SwitchTo().DefaultContent();
        }
    }
}
