namespace FileMonitor.FileReceiver;

/// <summary>
/// Dependency Injection FileReceiverService
/// </summary>
public static class FileReceiverService
{
    /// <summary>
    /// Adding a temporary shared buffer to the application
    /// </summary>
    /// <param name="services">Services of the application</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddTemporaryBufferServices(this IServiceCollection services,
                                                                IConfiguration configuration)
    {
        services.Configure<IFileReceiverConfiguration>(
                configuration.GetSection("ServiceConfiguration")
                             .GetSection("Receiver")
                             .GetSection("udp"));
            services.AddSingleton<IFileReceiverConfiguration>(provider =>
                provider.GetRequiredService<IOptions<ReceiverConfiguration>>().Value);
        services.AddSingleton<IFileReceiver, FileReceiver>();
        return services;
    }
}
