using CommonViewModel;
using SellPhoneVIewModel.Catalog.Categories;
using SellPhoneVIewModel.Catalog.ProductImages;
using SellPhoneVIewModel.Catalog.Products;
using System.Collections.Generic;
using Webapi.Entities;

namespace Websellphone.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
