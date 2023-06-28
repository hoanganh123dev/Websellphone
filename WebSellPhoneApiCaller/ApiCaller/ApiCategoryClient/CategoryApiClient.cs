using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SellPhoneVIewModel.Catalog.Categories;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebSellPhoneApiCaller.ApiCaller.ApiCategoryClient
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                  IHttpContextAccessor httpContextAccessor,
                   IConfiguration configuration)
           : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryViewModel>("/api/categories?languageId=" + languageId);
        }

        public async Task<CategoryViewModel> GetById(string languageId, int id)
        {
            return await GetAsync<CategoryViewModel>($"/api/categories/{id}/{languageId}");
        }
    }
}
