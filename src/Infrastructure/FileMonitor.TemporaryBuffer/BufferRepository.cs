namespace FileMonitor.TemporaryBuffer;

/// <summary>
/// Implementation of business logic of IBufferRepository
/// </summary>
internal sealed class BufferRepository 
        : IBufferRepository
{
    /// <summary>
    /// Take an item from the buffer
    /// </summary>
    /// <returns>Array of bytes</returns>
    byte[] IBufferRepository.PullFromBuffer()
            => GeneralBuffer.buffer.Take();

    /// <summary>
    /// Insert an item into the buffer
    /// </summary>
    /// <param name="bytes">Array of bytes</param>
    void IBufferRepository.PushToBuffer(byte[] bytes)
        => GeneralBuffer.buffer.Add(bytes);
}