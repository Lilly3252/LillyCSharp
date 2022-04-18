using Discord;
using Discord.Interactions;
using LillyCSharp.Log;

namespace LillyCSharp
{
    // Must use InteractionModuleBase<SocketInteractionContext> for the InteractionService to auto-register the commands
    public class
    AdministratorSlashCommand
    : InteractionModuleBase<SocketInteractionContext>
    {
        public InteractionService Commands { get; set; } = default!;

        private static Logger _logger =default!;

        public AdministratorSlashCommand(ConsoleLogger logger)
        {
            _logger = logger;
        }

        // Basic slash command. [SlashCommand("name", "description")]
        // Similar to text command creation, and their respective attributes
        [SlashCommand("mute", "mute a member")]
        public async Task Mute()
        {
            // New LogMessage created to pass desired info to the console using the existing Discord.Net LogMessage parameters
            await _logger
                .Log(new LogMessage(LogSeverity.Info,
                    "SlashCommand : mute",
                    $"User: {Context.User.Username}, Command: mute",
                    null));

            // do stuff
            

            await RespondAsync("Mute command!");
        }
    }
}