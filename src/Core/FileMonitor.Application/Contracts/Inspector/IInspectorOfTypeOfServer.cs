namespace FileMonitor.Application.Contracts.Inspector;

/// <summary>
/// Validate configuration and provide information of type of services that app has to run
/// </summary>
public interface IInspectorOfTypeOfServer
{
    /// <summary>
    /// Get enum type of receiver
    /// </summary>
    /// <returns></returns>
    TypeOfReceiver GetTypeOfReceiver();
    /// <summary>
    /// Get enum type of producer
    /// </summary>
    /// <returns></returns>
    TypeOfProducer GetTypeOfProducer();
}
