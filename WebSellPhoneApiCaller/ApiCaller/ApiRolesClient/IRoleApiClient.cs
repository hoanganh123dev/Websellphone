using SellPhoneVIewModel.Common;
using SellPhoneVIewModel.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSellPhoneApiCaller.ApiCaller.ApiRolesClient
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}
