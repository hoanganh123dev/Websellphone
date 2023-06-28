using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebsellphoneAdmin.Models
{
    public class NavigationViewModel
    {
        public List<SelectListItem> Languages { get; set; }

        public string CurrentLanguageId { get; set; }

        public string ReturnUrl { set; get; }
    }
}
