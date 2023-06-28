using Microsoft.AspNetCore.Mvc;
using SellPhoneVIewModel.Common;
using System.Threading.Tasks;

namespace WebsellphoneAdmin.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        //View component
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
