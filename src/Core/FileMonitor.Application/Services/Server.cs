namespace FileMonitor.Application.Services
{
    internal class Server(IInspectorOfTypeOfServer inspector,
                          IFileReceiver fileReceiver,
                          IUDPProducer udpProducer) 
        : BackgroundService
    {
        readonly IInspectorOfTypeOfServer _inspector = inspector
            ?? throw new ArgumentNullException(nameof(inspector));
        readonly IFileReceiver _fileReceiver = fileReceiver
            ?? throw new ArgumentNullException(nameof(fileReceiver));
        readonly IUDPProducer _udpProducer = udpProducer
            ?? throw new ArgumentNullException(nameof(udpProducer));

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            _ = _inspector.GetTypeOfReceiver() switch
            {
                TypeOfReceiver.file => ReceiverStart(_fileReceiver,
                                                     stoppingToken),
                _ => throw new ArgumentException("Invalid incomming type of Reciever"),
            };

            _ = _inspector.GetTypeOfProducer() switch
            {
                TypeOfProducer.udp => ProducerStart(_udpProducer,
                                                    stoppingToken),
                _ => throw new ArgumentException("Invalid incomming type of Producer"),
            };
            
            return Task.CompletedTask;
        }

        static Task ReceiverStart(IReceiver receiver,
                                  CancellationToken stoppingToken)
            => Task.Run(() => receiver.Run(),
                        stoppingToken);

        static Task ProducerStart(IProducer producer,
                                  CancellationToken stoppingToken)
            => Task.Run(() => producer.Run(),
                        stoppingToken);
    }
}