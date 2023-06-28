using SellPhoneVIewModel.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Webapi.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();
    }
}
