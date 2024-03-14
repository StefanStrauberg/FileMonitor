namespace FileMonitor.Application.Contracts.Receiver;

/// <summary>
/// General interface for running receiving services
/// </summary>
public interface IReceiver : IDisposable
{
    /// <summary>
    /// Run reciever
    /// </summary>
    void Run();
}
