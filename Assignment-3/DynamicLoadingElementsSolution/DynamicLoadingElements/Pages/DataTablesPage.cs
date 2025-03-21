/*
using OpenQA.Selenium;

namespace DataTablesSorting.Pages
{
    public class DataTablesPage : BasePage
    {
        private readonly By Table1Headers = By.CssSelector("#table1 thead th");
        private readonly By Table1Rows = By.CssSelector("#table1 tbody tr");

        public DataTablesPage(IWebDriver driver) : base(driver) { }

        public List<string> GetColumnData(int columnIndex)
        {
            var rows = Driver.FindElements(Table1Rows);
            return rows.Select(row => row.FindElements(By.TagName("td"))[columnIndex].Text.Trim()).ToList();
        }

        public void ClickColumnHeader(int columnIndex)
        {
            var headers = Driver.FindElements(Table1Headers);
            headers[columnIndex].Click();
        }

        public bool IsSortedAscending(int columnIndex)
        {
            var columnData = GetColumnData(columnIndex);
            return Utilities.SortHelper.IsSortedAscending(columnData);
        }

        public bool IsSortedDescending(int columnIndex)
        {
            var columnData = GetColumnData(columnIndex);
            return Utilities.SortHelper.IsSortedDescending(columnData);
        }
    }
}
*/


using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace DataTablesSorting.Pages
{
    public class DataTablesPage
    {
        private readonly IWebDriver _driver;

        // Element Locators
        private By TableRows => By.CssSelector("#table1 tbody tr");

        public DataTablesPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Methods
        public List<List<string>> GetAllRowData()
        {
            var rows = _driver.FindElements(TableRows);
            return rows.Select(row => row.FindElements(By.TagName("td")).Select(cell => cell.Text).ToList()).ToList();
        }

        public void SortByColumn(int columnIndex)
        {
            _driver.FindElement(By.CssSelector($"#table1 thead th:nth-child({columnIndex + 1})")).Click();
        }

        public bool IsSortedAscending(List<string> columnData)
        {
            var sortedData = columnData.OrderBy(x => x).ToList();
            return columnData.SequenceEqual(sortedData);
        }

        public bool IsSortedDescending(List<string> columnData)
        {
            var sortedData = columnData.OrderByDescending(x => x).ToList();
            return columnData.SequenceEqual(sortedData);
        }
    }
}
