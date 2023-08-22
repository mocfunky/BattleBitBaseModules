using BattleBitAPI.Common;
using BBRAPIModules;
using System.Threading.Tasks;

namespace Snipers
{
    public class Snipers : BattleBitModule
    {
        public override Task OnPlayerConnected(RunnerPlayer player)
        {
            player.SetNewRole(GameRole.Recon);
            return Task.CompletedTask;
        }
        public override async Task<bool> OnPlayerRequestingToChangeRole(RunnerPlayer player, GameRole requestedRole)
        {
            return GameRole.Recon == requestedRole;
        }
    }
}