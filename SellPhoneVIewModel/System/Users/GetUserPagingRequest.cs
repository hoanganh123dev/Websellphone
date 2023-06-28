using CommonViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhoneVIewModel.System.Users
{
    public class GetUserPagingRequest :PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
