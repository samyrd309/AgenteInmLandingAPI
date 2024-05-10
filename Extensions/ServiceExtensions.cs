namespace Extensions {
    using Contracts;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Repository;
    public static class ServiceExtensions {
        public static void ConfigureCors(this IServiceCollection services) {
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy", builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config) {
            var connectionString = config["mysqlconnection:connectionString"];
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 26)); // Replace with the appropriate server version
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString, serverVersion));   
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services) {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
   
    }
}