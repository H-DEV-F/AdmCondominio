using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;

namespace AdmCondominio.Infra.Context
{
    public class AdmCondominioDbContextFactory : IDesignTimeDbContextFactory<AdmCondominioDbContext>
    {
        public AdmCondominioDbContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../AdmCondominio.Api");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AdmCondominioDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new AdmCondominioDbContext(optionsBuilder.Options);
        }
    }
}