using CP2.Application.Services;
using CP2.Data.AppData;
using CP2.Data.Repositories;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CP2.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(x => {
                x.UseOracle(configuration["ConnectionStrings:Oracle"]);
            });


            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IVendedorRepository, VendedorRepository>();

            services.AddTransient<IFornecedorApplicationService, FornecedorApplicationService>();
            services.AddTransient<IVendedorApplicationService, VendedorApplicationService>();


        }
    }
}
