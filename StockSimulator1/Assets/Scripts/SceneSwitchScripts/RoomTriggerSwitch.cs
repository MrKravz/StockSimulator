using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.SceneSwitchScripts
{
    public class RoomTriggerSwitch : MonoBehaviour
    {
        [SerializeField] string sceneName;
        
        private void OnMouseDown()
        {
            var audio = GetComponent<AudioSource>();
            audio.Play();
            SceneManager.LoadScene(sceneName);
        }
    }
}