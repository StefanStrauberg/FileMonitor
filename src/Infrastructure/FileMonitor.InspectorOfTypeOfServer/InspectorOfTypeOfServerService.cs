namespace FileMonitor.InspectorOfTypeOfServer;

/// <summary>
/// Dependency Injection InspectorOfTypeOfServerService
/// </summary>
public static class InspectorOfTypeOfServerService
{
    /// <summary>
    /// Adding a temporary shared buffer to the application
    /// </summary>
    /// <param name="services">Services of the application</param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddTemporaryBufferServices(this IServiceCollection services)
    {
        services.AddSingleton<IInspectorOfTypeOfServer, InspectorOfTypeOfServer>();
        return services;
    }
}
