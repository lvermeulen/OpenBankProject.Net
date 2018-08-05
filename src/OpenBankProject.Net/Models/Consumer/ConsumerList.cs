using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Consumer
{
    public class ConsumerList : IEnumerableSource<Consumer>
    {
        public List<Consumer> List { get; set; }
        public IEnumerable<Consumer> Items => List;
    }
}
