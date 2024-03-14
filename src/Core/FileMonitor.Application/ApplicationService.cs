namespace FileMonitor.Application;

/// <summary>
/// Dependency Injection ApplicationService
/// </summary>
public static class ApplicationService
{
    /// <summary>
    /// Adding the business logic of the applications
    /// </summary>
    /// <param name="services">Services of the application</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddHostedService<Server>();
        return services;
    }
}
