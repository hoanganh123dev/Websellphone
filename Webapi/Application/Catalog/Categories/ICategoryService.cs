using SellPhoneVIewModel.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Webapi.Entities;

namespace Webapi.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll(string languageId);

        Task<CategoryViewModel> GetById(string languageId, int id);
    }
}
