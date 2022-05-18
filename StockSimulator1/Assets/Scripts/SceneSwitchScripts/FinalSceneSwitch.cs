using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.SceneSwitchScripts
{
    public class FinalSceneSwitch : MonoBehaviour
    {
        [SerializeField] TMP_Text text;
        [SerializeField] Button button;
        [SerializeField] string nameScene;
        private void Awake()
        {
            button.onClick.AddListener(() => SceneManager.LoadScene(nameScene));
            button.onClick.AddListener(() => new SaveInfo().RemoveAllSavedInfo());
            if (GameplayManager.currentE == EGameStage.Win)
            {
                text.color = Color.green;
                text.text = "Win";
                return;
            }
            else if (GameplayManager.currentE == EGameStage.Lose)
            {
                text.color = Color.red;
                text.text = "Lose";
            }
           
        }
        private void OnDestroy()
        {
            button.onClick.RemoveAllListeners();
        }
    }
}
