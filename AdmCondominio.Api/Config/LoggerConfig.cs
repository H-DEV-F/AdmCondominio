using AdmCondominio.Infra.Data.HealthCheck;

namespace AdmCondominio.Api.Config
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddCheck("Db_Query", new SqlServerHealthCheck(configuration.GetConnectionString("DefaultConnection")))
                .AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "Db_Connection");

            services
                .AddHealthChecksUI()
                .AddInMemoryStorage()
                .AddSqlServerStorage(configuration.GetConnectionString("DefaultConnection"));

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app) => app;
    }
}