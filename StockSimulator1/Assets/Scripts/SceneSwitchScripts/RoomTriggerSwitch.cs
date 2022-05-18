using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomTriggerSwitch : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
