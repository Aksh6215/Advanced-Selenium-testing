using ComprehensiveTestSuite.Pages;
using NUnit.Framework;

namespace ComprehensiveTestSuite.Tests
{
    [TestFixture]
    [Category("Dropdown")]
    public class DropdownTests : BaseTest
    {
        [Test]
        public void SelectDropdownOptionTest()
        {
            var dropdownPage = new DropdownPage(Driver);
            dropdownPage.NavigateTo("https://the-internet.herokuapp.com/dropdown");
            dropdownPage.SelectOption("Option 1");

            Assert.That(dropdownPage.GetSelectedOption(), Is.EqualTo("Option 1"));
        }
    }
}
