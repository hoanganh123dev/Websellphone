using SellPhoneVIewModel.Common;
using SellPhoneVIewModel.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Webapi.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
