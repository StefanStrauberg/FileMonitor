namespace FileMonitor.InspectorOfTypeOfServer;

/// <summary>
/// Inspector receive necessary information of type of being started services from configuration file 
/// for correct way to run the application 
/// </summary>
internal sealed class InspectorOfTypeOfServer(IConfiguration configuration) 
    : IInspectorOfTypeOfServer
{
    readonly IConfiguration _configuration = configuration
        ?? throw new ArgumentNullException(nameof(configuration));

    /// <summary>
    /// Get type of being started producer from configuration file
    /// </summary>
    /// <returns>Type of being started producer</returns>
    TypeOfProducer IInspectorOfTypeOfServer.GetTypeOfProducer()
            => Enum.Parse<TypeOfProducer>(_configuration.GetSection("ServiceConfiguration")
                                                        .GetSection("Producer")
                                                        .GetChildren()
                                                        .First()
                                                        .Key);

    /// <summary>
    /// Get type of being started receiver from configuration file
    /// </summary>
    /// <returns>Type of being started receiver</returns>
    TypeOfReceiver IInspectorOfTypeOfServer.GetTypeOfReceiver()
        => Enum.Parse<TypeOfReceiver>(_configuration.GetSection("ServiceConfiguration")
                                                    .GetSection("Receiver")
                                                    .GetChildren()
                                                    .First()
                                                    .Key);
}