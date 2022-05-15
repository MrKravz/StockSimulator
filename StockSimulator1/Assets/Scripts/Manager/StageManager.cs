using System;
using UnityEngine;

namespace Assets.Scripts.Manager
{
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
            }
        }
        public void RenewPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Renew)
            {
                LoadInfo loadInfo = new LoadInfo();
                NewsWorker newsWorker = new NewsWorker();
                GameplayManager.gameplayModel.Newspaper = newsWorker.GetNews(GameplayManager.gameplayModel.Companies, loadInfo.LoadHeadlineInfo());
            }
        }
        public void PreFinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.PreFinal)
            {
                Debug.Log("f");
            }
        }
        public void FinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Final)
            {
                new MoneyManager().DailyExpenses(GameplayManager.gameplayModel.Player);
            }
        }

    }
}
