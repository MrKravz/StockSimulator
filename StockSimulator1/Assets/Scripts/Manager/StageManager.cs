using System;

namespace Assets.Scripts.Manager
{
   public class StageManager
    {
        public Action OnStageSwitch { get; private set; } = default;
        public StageManager()
        {
            OnStageSwitch+= PrimaryPhase;
            OnStageSwitch+= RenewPhase;
            OnStageSwitch+= PreFinalPhase;
            OnStageSwitch+= FinalPhase;
        }

        public void PrimaryPhase()
        {
            //обновление цен на акции прибыль с акций
        }
        public void RenewPhase()
        {
            // газета на сегодня
        }
        public void PreFinalPhase()
        {
            // случайное событие
        }
        public void FinalPhase()
        {
            // вычет расходов за день
        }
    }
}
