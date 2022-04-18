using Discord;
using Discord.Interactions;
using LillyCSharp.Log;

namespace LillyCSharp
{
    // Must use InteractionModuleBase<SocketInteractionContext> for the InteractionService to auto-register the commands
    public class
    FunSlashCommand
    : InteractionModuleBase<SocketInteractionContext>
    {
        public InteractionService Commands { get; set; } = default!;

        private static Logger _logger =default!;

        public FunSlashCommand(ConsoleLogger logger)
        {
            _logger = logger;
        }

        // Basic slash command. [SlashCommand("name", "description")]
        // Similar to text command creation, and their respective attributes
        [SlashCommand("ping", "Receive a pong!")]
        public async Task Ping()
        {
            // New LogMessage created to pass desired info to the console using the existing Discord.Net LogMessage parameters
            await _logger
                .Log(new LogMessage(LogSeverity.Info,
                    "SlashCommand : Ping",
                    $"User: {Context.User.Username}, Command: ping",
                    null));

            // Respond to the user
            var PongEmbed = new EmbedBuilder()
            .WithDescription(Context.Client.Latency.ToString()+ "ms")
            .WithColor(Color.Green);
            

            await RespondAsync(embed:PongEmbed.Build());
        }
        
       
    }
}
