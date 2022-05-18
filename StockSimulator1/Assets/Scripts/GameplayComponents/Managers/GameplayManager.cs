using Assets.Scripts;
using Assets.Scripts.GameplayComponents.Managers;
using Assets.Scripts.Manager;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum EGameStage
{
    Going,
    Win,
    Lose
}
public class GameplayManager : MonoBehaviour
{
    public static GameplayModel gameplayModel { get; private set; } = default;
    public static EGameStage currentE { get; private set; } = default;
    private void Awake()
    {
        LoadInfo loadInfo = new LoadInfo();
        gameplayModel = loadInfo.LoadModel();
        currentE = EGameStage.Going;
        if (!File.Exists(Application.dataPath + "\\GameFiles\\SavedGameModel.json"))
        {
            new StageManager().SwitchStage();
        }
    }
    public static void IsGameOver()
    {
        WinconditionManager winconditionManager =  new WinconditionManager();
        if (winconditionManager.IsWin())
        {
            currentE = EGameStage.Win;
            SceneManager.LoadScene("Final");
        }
        else if (winconditionManager.IsLose())
        {
            currentE = EGameStage.Lose;
            SceneManager.LoadScene("Final");
        }
    }
    private void OnDestroy()
    {
        SaveInfo saveCurrentInfo = new SaveInfo();
        saveCurrentInfo.SaveModel(gameplayModel);
    }

}