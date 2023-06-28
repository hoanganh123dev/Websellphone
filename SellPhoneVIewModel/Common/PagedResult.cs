using SellPhoneVIewModel.Common;
using System.Collections.Generic;

namespace SellPhoneVIewModel.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
    }
}
