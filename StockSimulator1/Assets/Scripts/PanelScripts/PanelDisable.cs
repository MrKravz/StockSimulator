using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PanelScripts
{
    public class PanelDisable : MonoBehaviour
    {
        [SerializeField] GameObject panel;
        [SerializeField] Button button;
        private void Awake()
        {
            var audio = button.GetComponent<AudioSource>();
            button.onClick.AddListener(() => audio.Play());
            button.onClick.AddListener(() => panel.SetActive(false));
        }
        private void OnDestroy()
        {
            button.onClick.RemoveAllListeners();
        }
    }
}
