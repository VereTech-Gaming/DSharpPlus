namespace DSharpPlus.Entities;

/// <summary>
/// Enumerates permissions within Discord.
/// </summary>
/// <remarks>
/// Note that the values of permissions do not map to their raw values specified by Discord.
/// </remarks>
public enum DiscordPermission
{
    /// <summary>
    /// Allows creation of instant channel invites.
    /// </summary>
    CreateInstantInvite = 0,

    /// <summary>
    /// Allows kicking members.
    /// </summary>
    KickMembers = 1,

    /// <summary>
    /// Allows banning and unbanning members.
    /// </summary>
    BanMembers = 2,

    /// <summary>
    /// Enables full access on a given guild. This also overrides other permissions.
    /// </summary>
    Administrator = 3,

    /// <summary>
    /// Allows managing channels.
    /// </summary>
    ManageChannels = 4,

    /// <summary>
    /// Allows managing the guild.
    /// </summary>
    ManageGuild = 5,

    /// <summary>
    /// Allows adding reactions to messages.
    /// </summary>
    AddReactions = 6,

    /// <summary>
    /// Allows viewing audit log entries.
    /// </summary>
    ViewAuditLog = 7,

    /// <summary>
    /// Allows the use of priority speaker.
    /// </summary>
    PrioritySpeaker = 8,

    /// <summary>
    /// Allows users to go live in a voice channel.
    /// </summary>
    Stream = 9,

    /// <summary>
    /// Allows accessing text and voice channels. Disabling this permission hides channels.
    /// </summary>
    AccessChannels = 10,

    /// <summary>
    /// Allows sending messages and creating threads (does not allow sending messages in threads).
    /// </summary>
    SendMessages = 11,

    /// <summary>
    /// Allows sending text-to-speech messages.
    /// </summary>
    SendTtsMessages = 12,

    /// <summary>
    /// Allows managing messages of other users.
    /// </summary>
    ManageMessages = 13,

    /// <summary>
    /// Allows embedding content in messages.
    /// </summary>
    EmbedLinks = 14,

    /// <summary>
    /// Allows uploading files.
    /// </summary>
    AttachFiles = 15,

    /// <summary>
    /// Allows reading message history.
    /// </summary>
    ReadMessageHistory = 16,

    /// <summary>
    /// Allows using @everyone and @here mentions.
    /// </summary>
    MentionEveryone = 17,

    /// <summary>
    /// Allows using emojis or stickers from external servers, such as twitch or nitro emojis.
    /// </summary>
    UseExternalEmojis = 18,

    /// <summary>
    /// Allows viewing guild insights.
    /// </summary>
    ViewGuildInsights = 19,

    /// <summary>
    /// Allows connecting to voice chat.
    /// </summary>
    Connect = 20,

    /// <summary>
    /// Allows speaking in voice chat.
    /// </summary>
    Speak = 21,

    /// <summary>
    /// Allows muting other members in voice chat.
    /// </summary>
    MuteMembers = 22,

    /// <summary>
    /// Allows deafening other members in voice chat.
    /// </summary>
    DeafenMembers = 23,

    /// <summary>
    /// Allows moving voice chat members.
    /// </summary>
    MoveMembers = 24,

    /// <summary>
    /// Allows using voice activation in voice chat. Revoking this will usage of push-to-talk.
    /// </summary>
    UseVoiceDetection = 25,

    /// <summary>
    /// Allows changing of own nickname.
    /// </summary>
    ChangeNickname = 26,

    /// <summary>
    /// Allows managing nicknames of other members.
    /// </summary>
    ManageNicknames = 27,

    /// <summary>
    /// Allows managing roles in a guild.
    /// </summary>
    ManageRoles = 28,

    /// <summary>
    /// Allows managing webhooks in a guild.
    /// </summary>
    ManageWebhooks = 29,

    /// <summary>
    /// Allows managing guild emoji and stickers.
    /// </summary>
    ManageGuildExpressions = 30,

    /// <summary>
    /// Allows the user to use application commands.
    /// </summary>
    UseApplicationCommands = 31,

    /// <summary>
    /// Allows for requesting to speak in stage channels.
    /// </summary>
    RequestToSpeak = 32,

    /// <summary>
    /// Allows for managing scheduled guild events.
    /// </summary>
    ManageEvents = 33,

    /// <summary>
    /// Allows for deleting and archiving threads, and viewing all private threads.
    /// </summary>
    ManageThreads = 34,

    /// <summary>
    /// Allows for creating public threads.
    /// </summary>
    CreatePublicThreads = 35,

    /// <summary>
    /// Allows for creating private threads.
    /// </summary>
    CreatePrivateThreads = 36,

    /// <summary>
    /// Allows the usage of custom stickers from other servers.
    /// </summary>
    UseExternalStickers = 37,

    /// <summary>
    /// Allows for sending messages in threads.
    /// </summary>
    SendMessagesInThreads = 38,

    /// <summary>
    /// Allows for launching activities (applications with the `EMBEDDED` flag) in a voice channel.
    /// </summary>
    StartEmbeddedActivities = 39,

    /// <summary>
    /// Allows for moderating (Timeout) members in a guild.
    /// </summary>
    ModerateMembers = 40,

    /// <summary>
    /// Allows for viewing role subscription insights.
    /// </summary>
    ViewCreatorMonetizationAnalytics = 41,

    /// <summary>
    /// Allows for using soundboard in a voice channel.
    /// </summary>
    UseSoundboard = 42,

    /// <summary>
    /// Allows for creating emojis, stickers, soundboard sounds, editing and deleting those created by the current user.
    /// </summary>
    CreateGuildExpressions = 43,

    /// <summary>
    /// Allows for creating scheduled events, editing and deleting those created by the current user.
    /// </summary>
    CreateEvents = 44,

    /// <summary>
    /// Allows the usage of custom soundboard sounds from other servers.
    /// </summary>
    UseExternalSounds = 45,

    /// <summary>
    /// Allows sending voice messages.
    /// </summary>
    SendVoiceMessages = 46,

    /// <summary>
    /// Allows sending polls.
    /// </summary>
    SendPolls = 49,
}
