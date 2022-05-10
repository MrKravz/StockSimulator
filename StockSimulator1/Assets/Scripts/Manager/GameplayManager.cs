using Assets.Scripts;
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
        if (gameplayModel.CurrentStage == EStage.Primary)
        {
            gameplayModel.CurrentStage = EStage.Renew;

            return;
        }
        else if (gameplayModel.CurrentStage == EStage.Renew)
        {
            gameplayModel.CurrentStage = EStage.PreFinal;
            return;
        }
        else if (gameplayModel.CurrentStage == EStage.PreFinal)
        {
            gameplayModel.CurrentStage = EStage.Final;
            return;
        }
        gameplayModel.CurrentStage = EStage.Primary;
    }
   
    private void OnDestroy()
    {
        SaveInfo saveCurrentInfo = new SaveInfo();
        saveCurrentInfo.SaveModel(gameplayModel);
    }

}