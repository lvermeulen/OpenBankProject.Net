using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.User
{
    public class UserList : IEnumerableSource<Common.User>
    {
        public List<Common.User> Users { get; set; }
        public IEnumerable<Common.User> Items => Users;
    }
}
