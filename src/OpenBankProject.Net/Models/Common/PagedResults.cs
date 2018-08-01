using System.Collections.Generic;

namespace OpenBankProject.Net.Models.Common
{
    public class PagedResults<T>
    {
        public int Limit { get; set; }
        public List<T> Values { get; set; }
        public int? NextPageStart { get; set; }
        public int Size { get; set; }
        public bool IsLastPage { get; set; }
        public int Start { get; set; }
    }
}
