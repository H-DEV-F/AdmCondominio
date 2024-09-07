using AdmCondominio.Infra.Context;
using AdmCondominio.Api.Extensions;
using Microsoft.Extensions.Options;
using AdmCondominio.Domain.Contracts;
using AdmCondominio.Domain.Notification;
using AdmCondominio.Domain.Repositories;
using Swashbuckle.AspNetCore.SwaggerGen;
using AdmCondominio.Domain.Notification.Interfaces;

namespace AdmCondominio.Api.Config
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
