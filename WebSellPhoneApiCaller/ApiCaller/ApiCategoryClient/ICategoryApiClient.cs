using SellPhoneVIewModel.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSellPhoneApiCaller.ApiCaller.ApiCategoryClient
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll(string languageId);

        Task<CategoryViewModel> GetById(string languageId, int id);
    }
}
