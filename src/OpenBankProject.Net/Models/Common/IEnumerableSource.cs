using System.Collections.Generic;

namespace OpenBankProject.Net.Models.Common
{
    public interface IEnumerableSource<out T>
    {
        IEnumerable<T> Items { get; }
    }
}
