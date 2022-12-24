using AdmCondominio.Business.Contracts;
using AdmCondominio.Business.Notification;
using AdmCondominio.Business.Notification.Interfaces;
using AdmCondominio.Data.Context;
using AdmCondominio.Data.Repository;
using AdmCondominio.Extensions;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AdmCondominio.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<AdmCondominioDbContext>();

            services.AddTransient<ICondominioRepository, CondominioRepository>();
            services.AddTransient<IApartamentoRepository, ApartamentoRepository>();
            services.AddTransient<IMoradorRepository, MoradorRepository>();
            services.AddTransient<IBlocoRepository, BlocoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IUser, AspNetUser>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}
