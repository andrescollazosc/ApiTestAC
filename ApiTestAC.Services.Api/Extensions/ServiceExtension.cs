using ApiTestAC.Data.DataAccess.Repositories;
using ApiTestAC.Domain.Contracts;
using ApiTestAC.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTestAC.Services.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
        }

        public static void ConfigureDependencies(this IServiceCollection services) {
            services.AddScoped<IGenericRepository<Operator>, OperatorRepository>();
        }


    }
}
