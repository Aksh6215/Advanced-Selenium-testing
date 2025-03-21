using OpenQA.Selenium;

namespace ComprehensiveTestSuite.Pages
{
    public class FileUploadPage : BasePage
    {
        private IWebElement UploadInput => Driver.FindElement(By.Id("file-upload"));
        private IWebElement UploadButton => Driver.FindElement(By.Id("file-submit"));

        public FileUploadPage(IWebDriver driver) : base(driver) { }

        public void UploadFile(string filePath)
        {
            UploadInput.SendKeys(filePath);
            UploadButton.Click();
        }

        public bool IsUploadSuccessful()
        {
            return Driver.PageSource.Contains("File Uploaded!");
        }
    }
}
