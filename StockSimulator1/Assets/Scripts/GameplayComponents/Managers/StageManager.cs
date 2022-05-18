using System;

namespace Assets.Scripts.Manager
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
                if (UnityEngine.Random.Range(1, 10) % 2 == 0)
                {

                }
            }
        }
        public void FinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Final)
            {
                new MoneyManager().DailyExpenses(GameplayManager.gameplayModel.Player);
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
