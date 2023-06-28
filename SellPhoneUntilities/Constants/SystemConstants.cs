using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhoneUntilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "SellPhonepj";
        public const string CartSession = "CartSession";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 12;
            public const int NumberOfLatestProducts = 4;
        }

        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
}
