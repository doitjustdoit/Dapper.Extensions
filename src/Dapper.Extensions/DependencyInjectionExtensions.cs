﻿using Dapper.Extensions.SQL;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDapper<TDbProvider>(this IServiceCollection services) where TDbProvider : IDapper
        {
            return services.AddScoped(typeof(IDapper), typeof(TDbProvider));
        }

        /// <summary>
        /// Enable SQL separation
        /// </summary>
        /// <param name="services"></param>
        /// <param name="xmlRootDir">The root directory of the xml file</param>
        /// <returns></returns>
        public static IServiceCollection AddSQLSeparationForDapper(this IServiceCollection services, string xmlRootDir)
        {
            services.AddSingleton(new SQLSeparateConfigure
            {
                RootDir = xmlRootDir
            });
            return services.AddSingleton<ISQLManager, SQLManager>();
        }
    }
}
