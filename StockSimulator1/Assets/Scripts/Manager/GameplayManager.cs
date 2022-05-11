using Assets.Scripts;
using Assets.Scripts.Manager;
using UnityEngine;

public enum EStage
{
    Primary,
    Renew,
    PreFinal,
    Final
}
public class GameplayManager : MonoBehaviour
{
    public static GameplayModel gameplayModel { get; private set; } = default;
    private void Awake()
    {
        LoadInfo loadInfo = new LoadInfo();
        gameplayModel = loadInfo.LoadModel();
    }
    public void SwitchStage()
    {
        StageManager stageManager = new StageManager();
        if (gameplayModel.CurrentStage == EStage.Primary)
        {
            gameplayModel.CurrentStage = EStage.Renew;
           
            stageManager.OnStageSwitch.Invoke();
            return;
        }
        else if (gameplayModel.CurrentStage == EStage.Renew)
        {
            gameplayModel.CurrentStage = EStage.PreFinal;
            stageManager.OnStageSwitch.Invoke();
            return;
        }
        else if (gameplayModel.CurrentStage == EStage.PreFinal)
        {
            gameplayModel.CurrentStage = EStage.Final;
            stageManager.OnStageSwitch.Invoke();
            return;
        }

        gameplayModel.CurrentStage = EStage.Primary;
        stageManager.OnStageSwitch.Invoke();
    }
   
    private void OnDestroy()
    {
        SaveInfo saveCurrentInfo = new SaveInfo();
        saveCurrentInfo.SaveModel(gameplayModel);
    }

}