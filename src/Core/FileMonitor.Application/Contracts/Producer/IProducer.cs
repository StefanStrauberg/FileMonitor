namespace FileMonitor.Application.Contracts.Producer;

/// <summary>
/// General interface for running producing services
/// </summary>
public interface IProducer : IDisposable
{
    /// <summary>
    /// Run producer
    /// </summary>
    void Run();
}
