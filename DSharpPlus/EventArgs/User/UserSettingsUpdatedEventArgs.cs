using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Represents arguments for <see cref="DiscordClient.UserSettingsUpdated"/> event.
/// </summary>
public class UserSettingsUpdatedEventArgs : DiscordEventArgs
{
    /// <summary>
    /// Gets the user whose settings were updated.
    /// </summary>
    public DiscordUser User { get; internal set; }

    internal UserSettingsUpdatedEventArgs() : base() { }
}
