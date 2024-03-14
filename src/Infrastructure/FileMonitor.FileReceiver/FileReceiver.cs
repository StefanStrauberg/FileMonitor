namespace FileMonitor.FileReceiver;

internal sealed class FileReceiver(IFileReceiverConfiguration fileReceiverConfiguration,
                                   IAppLogger<FileReceiver> logger,
                                   IBufferRepository bufferRepository) 
    : IFileReceiver
{
    readonly IFileReceiverConfiguration _fileReceiverConfiguration = fileReceiverConfiguration
        ?? throw new ArgumentNullException(nameof(fileReceiverConfiguration));
    readonly IAppLogger<FileReceiver> _logger = logger
        ?? throw new ArgumentNullException(nameof(logger));
    readonly IBufferRepository _bufferRepository = bufferRepository
        ?? throw new ArgumentNullException(nameof(bufferRepository));

    public void Run()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}