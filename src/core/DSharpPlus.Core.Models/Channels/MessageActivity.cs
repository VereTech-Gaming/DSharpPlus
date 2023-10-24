// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using DSharpPlus.Entities;

using DSharpPlus.Core.Abstractions.Models;

namespace DSharpPlus.Core.Models;

/// <inheritdoc cref="IMessageActivity" />
public sealed record MessageActivity : IMessageActivity
{
    /// <inheritdoc/>
    public required DiscordMessageActivityType Type { get; init; }

    /// <inheritdoc/>
    public Optional<string> PartyId { get; init; }
}