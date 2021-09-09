using LeakGas.Business.Interfaces.Data;
using LeakGas.Data.Context;
using LeakGas.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<LeakGasContext>();

            //services.AddScoped<INotificador, Notificador>();

            #region Repos
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();

            #endregion

            return services;
        }
    }
}
