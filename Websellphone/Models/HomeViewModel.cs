using SellPhoneVIewModel.Catalog.Products;
using SellPhoneVIewModel.Utilities.Slides;
using System.Collections.Generic;
using Webapi.Entities;

namespace Websellphone.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductViewModel> FeaturedProducts { get; set; }

        public List<ProductViewModel> LatestProducts { get; set; }
    }
}
