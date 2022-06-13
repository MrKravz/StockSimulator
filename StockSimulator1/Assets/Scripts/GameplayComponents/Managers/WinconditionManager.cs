namespace Assets.Scripts.GameplayComponents.Managers
{
    public class WinconditionManager
    {
        public bool IsWin()
        {
            return GameplayManager.gameplayModel.Player.MoneyComponent.CurrentMoney >= 1000000000;
        }
        public bool IsLose()
        {
            return GameplayManager.gameplayModel.Player.MoneyComponent.CurrentMoney <= 0;
        }
    }
}
