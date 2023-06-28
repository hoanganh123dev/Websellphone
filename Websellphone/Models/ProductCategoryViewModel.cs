using SellPhoneVIewModel.Common;
using SellPhoneVIewModel.Catalog.Categories;
using SellPhoneVIewModel.Catalog.Products;
using Webapi.Entities;

namespace Websellphone.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}
