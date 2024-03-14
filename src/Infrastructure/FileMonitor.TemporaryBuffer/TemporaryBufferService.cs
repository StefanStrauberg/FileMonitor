namespace FileMonitor.TemporaryBuffer;

/// <summary>
/// Dependency Injection TemporaryBufferService
/// </summary>
public static class TemporaryBufferService
{
    /// <summary>
    /// Adding a temporary shared buffer to the application
    /// </summary>
    /// <param name="services">Services of the application</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddTemporaryBufferServices(this IServiceCollection services)
    {
        services.AddSingleton<IBufferRepository, BufferRepository>();
        return services;
    }
}
