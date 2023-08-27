using BattleBitAPI.Common;
using BBRAPIModules;
using System.Threading.Tasks;

namespace Snipers
{
    public class Snipers : BattleBitModule
    {
        //
        // Sets player's role to recon when they join
        //
        public override Task OnPlayerConnected(RunnerPlayer player)
        {
            player.SetNewRole(GameRole.Recon);
            return Task.CompletedTask;
        }
        //
        // Only allows to choose recon role
        //
        public override async Task<bool> OnPlayerRequestingToChangeRole(RunnerPlayer player, GameRole requestedRole)
        {
            return GameRole.Recon == requestedRole;
        }
        //
        // Disables night voting
        //
        public override Task OnConnected()
        {
            this.Server.ServerSettings.CanVoteDay = true;
            this.Server.ServerSettings.CanVoteNight = false;
            return Task.CompletedTask;
        }
    }
}