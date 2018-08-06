using System;
using System.Collections.Generic;
using OpenBankProject.Net.Models.Transaction;

namespace OpenBankProject.Net.Common
{
    public static class SortDirectionConverter
    {
        private static readonly IDictionary<SortDirection, string> s_stringBySortDirection = new Dictionary<SortDirection, string>
        {
            [SortDirection.Descending] = "DESC",
            [SortDirection.Ascending] = "ASC"
        };

        public static string ConvertToString(this SortDirection sortDirection)
        {
            if (!s_stringBySortDirection.TryGetValue(sortDirection, out string result))
            {
                throw new ArgumentException($"Unknown sort direction: {sortDirection}");
            }

            return result;
        }

        public static string ConvertNullableToString(this SortDirection? sortDirection) => sortDirection.HasValue
            ? ConvertToString(sortDirection.Value)
            : null;
    }
}
