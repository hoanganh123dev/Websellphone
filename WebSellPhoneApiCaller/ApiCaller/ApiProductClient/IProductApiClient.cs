using CommonViewModel;
using SellPhoneVIewModel.Catalog.Products;
using SellPhoneVIewModel.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSellPhoneApiCaller.ApiCaller.ApiProductClient
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManagerProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductViewModel> GetById(int id, string languageId);

        Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductViewModel>> GetLatestProducts(string languageId, int take);

        Task<bool> DeleteProduct(int id);
    }
}
