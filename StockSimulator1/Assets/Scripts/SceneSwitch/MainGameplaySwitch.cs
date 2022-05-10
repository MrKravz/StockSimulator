using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameplaySwitch : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
