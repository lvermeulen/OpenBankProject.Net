using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class MessageDocList : IEnumerableSource<MessageDoc>
    {
        public List<MessageDoc> MessageDocs { get; set; }
        public IEnumerable<MessageDoc> Items => MessageDocs;
    }
}
