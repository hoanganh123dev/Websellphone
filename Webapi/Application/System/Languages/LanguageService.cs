using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SellPhoneVIewModel.Common;
using SellPhoneVIewModel.System.Languages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.EF;

namespace Webapi.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _config;
        private readonly SellPhoneDbContext _context;

        public LanguageService(SellPhoneDbContext context,
            IConfiguration config)
        {
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name,
                IsDefault = x.IsDefault
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}
