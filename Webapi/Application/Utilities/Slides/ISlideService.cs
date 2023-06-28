using SellPhoneVIewModel.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Webapi.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}
