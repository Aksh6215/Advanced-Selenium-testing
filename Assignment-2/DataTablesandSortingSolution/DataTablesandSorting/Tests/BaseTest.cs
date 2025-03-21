using NUnit.Framework;
using OpenQA.Selenium;
using DynamicLoadingElements.Utilities;
using System;
using OpenQA.Selenium.Chrome;

namespace DynamicLoadingElements.Tests
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
