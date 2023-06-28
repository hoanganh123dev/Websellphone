using SellPhoneVIewModel.Sales;
using System.Collections.Generic;

namespace Websellphone.Models
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public CheckoutRequest CheckoutModel { get; set; }
    }
}
