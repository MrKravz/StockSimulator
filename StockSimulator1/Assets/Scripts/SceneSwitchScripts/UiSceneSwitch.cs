using Assers.Scripts.Generators;
using Assets.Scripts.InfoWorkers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.SceneSwitchScripts
{
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
            var audioSaved = savedGameButton.GetComponent<AudioSource>();
            savedGameButton.onClick.AddListener(() => audioSaved.Play());
            var audioNew = newGameButton.GetComponent<AudioSource>();
            newGameButton.onClick.AddListener(() => audioNew.Play());
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
}