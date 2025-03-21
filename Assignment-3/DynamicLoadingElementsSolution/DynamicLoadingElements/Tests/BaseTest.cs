/*
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DataTablesSorting.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                ((ITakesScreenshot)Driver).GetScreenshot()
                    .SaveAsFile($"{TestContext.CurrentContext.Test.Name}.png");
            }
            Driver.Dispose();
            Driver.Quit();
        }
    }
}
*/