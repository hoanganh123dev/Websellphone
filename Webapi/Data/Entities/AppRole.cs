using Microsoft.AspNetCore.Identity;
using System;

namespace Webapi.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
