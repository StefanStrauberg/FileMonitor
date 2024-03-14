namespace FileMonitor.TemporaryBuffer.Models;

/// <summary>
/// Thread safe general buffer for concurrent operations between receiver and producer services
/// </summary>
internal static class GeneralBuffer
{
    /// <summary>
    /// Thread safe buffer based on BlockingCollection
    /// </summary>
    internal static BlockingCollection<byte[]> buffer = [];
}
