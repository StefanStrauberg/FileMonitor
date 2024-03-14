namespace FileMonitor.FileReceiver.Config;

/// <summary>
/// Interface of configuration of File receiver
/// </summary>
internal interface IFileReceiverConfiguration
{
    /// <summary>
    /// Path to file that will be processing,
    /// also receive abstract path that contain *
    /// instead of real directory, to read multiple
    /// directories with the same endpoint file in tree hierarchy,
    /// also receive abstract path that contain *
    /// instead name of endpoint file with extension, to read
    /// multiple files from endpoint directory,
    /// also combine both methods to rich the same result.
    /// </summary>
    /// <value></value>
    List<string> Path { get; set; }
}
