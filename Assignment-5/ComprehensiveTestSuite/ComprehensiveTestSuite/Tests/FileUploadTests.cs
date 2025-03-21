using ComprehensiveTestSuite.Pages;
using NUnit.Framework;

namespace ComprehensiveTestSuite.Tests
{
    [TestFixture]
    [Category("File Upload")]
    public class FileUploadTests : BaseTest
    {
        [Test]
        public void FileUploadTest()
        {
            var fileUploadPage = new FileUploadPage(Driver);
            fileUploadPage.NavigateTo("https://the-internet.herokuapp.com/upload");
            fileUploadPage.UploadFile("C:\\Users\\Raghav\\Desktop\\Capegemini Training Assignments\\Testing\\Selenium\\Assignment5 - Comprehensive Test Suite\\ComprehensiveTestSuite\\Tests\\file.txt");

            Assert.That(fileUploadPage.IsUploadSuccessful(), Is.True);
        }
    }
}
