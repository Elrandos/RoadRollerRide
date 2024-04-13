using RoadRollerRide.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using RoadRollerRide.Interfaces.Services;
using IServiceCollection = Microsoft.Extensions.DependencyInjection.IServiceCollection;

namespace RoadRollerRide.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommonServices(this IServiceCollection collection)
        {
            collection.AddSingleton<IDatabaseService, DatabaseService>();
            collection.AddTransient<IRandomService, RandomService>();
            collection.AddTransient<MainViewModel>();
        }
    }
}
