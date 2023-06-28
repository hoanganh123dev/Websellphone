using SellPhoneVIewModel.Common;
using SellPhoneVIewModel.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSellPhoneApiCaller.ApiCaller.ApiLanguageClient
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
