/*
using System.Globalization;

namespace DataTablesSorting.Utilities
{
    public static class SortHelper
    {
        public static bool IsSortedAscending(List<string> data)
        {
            var sorted = new List<string>(data);
            sorted.Sort(CompareValues);
            return data.SequenceEqual(sorted);
        }

        public static bool IsSortedDescending(List<string> data)
        {
            var sorted = new List<string>(data);
            sorted.Sort(CompareValues);
            sorted.Reverse();
            return data.SequenceEqual(sorted);
        }

        private static int CompareValues(string x, string y)
        {
            if (decimal.TryParse(x, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal numX) &&
                decimal.TryParse(y, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal numY))
            {
                return numX.CompareTo(numY);
            }
            if (DateTime.TryParse(x, out DateTime dateX) && DateTime.TryParse(y, out DateTime dateY))
            {
                return dateX.CompareTo(dateY);
            }
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}
*/