using Assets.Scripts.Generators;
using Assets.Scripts.InfoWorkers;
using System;

namespace Assets.Scripts.GameplayComponents.Managers
{
    public enum EStage
    {
        Primary,
        Renew,
        PreFinal,
        Final
    }
    public class StageManager
    {
        public Action OnStageSwitch { get; private set; } = default;
        public StageManager()
        {
            OnStageSwitch += PrimaryPhase;
            OnStageSwitch += RenewPhase;
            OnStageSwitch += PreFinalPhase;
            OnStageSwitch += FinalPhase;
        }
        public void PrimaryPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Primary)
            {
                new MoneyManager().StocksProfit(GameplayManager.gameplayModel.Player);
                new CompanyPriceManager().PerformPriceChanges(GameplayManager.gameplayModel);
                SwitchStage();
            }
        }
        public void RenewPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Renew)
            {
                LoadInfo loadInfo = new LoadInfo();
                NewsGenerator newsWorker = new NewsGenerator();
                GameplayManager.gameplayModel.Newspaper = newsWorker.GetNews(5, GameplayManager.gameplayModel.Companies, loadInfo.LoadHeadlineInfo());
            }
        }
        public void PreFinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.PreFinal)
            {
                    LoadInfo loadInfo = new LoadInfo();
                    FriendOcassionGenerator friendOcassionGenerator = new FriendOcassionGenerator();
                    GameplayManager.gameplayModel.Ocassion = friendOcassionGenerator.GetOcassion(loadInfo.LoadOcassionInfo());
            }
        }
        public void FinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Final)
            {
                new MoneyManager().DailyExpenses(GameplayManager.gameplayModel.Player);
                if (GameplayManager.gameplayModel.Ocassion != default)
                {
                    GameplayManager.gameplayModel.Player.MoneyComponent.Add(GameplayManager.gameplayModel.Ocassion.Amount);
                }
                SwitchStage();
            }
            GameplayManager.IsGameOver();
        }
        public void SwitchStage()
        {
            StageManager stageManager = new StageManager();
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Primary)
            {
                GameplayManager.gameplayModel.CurrentStage = EStage.Renew;
                stageManager.OnStageSwitch.Invoke();
                return;
            }
            else if (GameplayManager.gameplayModel.CurrentStage == EStage.Renew)
            {
                GameplayManager.gameplayModel.CurrentStage = EStage.PreFinal;
                stageManager.OnStageSwitch.Invoke();
                return;
            }
            else if (GameplayManager.gameplayModel.CurrentStage == EStage.PreFinal)
            {
                GameplayManager.gameplayModel.CurrentStage = EStage.Final;
                stageManager.OnStageSwitch.Invoke();
                return;
            }

            GameplayManager.gameplayModel.CurrentStage = EStage.Primary;
            stageManager.OnStageSwitch.Invoke();
        }
    }
}
