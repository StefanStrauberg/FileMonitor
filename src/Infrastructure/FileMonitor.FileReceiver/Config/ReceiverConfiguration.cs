
namespace FileMonitor.FileReceiver.Config;

internal sealed class ReceiverConfiguration 
    : IFileReceiverConfiguration
{
    public List<string> Path { get ; set; } = [];
}
