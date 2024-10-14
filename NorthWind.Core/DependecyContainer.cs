namespace Microsoft.Extensions.DependencyInjection;

public static class DependecyContainer
{
    public static IServiceCollection AddServices(
       this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, IAppLogger>();
        services.AddSingleton<IProductService, IProductService>();
        return services;
    }

}
