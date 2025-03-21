
/*using DataTablesSorting.Pages;

namespace DataTablesSorting.Tests
{
    [TestFixture]
    [Category("DataTables")]
    public class DataTablesTests : BaseTest
    {
        [SetUp]
        public void SetUpTest()
        {
            var dataTablesPage = new DataTablesPage(Driver);
            dataTablesPage.NavigateTo("https://the-internet.herokuapp.com/tables");
        }

        [Test]
        [TestCase(0)] // Last Name column
        [TestCase(1)] // First Name column
        [TestCase(2)] // Email column
        [TestCase(3)] // Due column
        [TestCase(4)] // Web Site column
        public void VerifySortingFunctionality(int columnIndex)
        {
            var dataTablesPage = new DataTablesPage(Driver);

            // Click column header to sort Ascending
            dataTablesPage.ClickColumnHeader(columnIndex);
            Assert.That(dataTablesPage.IsSortedAscending(columnIndex), Is.True, $"Column {columnIndex} is not sorted ascending");

            // Click column header to sort Descending
            dataTablesPage.ClickColumnHeader(columnIndex);
            Assert.That(dataTablesPage.IsSortedDescending(columnIndex), Is.True, $"Column {columnIndex} is not sorted descending");
        }
    }
}
*/



using DataTablesSorting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DataTablesSorting.Tests
{
    [TestFixture]
    public class DataTablesTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Dispose();
            _driver.Quit();
        }

        [Test]
        public void TestTableSorting()
        {
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            var dataTablesPage = new DataTablesPage(_driver);

            // Sort by the first column (Last Name)
            dataTablesPage.SortByColumn(0);
            var columnData = dataTablesPage.GetAllRowData().Select(row => row[0]).ToList();
            //Assert.IsTrue(dataTablesPage.IsSortedAscending(columnData));
            Assert.That(dataTablesPage.IsSortedAscending(columnData), Is.True);

        }
    }
}
