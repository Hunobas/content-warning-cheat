using SpookSuite.Cheats.Core;
using SpookSuite.Manager;
using SpookSuite.Util;
using System.Linq;

namespace SpookSuite.Cheats
{
    internal class KillAll : ExecutableCheat
    {
        public override void Execute()
        {
            foreach (var p in GameObjectManager.players.Where(p => !p.IsLocal))
                if (!p.data.dead) p.Reflect().Invoke("CallDie");
        }
    }
}
