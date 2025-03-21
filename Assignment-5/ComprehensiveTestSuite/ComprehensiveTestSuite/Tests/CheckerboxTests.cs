using ComprehensiveTestSuite.Pages;

namespace ComprehensiveTestSuite.Tests
{
    [TestFixture]
    [Category("Checkboxes")]
    public class CheckboxTests : BaseTest
    {
        [Test]
        public void ToggleCheckboxTest()
        {
            var checkboxesPage = new CheckboxesPage(Driver);
            checkboxesPage.NavigateTo("https://the-internet.herokuapp.com/checkboxes");
            checkboxesPage.ToggleCheckbox(0);

            Assert.That(checkboxesPage.IsCheckboxChecked(0), Is.True);
        }
    }
}
