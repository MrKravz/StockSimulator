using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSceneSwitch : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] string sceneName;
    void Awake()
    {
        button.onClick.AddListener(ChangeScene);
    }
    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeScene);
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
