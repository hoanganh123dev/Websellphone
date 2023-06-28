using CommonViewModel;

namespace SellPhoneVIewModel.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }

    }
}
