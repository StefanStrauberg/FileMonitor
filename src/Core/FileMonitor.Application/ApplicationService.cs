namespace FileMonitor.Application;

public static class ApplicationService
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddHostedService<Server>();
        return services;
    }
}
