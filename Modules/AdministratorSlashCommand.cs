using Discord;
using Discord.Interactions;
using LillyCSharp.Log;
namespace LillyCSharp
{
    public class
AdministratorSlashCommand : InteractionModuleBase<SocketInteractionContext>
    {
        public InteractionService Commands { get; set; } = default!;
        private static Logger _logger = default!;
        public AdministratorSlashCommand(ConsoleLogger logger)
        { _logger = logger; }
        [SlashCommand("mute", "mute a member")]
        public async Task Mute()
        {
            await _logger.Log(
                new LogMessage(LogSeverity.Info, "SlashCommand : mute", $"User: {Context.User.Username}, Command: mute", null));
            await RespondAsync("Mute command!");
        }
    }
}