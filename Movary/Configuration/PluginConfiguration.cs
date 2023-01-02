using MediaBrowser.Model.Plugins;

namespace Movary.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        // set default options here
        EnableScrobbler = false;
        MovaryApiUrl = string.Empty;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the scrobbler should be active.
    /// </summary>
    public bool EnableScrobbler { get; set; }

    /// <summary>
    /// Gets or sets movary api url.
    /// </summary>
    public string MovaryApiUrl { get; set; }
}