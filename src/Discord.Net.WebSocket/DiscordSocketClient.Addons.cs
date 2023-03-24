using System.Threading.Tasks;

namespace Discord.WebSocket
{
    public partial class DiscordSocketClient
    {
        public async Task<IUser> GetOwnerAsync()
        {
            return (await GetApplicationInfoAsync().ConfigureAwait(false)).Owner;
        }
    }
}
