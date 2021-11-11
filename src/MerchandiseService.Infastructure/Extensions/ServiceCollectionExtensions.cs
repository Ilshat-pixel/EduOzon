using MerchandiseService.Domain.AggregatesModels.PersonsAggregation.EmployeeAggregation;
using MerchandiseService.Domain.AggregatesModels.PersonsAggregation.ManagerAggregation;
using MerchandiseService.Domain.MerchOrderAggregation;
using MerchandiseService.Infastructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace MerchandiseService.Infastructure.Extensions
{
    public class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateMerchOrderCommandHandler).Assembly);
            return services;
        }

        public static IServiceCollection AddInfrastructureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMerchOrderRepository, MerchOrderRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IManagerRepository, ManagerRepository>();
            return services;
        }
    }


}