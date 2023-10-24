
using DSharpPlus.Core.Abstractions.Models;

namespace DSharpPlus.Core.Models;

/// <inheritdoc cref="IAuditLogEntryInfo" />
public sealed record AuditLogEntryInfo : IAuditLogEntryInfo
{
    /// <inheritdoc/>
    public Optional<Snowflake> ApplicationId { get; init; }

    /// <inheritdoc/>
    public Optional<string> AutoModerationRuleName { get; init; }

    /// <inheritdoc/>
    public Optional<string> AutoModerationRuleTriggerType { get; init; }

    /// <inheritdoc/>
    public Optional<Snowflake> ChannelId { get; init; }

    /// <inheritdoc/>
    public Optional<string> Count { get; init; }

    /// <inheritdoc/>
    public Optional<string> DeleteMemberDays { get; init; }

    /// <inheritdoc/>
    public Optional<Snowflake> Id { get; init; }

    /// <inheritdoc/>
    public Optional<string> MembersRemoved { get; init; }

    /// <inheritdoc/>
    public Optional<Snowflake> MessageId { get; init; }

    /// <inheritdoc/>
    public Optional<string> RoleName { get; init; }

    /// <inheritdoc/>
    public Optional<string> Type { get; init; }
}