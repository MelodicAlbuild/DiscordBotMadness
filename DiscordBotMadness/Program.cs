using System.Threading.Tasks;

namespace DiscordBotMadness
{
    class Program
    {
        public static Task Main(string[] args)
            => Startup.RunAsync(args);
    }
}