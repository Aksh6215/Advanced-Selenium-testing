using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace ComprehensiveTestSuite.Pages
{
    public class DropdownPage : BasePage
    {
        private IWebElement Dropdown => Driver.FindElement(By.Id("dropdown"));

        public DropdownPage(IWebDriver driver) : base(driver) { }

        public void SelectOption(string option)
        {
            new SelectElement(Dropdown).SelectByText(option);
        }

        public string GetSelectedOption()
        {
            return new SelectElement(Dropdown).SelectedOption.Text;
        }
    }
}
