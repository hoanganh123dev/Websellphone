using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Webapi.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<SellPhoneDbContext>
    {
        public SellPhoneDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("SellPhonepj");

            var optionsBuilder = new DbContextOptionsBuilder<SellPhoneDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SellPhoneDbContext(optionsBuilder.Options);
        }
    }
}
