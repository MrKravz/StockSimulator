using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.GameplayComponents.Managers
{
    public class WinconditionManager
    {
        public bool IsWin()
        {
            return GameplayManager.gameplayModel.Player.MoneyComponent.CurrentMoney >= 100000;
        }
        public bool IsLose()
        {
            return GameplayManager.gameplayModel.Player.MoneyComponent.CurrentMoney <= 0;
        }
    }
}
