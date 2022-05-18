using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiSceneSwitch : MonoBehaviour
{
    [SerializeField] Button newGameButton;
    [SerializeField] Button savedGameButton;
    [SerializeField] string sceneName;
    void Awake()
    {
        newGameButton.onClick.AddListener(GenerateConfig);
        newGameButton.onClick.AddListener(ChangeSceneNewGame);
        savedGameButton.onClick.AddListener(ChangeSceneSavedGame);
    }
    private void OnDestroy()
    {
        newGameButton.onClick.RemoveAllListeners();
    }
    void ChangeSceneNewGame()
    {
        new SaveInfo().RemoveAllSavedInfo();
        SceneManager.LoadScene(sceneName);
    }
    void ChangeSceneSavedGame()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GenerateConfig()
    {
        ConfigGenerator configGenerator = new ConfigGenerator();
        configGenerator.GenerateCompanies();
        configGenerator.GenerateOcassions();
        configGenerator.GenerateHeadlines();
    }
}