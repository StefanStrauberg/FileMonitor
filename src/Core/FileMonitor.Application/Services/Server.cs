namespace FileMonitor.Application.Services
{
    internal class Server(IInspectorOfTypeOfServer inspector,
                          IFileReciever fileReciever,
                          IUDPProducer udpProducer) 
        : BackgroundService
    {
        readonly IInspectorOfTypeOfServer _inspector = inspector
            ?? throw new ArgumentNullException(nameof(inspector));
        readonly IFileReciever _fileReciever = fileReciever
            ?? throw new ArgumentNullException(nameof(fileReciever));
        readonly IUDPProducer _udpProducer = udpProducer
            ?? throw new ArgumentNullException(nameof(udpProducer));

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            _ = _inspector.GetTypeOfReceiver() switch
            {
                TypeOfReceiver.file => ReceiverStart(_fileReciever,
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

        static Task ReceiverStart(IReciever receiver,
                                  CancellationToken stoppingToken)
            => Task.Run(() => receiver.Run(),
                        stoppingToken);

        static Task ProducerStart(IProducer producer,
                                  CancellationToken stoppingToken)
            => Task.Run(() => producer.Run(),
                        stoppingToken);
    }
}