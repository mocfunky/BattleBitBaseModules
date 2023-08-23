using BBRAPIModules;
using System.Threading.Tasks;

namespace Rotations
{
    public class Rotation : BattleBitModule
    {
        public override Task OnConnected()
        {
            // The gamemodes you want

            this.Server.GamemodeRotation.SetRotation("InfantryConquest");

            // The maps you want

            //this.Server.MapRotation.SetRotation("Valley");
            return Task.CompletedTask;
        }
    }
}