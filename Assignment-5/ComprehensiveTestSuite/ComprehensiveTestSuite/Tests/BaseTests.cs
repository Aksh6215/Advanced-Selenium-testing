using ComprehensiveTestSuite.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace ComprehensiveTestSuite.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void SetUp()
        {
            string browser = TestContext.Parameters.Get("browser", "chrome");
            Driver = WebDriverFactory.CreateDriver(browser);
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
