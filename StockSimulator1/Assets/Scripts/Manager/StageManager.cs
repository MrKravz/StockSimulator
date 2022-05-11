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
        public  void PrimaryPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Primary)
            {
                Debug.Log("f");
            }
            //обновление цен на акции прибыль с акций
        }
        public  void RenewPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Renew)
            {
                LoadInfo loadInfo = new LoadInfo();
                NewsWorker newsWorker = new NewsWorker();
                newsWorker.GetNews(5, GameplayManager.gameplayModel.Companies, loadInfo.LoadHeadlineInfo());
            }
            // газета на сегодня
        }
        public  void PreFinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.PreFinal)
            {
                Debug.Log("f");
            }
            // случайное событие
        }
        public void FinalPhase()
        {
            if (GameplayManager.gameplayModel.CurrentStage == EStage.Final)
            {
                Debug.Log("f");
            }
            // вычет расходов за день
        }

    }
}
