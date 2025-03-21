using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ComprehensiveTestSuite.Pages
{
    public class CheckboxesPage : BasePage
    {
        private IReadOnlyCollection<IWebElement> Checkboxes => Driver.FindElements(By.CssSelector("input[type='checkbox']"));

        public CheckboxesPage(IWebDriver driver) : base(driver) { }

        public void ToggleCheckbox(int index)
        {
            Checkboxes.ElementAt(index).Click();
        }

        public bool IsCheckboxChecked(int index)
        {
            return Checkboxes.ElementAt(index).Selected;
        }
    }
}
