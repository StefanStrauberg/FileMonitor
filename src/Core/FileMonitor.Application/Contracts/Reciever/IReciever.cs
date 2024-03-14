namespace FileMonitor.Application.Contracts.Reciever;

/// <summary>
/// General interface for running receiving services
/// </summary>
public interface IReciever : IDisposable
{
    /// <summary>
    /// Run reciever
    /// </summary>
    void Run();
}
